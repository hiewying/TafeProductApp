using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery = 25m;
        private decimal wrapping = 5m;
        private decimal gst;

        private decimal totalCharge;
        private decimal totalWrap;
        

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }
        
        //additional
        public decimal TotalCharge
        {
            get{return totalCharge;}
            set { totalCharge = value; }
        }

        public decimal TotalWrap
        {
            get { return totalWrap; }
            set { totalWrap = value; }
        }
        

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        public void calTotalCharge()
        {
            TotalCharge = TotalPayment + Delivery;
        }

        public void calTotalWrap()
        {
            TotalWrap = TotalPayment + Delivery + Wrapping;
        }
    }
}
