using BlazorWebApp.Model.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace BlazorWebApp.Shared
{
 
    public interface IDataLayer
    {
        IList<Item> AllItems();
        Item ItemById(int id);
        Item ItemForEditing(int id);
        Task<IList<Item>> RequestAllItemsAsync();
        Task<List<Order>> RequestAllOrdersAsync();
        Task<string> GetUserAsync(int id);
        Task<List<Order>> RequestUserOrderAsync(int id);
        Task<string> PostItemAsync(Item item);
        Task<string> PostOrderAsync(Order order);
        Task<string> RegisterUserAsync(User user);
        Task<string> LoginUserAsync(string username,string password);
        Task<string> PutItemAsync(Item item);
        Task<string> PutOrderAsync(Order order);
        Task<User> PutUserAsync(User user);
        Task<string> DeleteItem(int id);
        Task<string> DeleteUser(int id);
    }

    public class DataLayer : IDataLayer
    {
        public IList<Item> items { get; set; }
        public IList<Order> orders;
        public static DataLayer instance=null;
        private static readonly object padlock = new object();
        HttpClient client = new HttpClient();
        public DataLayer()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
        }

        public static DataLayer Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataLayer();
                    }
                    return instance;
                }
            }
        }

        public IList<Item> AllItems() => items;
        public Item ItemById(int id) => items.SingleOrDefault(t => t.id == id);
        public Item CloneItem(Item source) => new Item
        {
            id = source.id,
            name = source.name,
            url = source.url,
        };
        public Item ItemForEditing(int id) => CloneItem(ItemById(id));
        public async Task<string> SubmitChangesAsync(Item item)
        {
            var serializer = new DataContractJsonSerializer(typeof(Item));
             //JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            string uri = "https://localhost:8080/items/"+item.id;
            string jsonString;
            jsonString = JsonConvert.SerializeObject(item);

            HttpContent content = new StringContent(jsonString);
            var streamTask = client.PutAsync(uri,content);
            string result= await streamTask.Result.Content.ReadAsStringAsync();
            if (result.Equals("true"))
            {
                items = await RequestAllItemsAsync();
                return "Success";
            }
            else
            {
                return "Fail";
            }


        }
            public async Task<IList<Item>> RequestAllItemsAsync()
            {
            string uri = "https://localhost:8080/items";
            var streamTask = client.GetAsync(uri);
            var stream = await streamTask.Result.Content.ReadAsStringAsync();
            items= JsonConvert.DeserializeObject<List<Item>>(stream);
            return items;
            }


        public async Task<List<Order>> RequestAllOrdersAsync()
        {
            string uri = "https://localhost:8080/orders";
            var streamTask = client.GetAsync(uri);
            var stream = await streamTask.Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Order>>(stream);
        }

        public async Task<List<Order>> RequestUserOrderAsync(int id)
        {
            string uri = "https://localhost:8080/orders?userId="+id;
            var streamTask = client.GetAsync(uri);
            var stream = await streamTask.Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Order>>(stream);
        }

        public async Task<string> PostItemAsync(Item item)
        {
            string uri = "https://localhost:8080/items";
            string jsonString;
            jsonString = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(jsonString);
            var streamTask = client.PostAsync(uri, content);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> PostOrderAsync(Order order)
        {
            string uri = "https://localhost:8080/orders";
            string jsonString;
            jsonString = JsonConvert.SerializeObject(order);
            HttpContent content = new StringContent(jsonString);
            var streamTask = client.PostAsync(uri, content);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> RegisterUserAsync(User user)
        {
            string uri = "https://localhost:8080/users";
            string jsonString;
            jsonString = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(jsonString);
            var streamTask = client.PostAsync(uri, content);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
                return result;
        }

        public async Task<string> LoginUserAsync(string username, string password)
        {
            string uri = "https://localhost:8080/users/login?username=" + username+"&password="+password;
            var streamTask = client.GetAsync(uri);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> PutItemAsync(Item item)
        {
            string uri = "https://localhost:8080/items/"+item.id;
            string jsonString;
            jsonString = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(jsonString);
            var streamTask = client.PutAsync(uri, content);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            if (result.Equals("true"))
            {
                items = await RequestAllItemsAsync();
                return "Success";
            }
            else
            {
                return "Fail";
            }
        }

        public async Task<string> PutOrderAsync(Order order)
        {
            string uri = "https://localhost:8080/orders/" + order.id;
            string jsonString;
            jsonString = JsonConvert.SerializeObject(order);
            HttpContent content = new StringContent(jsonString);
            var streamTask = client.PutAsync(uri, content);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            if (result.Equals("true"))
            {
                items = await RequestAllItemsAsync();
                orders = await RequestAllOrdersAsync();
                return "Success";
            }
            else
            {
                return "Fail";
            }
        }
            public async Task<User> PutUserAsync(User user)
        {
            string uri = "https://localhost:8080/users/" + user.id;
            string jsonString;
            jsonString = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(jsonString);
            var streamTask = client.PutAsync(uri, content);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            if (result.Equals("fail"))
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<User>(result);
            }
        }

        [Authorize(Policy = "MustBeUser")]
        public async Task<string> DeleteItem(int id)
        {
            string uri = "https://localhost:8080/items/" + id;
            var streamTask = client.DeleteAsync(uri);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            if (result.Equals("true"))
            {
                items = await RequestAllItemsAsync();
                return "Success";
            }
            else
            {
                return "Fail";
            }
        }

        public async Task<string> DeleteUser(int id)
        {
            string uri = "https://localhost:8080/users/" + id;
            var streamTask = client.DeleteAsync(uri);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            return result;
        }

        public async Task<string> GetUserAsync(int id)
        {
            string uri = "https://localhost:8080/users/" + id;
            var streamTask = client.GetAsync(uri);
            string result = await streamTask.Result.Content.ReadAsStringAsync();
            return result;

        }

    }
}
