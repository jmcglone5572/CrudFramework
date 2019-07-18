using System;

namespace CrudFramework.ConsoleApp
{
    public class Order
    {
        public Guid OrderNumber { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFirstName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
