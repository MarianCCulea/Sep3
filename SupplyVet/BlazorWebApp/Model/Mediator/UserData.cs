using BlazorWebApp.Model.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace BlazorWebApp.Shared
{
    public interface IUserData
    {
        void ClearOrder();
        IList<Item> CartItems();
        public bool setItem(Item item, int n);
        IList<Order> AllOrders();
        Item ItemById(int id);
        User GetUser();
        Task GetUserAsync(int id);
        Task<IList<Item>> RequestAllItemsAsync();
        Task<string> PostOrderAsync(string adress, string invoiceadress, int phone,int useridd);
        Task<string> RegisterAsync(User user);
        Task<User> LoginUserAsync(string username, string password);
        Task<string> PutUserAsync(User user);
        Task DeleteUser(int id);
        int[] GetCount();
    }

    public class UserData : IUserData
    {
        public DataLayer dataLayer;
        public User user { get; set; }

        public IList<Item> cartitems { get; set; }
        public int[] count { get; set; } = new int[50];
        private int size = 0;
        public UserData()
        {
            cartitems = new List<Item>();
            dataLayer = DataLayer.Instance;
        }
        public IList<Order> AllOrders() => user.orders;
        public User GetUser() => new User
        {
            id = user.id,
            username = user.username,
            fullname = user.fullname,
            email=user.email,
            password=user.password,
            vetid=user.vetid,
            orders=user.orders
        };
        public int[] GetCount() => count;
        public Order CloneOrder(Order source) => new Order
        {
            id = source.id,
            adress = source.adress,
            invoiceadress = source.invoiceadress,
        };

        public Boolean setItem(Item item,int n)
        {
            for(int i = 0; i < cartitems.Count; i++)
            {
                if (cartitems[i].id == item.id)
                {
                    count[i] += n;
                    return true;
                }
            }

            cartitems.Add(item);
            count[size] += n;
            size++;
            return false;
        }
        public IList<Item> CartItems() => cartitems;

        public async Task<string> RegisterAsync(User user)
        {
            return await dataLayer.RegisterUserAsync(user);
        }

        public async Task<IList<Item>> RequestAllItemsAsync()
        {
            return await dataLayer.RequestAllItemsAsync();
        }

        public Item ItemById(int id)
        {
            return dataLayer.ItemById(id);
        }
        public async Task<string> PostOrderAsync(string adress,string invoiceadress,int phone,int useridd)
        {
            User users = new User
            {
                id = useridd
            };
            Console.WriteLine(useridd+"");
            Console.WriteLine(users.id+"");
            Order ordertopost = new Order
            {
                userid = useridd,
                adress = adress,
                invoiceadress = invoiceadress,
                phone = phone,
                items = cartitems,
                itemsCount = count
            };

            ordertopost.calculatetotalprice();
            Console.WriteLine(ordertopost.items[0].name + " LASKDJASF");
            Console.WriteLine(ordertopost.items[0].name + " LASKDJASF");
            Console.WriteLine(ordertopost.items[0].name + " LASKDJASF");
            Console.WriteLine(ordertopost.items[0].name + " LASKDJASF");
            Console.WriteLine(ordertopost.items[0].name + " LASKDJASF");
            Console.WriteLine(ordertopost.items[0].name + " LASKDJASF");
            return await dataLayer.PostOrderAsync(ordertopost);
        }

        public async Task<User> LoginUserAsync(string username, string password)
        {
            var serializer = new DataContractJsonSerializer(typeof(User));
            string json = await dataLayer.LoginUserAsync(username, password);
           User usera= JsonConvert.DeserializeObject<User>(json);
            return usera;
        }

        public async Task GetUserAsync(int id)
        {
            string json = await dataLayer.GetUserAsync(id);
            this.user = JsonConvert.DeserializeObject<User>(json);
        }

        public async Task<string> PutUserAsync(User user)
        {
            this.user=await dataLayer.PutUserAsync(user);
            return "Success";
        }

        public async Task DeleteUser(int id)
        {
            await dataLayer.DeleteUser(id);
        }

        public void ClearOrder()
        {

            this.cartitems = new List<Item>();
            this.size = 0;
            this.count = new int[50];
        }

        


    }
}
