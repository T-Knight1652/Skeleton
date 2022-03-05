using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        

        public string Comments { get; set; }
        public int OrderID { get; set; }
        public bool Dispatch { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
    }
}