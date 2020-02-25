package Model.Mediator;

import Model.Domain.Item;
import Model.Domain.Order;
import Model.Domain.User;

import java.util.ArrayList;


  public interface AdaptorModel {

    Package getAllItems();
    Package getAllOrders();
    Package getUserById(int id);
    Package registerUser(User user);
    Package addItem(Item item);
    Package addOrder(Order order);
    Package updateUser(User user);
    Package updateItem(Item item);
    Package updateOrderDetails(Order order);
    Package getUsersOrders(int Userid);
    Package deleteUser(int id);
    Package deleteItem(int id);
    Package loginUser(String username);

  }
