package Model.Mediator;

import Model.Domain.Item;
import Model.Domain.Order;
import Model.Domain.User;

import java.util.ArrayList;

public interface Model {
    ArrayList<Item> getAllItems();
    ArrayList<Order> getAllOrders();
    ArrayList<Order> getUsersOrders(int Userid);
    boolean addItem(Item item);
    boolean addOrder(Order order);
    String registerUser(User user);
    String loginUser(String username,String password);
    boolean updateItem(Item item,int id);
    boolean updateOrderDetails(Order order,int id);
    boolean updateUser(User user,int id);
    boolean deleteItem(int id);
    boolean deleteUser(int id);
    User getUserById(int id);
}
