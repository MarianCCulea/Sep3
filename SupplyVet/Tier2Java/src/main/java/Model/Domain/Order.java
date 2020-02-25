package Model.Domain;

import java.util.ArrayList;

public class Order {
    private int id;
    private int userid;
    private String adress;
    private String invoiceadress;
    private float totalprice;
    private int totalitems;
    private int phone;
    private boolean delivered;
    private ArrayList<Item> items;
    private int[] itemsCount;


    public Order(){}
    public Order(int id , int userid, String adress, String invoiceadress, Float totalprice, int totalitems, int phone, boolean delivered, ArrayList<Item> items, int[] itemscount) {
        this.id = id;
        this.userid = userid;
        this.adress = adress;
        this.invoiceadress = invoiceadress;
        this.totalprice = totalprice;
        this.totalitems = totalitems;
        this.phone = phone;
        this.delivered=delivered;
        this.items=items;
        this.itemsCount=itemscount;
    }
    public Order(int id , int userid, String adress, String invoiceadress, Float totalprice, int totalitems, int phone, boolean delivered) {
        this.id = id;
        this.userid = userid;
        this.adress = adress;
        this.invoiceadress = invoiceadress;
        this.totalprice = totalprice;
        this.totalitems = totalitems;
        this.phone = phone;
        this.delivered=delivered;
        this.items=new ArrayList<>();
        this.itemsCount=null;
    }

    public Order(int userid, String adress, String invoiceadress, Float totalprice, int totalitems, int phone, boolean delivered, ArrayList<Item> items, int[] itemscount) {
        this.id = 0;
        this.userid = userid;
        this.adress = adress;
        this.invoiceadress = invoiceadress;
        this.totalprice = totalprice;
        this.totalitems = totalitems;
        this.phone = phone;
        this.delivered=delivered;
        this.items=items;
        this.itemsCount=itemscount;
    }
    public Order(int id , int userid, String adress, String invoiceadress, Float totalprice, int totalitems, int phone, boolean delivered, ArrayList<Item> items) {
        this.id = id;
        this.userid = userid;
        this.adress = adress;
        this.invoiceadress = invoiceadress;
        this.totalprice = totalprice;
        this.totalitems = totalitems;
        this.phone = phone;
        this.delivered=delivered;
        this.items=items;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getUserid() {
        return userid;
    }

    public void setUserid(int userid) {
        this.userid = userid;
    }

    public String getAdress() {
        return adress;
    }

    public void setAdress(String adress) {
        this.adress = adress;
    }

    public String getInvoiceadress() {
        return invoiceadress;
    }

    public void setInvoiceadress(String invoiceadress) {
        this.invoiceadress = invoiceadress;
    }

    public float getTotalprice() {
        return totalprice;
    }

    public void setTotalprice(float totalprice) {
        this.totalprice = totalprice;
    }

    public int getTotalitems() {
        return totalitems;
    }

    public void setTotalitems(int totalitems) {
        this.totalitems = totalitems;
    }

    public int getPhone() {
        return phone;
    }

    public void setPhone(int phone) {
        this.phone = phone;
    }

    public boolean isDelivered() {
        return delivered;
    }

    public void setDelivered(boolean delivered) {
        this.delivered = delivered;
    }

    public ArrayList<Item> getItems() {
        return items;
    }

    public void setItems(ArrayList<Item> items) {
        this.items = items;
    }

    public int[] getItemsCount() {
        return itemsCount;
    }

    public void setItemsCount(int[] itemsCount) {
        this.itemsCount = itemsCount;
    }
}
