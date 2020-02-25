package Model.Mediator;

import Model.Domain.Item;
import Model.Domain.Order;
import Model.Domain.User;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.google.gson.Gson;
import org.springframework.context.ConfigurableApplicationContext;

import java.util.ArrayList;


public class ModelManager implements Model {
    private ArrayList<User> users = new ArrayList<>();
    private SocketClient socket;
    private Gson gson;
    ObjectMapper mapper;


    public ModelManager() {
        mapper = new ObjectMapper();
        mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
        gson = new Gson();
       this.socket = new SocketClient();
        System.out.println("Model constructor");

    }

    @Override
    public ArrayList<Item> getAllItems() {
        ArrayList<Item> items;
        Package pack = new Package("GET", "ITEMS");
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response != null) {
            try {
                items = mapper.readValue(response.getJson(), new TypeReference<ArrayList<Item>>() {
                });
                return items;
            } catch (JsonProcessingException e) {
                e.printStackTrace();
            }

            return null;
        }
        return null;
    }

    @Override
    public ArrayList<Order> getAllOrders() {
        ArrayList<Order> orders;
        Package pack = new Package("GET", "ORDERS");
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response != null) {
            try {
                orders = mapper.readValue(response.getJson(), new TypeReference<ArrayList<Order>>() {
                });
                return orders;
            } catch (JsonProcessingException e) {
                e.printStackTrace();
            }
            return null;
        }
        return null;
    }


    @Override
    public User getUserById(int id) {
        Package pack = new Package("GET", "USER",id);
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response != null) {
            User user = gson.fromJson(response.getJson(), User.class);
            return user;
        }
        return null;
    }

    @Override
    public String registerUser(User user) {
        String json=gson.toJson(user);
        if(user.getVetid()<100000&&user.getVetid()>999999)
            return "Vet Id Not Valid";
        Package pack = new Package(json,"REGISTER", "USER");
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response.getArgument().equals("SUCCESS"))
            return "Registered user in the database.";
        else
            return response.getArgument();
    }


    @Override
    public boolean addItem(Item item) {
        String itemjson = gson.toJson(item);
        Package pack = new Package(itemjson, "REGISTER", "ITEM");
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response.getArgument().equals("SUCCESS")) {
            return true;
        }
        return false;
    }

    @Override
    public boolean addOrder(Order order) {
        if (enoughItems(order, getAllItems())) {
            String orderjson = gson.toJson(order);
            Package pack = new Package(orderjson, "REGISTER", "ORDER");
            String request = gson.toJson(pack);
            Package response = socket.sendAndReceive(request);
            if (response.getArgument().equals("SUCCESS"))
                return true;
        }
        return false;
    }


    private boolean enoughItems(Order order, ArrayList<Item> items) {
        ArrayList<Item> orderItems = order.getItems();
        ArrayList<Item> updatedItems = new ArrayList<>();
        for (int i = 0; i < orderItems.size(); i++) {
            for (int j = 0; j < items.size(); j++) {
                if (orderItems.get(i).getId() == items.get(j).getId()){
                    updatedItems.add(items.get(j));}
            }
        }
        for (int i = 0; i < updatedItems.size(); i++) {
            if (updatedItems.get(i).getNrofitems() - order.getItemsCount()[i] < 0)
                return false;
        }
        return true;
    }

    @Override
    public boolean updateUser(User user, int id) {
        return false;
    }

    @Override
    public boolean updateItem(Item item, int id) {
        String itemjson = gson.toJson(item);
        Package pack = new Package(itemjson, "UPDATE", "ITEM", id);
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response.getArgument().equals("SUCCESS"))
            return true;

        return false;
    }

    @Override
    public boolean updateOrderDetails(Order order, int id) {
        String orderjson = gson.toJson(order);
        Package pack = new Package(orderjson, "UPDATE", "ORDER", id);
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response.getArgument().equals("SUCCESS"))
            return true;
        return false;
    }

    @Override
    public ArrayList<Order> getUsersOrders(int Userid) {
        ArrayList<Order> orders;
        Package pack = new Package("GET", "USER_ORDERS", Userid);
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response != null) {
            try {
                orders = mapper.readValue(response.getJson(), new TypeReference<ArrayList<Order>>() {
                });
                return orders;
            } catch (JsonProcessingException e) {
                e.printStackTrace();
            }
            return null;
        }
        return null;
    }


    @Override
    public boolean deleteUser(int id) {
        Package pack = new Package("DELETE", "USER", id);
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response.getArgument().equals("SUCCESS"))
            return true;
        return false;
    }

    @Override
    public boolean deleteItem(int id) {
        Package pack = new Package("DELETE", "ITEM", id);
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if (response.getArgument().equals("SUCCESS"))
            return true;
        return false;
    }

    @Override
    public String loginUser(String username,String password) {
        User user=new User(username);
        Package pack = new Package(user.getUsername(), "GET", "USER",0);
        String request = gson.toJson(pack);
        Package response = socket.sendAndReceive(request);
        if(response.getArgument().equals("DATABASE_ERROR"))
            return "Username does not exist";
        if (response.getJson() == null)
            return "Username incorrect";
        else {
            User loginuser = gson.fromJson(response.getJson(), User.class);
            if (loginuser.getPassword().equals(password))
                return response.getJson();
            return "Password incorrect";
        }
    }
}
