using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace demo1.Model
{
    public class SV
    {
        [Key]
        public string MSSV { get; set; }
        [Required]
        public string TenSV { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public int ID_Lop { get; set; }
        [ForeignKey("ID_Lop")]
        public virtual LSH LSH { get; set; }
    }
}
