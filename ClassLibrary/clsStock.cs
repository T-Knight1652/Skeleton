using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public string productName { get; set; }
        public string supplierName { get; set; }
        public bool inStock { get; set; }
        public int quantityAvailable { get; set; }
        public DateTime lastDelivery { get; set; }
    }
}