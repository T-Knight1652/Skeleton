using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public DateTime NextDelivery { get; set; }
        public string BrandName { get; set; }
        public double Total { get; set; }
        public int Quantity { get; set; }
    }
}