using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebApp.Model.Domain
{
    public class Order
    {
        public int id { get; set; }
        public int userid { get; set; }
        [Required]
        public string adress { get; set; }
        [Required]
        public string invoiceadress { get; set; }
        public float totalprice { get; set; }
        [Required]
        public int totalitems { get; set; }
        [Required]
        public int phone { get; set; }
        public Boolean delivered { get; set; }
        public IList<Item> items { get; set; }
        public int[] itemsCount { get; set; }



        public void calculatetotalprice()
        {
            totalitems = 0;
            for (int i = 0; i < items.Count; i++)
            {
                totalitems++;
                totalprice += items[i].price * itemsCount[i];
            }
        }
    }
}
