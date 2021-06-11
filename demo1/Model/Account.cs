using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace demo1.Model
{
    public class Account
    {
        [Key]
        public int Account_ID { get; set; }
        [Required]
        public string Account_Username { get; set; }
        [Required]
        public string Account_Password { get; set; }
        [Required]
        [Column("Phone")]
        [StringLength(10)]
        public string Account_Phone { get; set; }
        [Required]
        [Column("Email")]
        [StringLength(50)]
        public string Account_Email { get; set; }
    }
}
