using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WIlliGram.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Friends Since")]
        
        [DataType(DataType.Date)]
        
        public DateTime FriendsSince { get; set; }
        public string Job { get; set; }
        public string Portrait { get; set; }
    }
}
