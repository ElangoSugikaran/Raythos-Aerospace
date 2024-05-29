﻿using System.ComponentModel.DataAnnotations;

namespace RaythosAircraft.Models
{
    public class ProductDetailViewModel
    {
        public Products Product { get; set; }

        public Order Order { get; set; }

        public IEnumerable<Products> RelatedProducts { get; set; }

        public List<Products> PurchaseOrder { get; set; } = new List<Products>();

        public double TotalPrice { get; set; }

        public int TotalDays { get; set; }


        // New properties for order summary
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

        public double Total { get; set; }

    }
}
