using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace demo1.Model
{
    public class LSH
    {
        public LSH()
        {
            SVs = new HashSet<SV>();
        }
        [Key]
        public int ID_Lop { get; set; }
        public string TenLop { get; set; }
        public virtual ICollection<SV> SVs { get; set; }
    }
}
