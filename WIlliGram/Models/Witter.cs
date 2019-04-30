using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WIlliGram.Models
{
    public class Witter
    {
        public int Id { get; set; }
        public string Blah { get; set; }

        //[DataType(DataType.Date)]
        [Display(Name = "Date of Blah")]
        public DateTime WroteDate {
            get; set;
        }
         
        public int Likes { get; set; }

    }
}
