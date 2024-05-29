using System.ComponentModel.DataAnnotations;

namespace RaythosAircraft.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string ContactNo { get; set; }

        public string AgreementStatus { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Status { get; set; }

        public double Total {  get; set; }


        //Foreign Keys
        public string ProductCode { get; set; }

        public string ItemCode { get; set; }
    }
}
