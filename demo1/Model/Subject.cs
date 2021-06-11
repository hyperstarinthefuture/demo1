using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace demo1.Model
{
    public class Subject
    {
        [Key]
        [StringLength(10)]
        public string MaMonHoc { get; set; }
        [Required]
        public int SoTinChi { get; set; }
        [StringLength(100)]
        public string MoTa { get; set; }
    }
}
