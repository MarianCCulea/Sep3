package Main;

import java.util.ArrayList;
import java.util.Map;
import java.util.concurrent.atomic.AtomicLong;

import Model.Domain.Item;
import Model.Domain.Order;
import Model.Domain.User;
import Model.Mediator.Model;
import Model.Mediator.ModelManager;
import com.google.gson.Gson;
import org.springframework.context.annotation.Bean;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import static org.springframework.web.bind.annotation.RequestMethod.GET;

@RestController
public class Controller {
    private final Model model = new ModelManager();
    private Gson gson=new Gson();


    @GetMapping("/items")
    @ResponseBody
    public ArrayList<Item> getAllItems() {
        return model.getAllItems();
    }

    @RequestMapping(value = "/orders", method = RequestMethod.GET)
    public ArrayList<Order> getOrders(@RequestParam(value = "userId",defaultValue = "0") Integer userId) {
        if(userId==0)
    return model.getAllOrders();
      return model.getUsersOrders(userId);
    }

    @PostMapping("/items")
    public boolean addItem(@RequestBody String newItem) {
        Item item=gson.fromJson(newItem,Item.class);
        return model.addItem(item);
    }

    @PostMapping("/orders")
    public boolean addOrder(@RequestBody String newOrder) {
        Order order=gson.fromJson(newOrder,Order.class);
        return model.addOrder(order);
    }

    @RequestMapping(value = "/users", method = RequestMethod.POST)
    //  consumes = MediaType.APPLICATION_JSON_VALUE)
    public String registerUser(@RequestBody String newUser) {
        System.out.println(newUser);
        Gson g = new Gson();
        User user = g.fromJson(newUser, User.class);
        return model.registerUser(user);
        //return model.add(newUser);
    }

    @GetMapping("/users/login")
    public String userLogin(@RequestParam(value = "username",defaultValue = "0") String username,
                            @RequestParam(value = "password",defaultValue = "0") String password) {
        return model.loginUser(username,password);
    }

    @PutMapping("/items/{id}")
    public boolean updateItem(@RequestBody String item, @PathVariable int id) {
        Item update=gson.fromJson(item,Item.class);
return model.updateItem(update,id);
    }

    @PutMapping("/orders/{id}")
    public boolean updateOrder(@RequestBody String order, @PathVariable int id) {
        Order update=gson.fromJson(order,Order.class);
return model.updateOrderDetails(update,id);
    }

        @PutMapping("/users/{id}")
        public boolean updateUser(@RequestBody String user, @PathVariable int id) {
            User update=gson.fromJson(user,User.class);
        return model.updateUser(update,id);
        }

    @DeleteMapping("/items/{id}")
    public boolean deleteItem(@PathVariable int id) { return model.deleteItem(id); }

    @DeleteMapping("/users/{id}")
    public boolean deleteUser(@PathVariable int id) {
        return model.deleteUser(id);
    }

    @GetMapping("/users/{id}")
    public User getUser(@PathVariable int id) {
        User user = model.getUserById(id);
        return user; }

}