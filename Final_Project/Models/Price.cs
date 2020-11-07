using System;
using System.ComponentModel.DataAnnotations;
namespace Final_Project.Models
{
    public class Price
    {
        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 WeekdayPrice { get; set; } // $10

        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 TuesdayPrice { get; set; } //$8

        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 SeniorPrice { get; set; } // minus $2 from price

        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 MatineePrice { get; set; } // $5

        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 WeekendPrice { get; set; } //$12

        [Display(Name = "Movie Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 SpecialEventPrice { get; set; } // no discounts

        public Price()
        {
        }
    }
}
