using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.DataBase
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
