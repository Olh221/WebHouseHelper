using System.ComponentModel.DataAnnotations.Schema;

namespace WebHouseHelper.Data
{
    public class MyOrders
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("MyServicesId")]
        public MyServices MyServices { get; set; }
        public int MyServicesId { get; set; }

        public DateTime DateOrdered { get; set; }
        public string Feedback { get; set; }

        public string AverageUserId { get; set; }
    }
}
