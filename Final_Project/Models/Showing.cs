using System;
using System.ComponentModel.DataAnnotations;
namespace Final_Project.Models
{
    public class Showing
    {

        public Int32 ShowingID { get; set; }

        [Display(Name = "Theather Room")]
        [Range(1, 2, ErrorMessage = "Theather Room must be between 1 and 2")]
        public Int32 TheatherRoom { get; set; }

        [Display(Name = "Start Time")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EndTime { get; set; }

        public Int32 MovieID { get; set; }

        public Showing()
        {
        }
    }
}
