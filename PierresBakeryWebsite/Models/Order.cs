using System.Collections.Generic;

namespace PierresBakeryWebsite.Models
{
 public class Order
 {
   public string Description {get; set; }
   public int Price { get; set; }
   public string Date { get; set; }
   public int Id { get; }

   private List<Order> _instances = new List<Order> {};
 } 
}