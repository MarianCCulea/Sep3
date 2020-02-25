package Model.Domain;

import java.util.ArrayList;

public class User {
    private int id;
    private String username;
    private String fullname;
    private String email;
    private String password;
    private String role;
    private int vetid;
    private ArrayList<Order> orders;

    public User(int id,String username,String fullname,String email,String password,String role,int vetid){
        this.id=id;
        this.username=username;
        this.fullname=fullname;
        this.email=email;
        this.password=password;
        this.role=role;
        this.vetid=vetid;
        this.orders=new ArrayList<>();
    }
    public User(int id,String username,String fullname,String email,String password,String role,int vetid,ArrayList<Order> orders){
        this.id=id;
        this.username=username;
        this.fullname=fullname;
        this.email=email;
        this.password=password;
        this.role=role;
        this.vetid=vetid;
        this.orders=orders;
    }
    public User(String username){
        this.id=0;
        this.username=username;
        this.fullname=null;
        this.email=null;
        this.password=null;
        this.role=null;
        this.vetid=0;
    }
    public User(){
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }

    public int getVetid() {
        return vetid;
    }

    public void setVetid(int vetid) {
        this.vetid = vetid;
    }

    public ArrayList<Order> getOrders() {
        return orders;
    }

    public void setOrders(ArrayList<Order> orders) {
        this.orders = orders;
    }
}
