using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.ViewModel
{
    public class SVViewModel
    {
        public string MSSV { get; set; }
        public string HoTenSV { get; set; }
        public string TenLop { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public static bool Compare_MSSV(object o1, object o2)
        {
            if (string.Compare(((SVViewModel)o1).MSSV,((SVViewModel)o2).MSSV) > 0) { return true; }
            return false;
        }
        public static bool Compare_HoTenSV(object o1, object o2)
        {
            if (string.Compare(((SVViewModel)o1).HoTenSV, ((SVViewModel)o2).HoTenSV) > 0) { return true; }
            return false;
        }
        public static bool Compare_TenLop(object o1, object o2)
        {
            if (string.Compare(((SVViewModel)o1).TenLop, ((SVViewModel)o2).TenLop) > 0) { return true; }
            return false;
        }
        public static bool Compare_GioiTinh(object o1, object o2)
        {
            if (((SVViewModel)o1).GioiTinh == false && ((SVViewModel)o2).GioiTinh == true) { return true; }
            return false;
        }
        public static bool Compare_NgaySinh(object o1, object o2)
        {
            if (DateTime.Compare(((SVViewModel)o1).NgaySinh, ((SVViewModel)o2).NgaySinh) > 0) { return true; }
            return false;
        }
    }
}
