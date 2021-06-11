using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace demo1.Model
{
    public class Register
    {
        [Key]
        public int ID_Register { get; set; }
        public string MaMonHoc { get; set; }
        public string MSSV { get; set; }
        [ForeignKey("MaMonHoc")]
        public virtual Subject Subject { get; set; }
        [ForeignKey("MSSV")]
        public virtual SV SV { get; set; }
    }
}



