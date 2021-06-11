using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace demo1.Model
{
    class CreateDB : CreateDatabaseIfNotExists<AppDBContext>
    {
        protected override void Seed(AppDBContext context)
        {
            base.Seed(context);
            //new LSH { ID_Lop = 4, TenLop = "19TCLC_DT4"},
            //new LSH { ID_Lop = 5, TenLop = "19TCLC_DT5"},
            //new LSH { ID_Lop = 6, TenLop = "19TCLC_DT6"}
            context.LSHes.AddRange(new LSH[]
            {
                new LSH { ID_Lop = 1, TenLop = "19TCLC_DT1"},
                new LSH { ID_Lop = 2, TenLop = "19TCLC_DT2"},
                new LSH { ID_Lop = 3, TenLop = "19TCLC_DT3"}
            });
            context.SVs.AddRange(new SV[]
            {
                new SV { MSSV = "101", TenSV = "Nguyen Van A", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = true, ID_Lop = 1},
                new SV { MSSV = "102", TenSV = "Nguyen Van B", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = false, ID_Lop = 1},
                new SV { MSSV = "103", TenSV = "Nguyen Van C", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = true, ID_Lop = 1},
                new SV { MSSV = "104", TenSV = "Nguyen Van D", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = false, ID_Lop = 2},
                new SV { MSSV = "105", TenSV = "Nguyen Van E", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = true, ID_Lop = 2},
                new SV { MSSV = "106", TenSV = "Nguyen Van F", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = false, ID_Lop = 2},
                new SV { MSSV = "107", TenSV = "Nguyen Van G", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = true, ID_Lop = 3},
                new SV { MSSV = "108", TenSV = "Nguyen Van H", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = false, ID_Lop = 3},
                new SV { MSSV = "109", TenSV = "Nguyen Van K", NgaySinh = DateTime.Now.AddDays(-7665), GioiTinh = true, ID_Lop = 3},
            });
            context.Accounts.AddRange(new Account[]
            {
                new Account { Account_Username = "NVA", Account_Password = "1", Account_Phone = "0xxx xxx xxx", Account_Email = "NVA@gmail.com"},
                new Account { Account_Username = "NVB", Account_Password = "1", Account_Phone = "0xxx xxx xxx", Account_Email = "NVB@gmail.com"}
            });
            context.Subjects.AddRange(new Subject[]
            {
                new Subject { MaMonHoc = ".NET", SoTinChi = 4, MoTa = ""},
                new Subject { MaMonHoc = "Java", SoTinChi = 3, MoTa = ""},
                new Subject { MaMonHoc = "Python", SoTinChi = 2, MoTa = ""},
            });
            context.Registers.AddRange(new Register[]
            {
                new Register { ID_Register = 1, MaMonHoc = ".NET", MSSV = "101"},
                new Register { ID_Register = 2, MaMonHoc = "Java", MSSV = "102"},
            });
        }
    }
}
