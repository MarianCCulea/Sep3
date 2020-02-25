package Model.Mediator;

import Model.Domain.Item;
import Model.Domain.Order;
import Model.Domain.User;
import com.google.gson.Gson;

import java.sql.SQLException;
import java.util.ArrayList;


public class Adaptor implements AdaptorModel {
    private Database database;
    private Gson gson;

    public Adaptor(){
        this.gson=new Gson();
        this.database=Database.getInstance();
    }


    @Override
    public Package getAllItems() {
        ArrayList<Item> items;
        try {
            items = database.getAllItems();
            return new Package(gson.toJson(items),"GET_ITEMS","SUCCESS");
        } catch (SQLException e) {
            e.printStackTrace();
            return new Package("DATABASE_ERROR");
        }

    }

    @Override
    public Package getAllOrders() {
        ArrayList<Order> orders;
        try {
            orders = database.getAllOrders();
            return new Package(gson.toJson(orders),"GET_ORDERS","SUCCESS");
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return new Package("DATABASE_ERROR");
    }

    @Override
    public Package getUserById(int id) {
        String user= null;
        try {
            user = gson.toJson(database.getUserById(id));
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return new Package(user,"GET_USER","SUCCESS");
    }

    @Override
    public Package registerUser(User user) {
        try {
            database.registerUser(user);
            return new Package("SUCCESS");
        } catch (SQLException e) {
            e.printStackTrace();
            return new Package("Username in use.");
        }

    }

    @Override
    public Package addItem(Item item) {
        try {
            database.addItem(item);
            return new Package("SUCCESS");
        } catch (SQLException e) {
            e.printStackTrace();
            return new Package("DATABASE_ERROR");
        }
    }

    @Override
    public Package addOrder(Order order) {
        try{
        database.addOrder(order);
        return new Package("SUCCESS");
        }
        catch (Exception e){
            e.printStackTrace();
            return new Package("DATABASE_ERROR");
        }
    }

    @Override
    public Package updateUser(User user) {
        try{
       database.updateUser(user);
        return new Package("SUCCESS");}
        catch (Exception e){
            e.printStackTrace();
            return new Package("DATABASE_ERROR");
        }
    }

    @Override
    public Package updateItem(Item item) {
        try {
            database.updateItem(item);
            return new Package("SUCCESS");
        }catch (Exception e){
            e.printStackTrace();
            return new Package("DATABASE_ERROR");
        }
    }


    @Override
    public Package updateOrderDetails(Order order) {
        try {
            database.updateOrderDetails(order);
            return new Package("SUCCESS");
        }catch (Exception e){
            e.printStackTrace();
            return new Package("DATABASE_ERROR");}
    }



    @Override
    public Package getUsersOrders(int userid) {
        try {
            ArrayList<Order> orders = database.getUserOrders(userid);
            return new Package(gson.toJson(orders), "GET_USER_ORDERS", "SUCCESS");
        }catch (Exception e){e.printStackTrace();
            return new Package("DATABASE_ERROR");
        }
        }


    @Override
    public Package deleteUser(int id) {
        try{
        database.deleteUser(id);
        return new Package("SUCCESS");
    }catch (Exception e){e.printStackTrace();
        return new Package("DATABASE_ERROR");}
    }

    @Override
    public Package deleteItem(int id) {
        try{
        database.deleteItem(id);
        return new Package("SUCCESS");
        }catch (Exception e){e.printStackTrace();
            return new Package("DATABASE_ERROR");}
    }

    @Override
    public Package loginUser(String username) {
        try{
        User user=database.getUserByUsername(username);
        return new Package(gson.toJson(user),"LOGIN","SUCCESS");
        }catch (Exception e){e.printStackTrace();
            return new Package("DATABASE_ERROR");}
    }
}
