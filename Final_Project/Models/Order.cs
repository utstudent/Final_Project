using System;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Order
    {
        private const Decimal TAX_RATE = .0825m;

        //Order ID
        public Int32 OrderID { get; set; }

        //Order Number
        [Display(Name = "Order Number")]
        public Int32 OrderNumber { get; set; }

        //Order Date
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }

        //Order Notes
        [Display(Name = "Order Notes")]
        public String OrderNotes { get; set; }

        //without tax
        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return OrderDetails.Sum(od => od.ExtendedPrice); }
        }

        //Taxes
        [Display(Name = "Tax (8.25%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TaxFee
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        //Total
        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + TaxFee; }
        }

        //Navigational Properties
        
        public AppUser User { get; set; }
        public Order()
        {
        }
    }
}
