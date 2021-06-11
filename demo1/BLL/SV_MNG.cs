using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using demo1.Model;
using demo1.ViewModel;
namespace demo1.BLL
{
    public class SV_MNG
    {
        public delegate bool Compare(object o1, object o2);
        private AppDBContext AppDBContext;
        private static SV_MNG _Instance;
        public static SV_MNG Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SV_MNG();
                }
                return _Instance;
            }
            private set { }
        }
        private SV_MNG()
        {
            AppDBContext = new AppDBContext();
        }
        /***** LSH *****/
        public List<LSH> GetAllLSH()
        {
            return AppDBContext.LSHes.AsNoTracking().ToList();
        }
        public LSH GetLSHByID(int idlop)
        {
            return AppDBContext.LSHes.Find(idlop);
        }
        public List<CbbItem> AddCbbLSH()
        {
            List<LSH> lSHes = GetAllLSH();
            List<CbbItem> cbbItems = new List<CbbItem>();
            for (int i = 0; i < lSHes.Count; i++)
            {
                CbbItem cbbItem = new CbbItem();
                cbbItem.Value = lSHes[i].ID_Lop;
                cbbItem.Text = lSHes[i].TenLop;
                cbbItems.Add(cbbItem);
            }
            return cbbItems;
        }
        /***** SV *****/
        public List<SVViewModel> GetAllSV(int idlop, string name)
        {
            List<SVViewModel> sVViewModels = new List<SVViewModel>();
            if (idlop == 0)
            {
                foreach (SV sV in AppDBContext.SVs.AsNoTracking().ToList())
                {
                    LSH lSH = GetLSHByID(sV.ID_Lop);
                    SVViewModel sVViewModel = new SVViewModel
                    {
                        MSSV = sV.MSSV,
                        HoTenSV = sV.TenSV,
                        GioiTinh = sV.GioiTinh,
                        NgaySinh = sV.NgaySinh,
                        TenLop = lSH.TenLop
                    };
                    sVViewModels.Add(sVViewModel);
                }
            }   
            else
            {
                foreach (SV sV in AppDBContext.SVs.AsNoTracking().ToList())
                {
                    if (sV.ID_Lop == idlop)
                    {
                        LSH lSH = GetLSHByID(sV.ID_Lop);
                        SVViewModel sVViewModel = new SVViewModel
                        {
                            MSSV = sV.MSSV,
                            HoTenSV = sV.TenSV,
                            GioiTinh = sV.GioiTinh,
                            NgaySinh = sV.NgaySinh,
                            TenLop = lSH.TenLop
                        };
                        sVViewModels.Add(sVViewModel);
                    }   
                }
            }    
            return sVViewModels;
        }
        public SVViewModel GetSVByID(string mssv)
        {
            SV sV = AppDBContext.SVs.Find(mssv);
            LSH lSH = GetLSHByID(sV.ID_Lop);
            SVViewModel sVViewModel = new SVViewModel
            {
                MSSV = sV.MSSV,
                HoTenSV = sV.TenSV,
                GioiTinh = sV.GioiTinh,
                NgaySinh = sV.NgaySinh,
                TenLop = lSH.TenLop
            };
            return sVViewModel;
        }
        public bool AddSV(SVViewModel sVViewModel)
        {
            List<LSH> lSHes = this.GetAllLSH();
            SV sV = new SV
            {
                MSSV = sVViewModel.MSSV,
                TenSV = sVViewModel.HoTenSV,
                GioiTinh = sVViewModel.GioiTinh,
                NgaySinh = sVViewModel.NgaySinh
            };
            foreach (LSH lSH in lSHes)
            {
                if (lSH.TenLop == sVViewModel.TenLop)
                {
                    sV.ID_Lop = lSH.ID_Lop;
                    break;
                }    
            }
            bool success = true;
            try
            {
                AppDBContext.SVs.Add(sV);
                AppDBContext.SaveChanges();
            }
            catch (Exception e)
            {
                success = false;
            }
            return success;
        }
        public bool EditSV(SVViewModel sVViewModel)
        {
            List<LSH> lSHes = this.GetAllLSH();
            SV sV = AppDBContext.SVs.Find(sVViewModel.MSSV);
            sV.TenSV = sVViewModel.HoTenSV;
            sV.GioiTinh = sVViewModel.GioiTinh;
            sV.NgaySinh = sVViewModel.NgaySinh;
            foreach (LSH lSH in lSHes)
            {
                if (lSH.TenLop == sVViewModel.TenLop)
                {
                    sV.ID_Lop = lSH.ID_Lop;
                    break;
                }    
            }
            bool succeed = true; 
            try
            {
                AppDBContext.Entry(sV).State = EntityState.Modified;
                AppDBContext.SaveChanges();
            }
            catch (Exception e)
            {
                succeed = false;
            }
            return succeed;
        }
        public bool DeleteSV(List<string> ListMSSV)
        {
            bool succeed = true;
            try
            {
                foreach (string val in ListMSSV)
                {
                    SV sV = AppDBContext.SVs.Find(val);
                    AppDBContext.SVs.Remove(sV);
                    AppDBContext.SaveChanges();
                    AppDBContext.Entry(sV).State = EntityState.Detached;
                }    
            }
            catch (Exception e)
            {
                succeed = false;
            }
            return succeed;
        }
        public List<SVViewModel> Sort(int idlop, string name, Compare cmp)
        {
            List<SVViewModel> sVs = GetAllSV(idlop,name);
            int index;
            for (int i = 0; i < sVs.Count - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < sVs.Count; j++)
                {
                    if (cmp(sVs[index],sVs[j]))
                    {
                        index = j;
                    }    
                }
                SVViewModel sVViewModel = sVs[i];
                sVs[i] = sVs[index];
                sVs[index] = sVViewModel;
            }
            return sVs;
        }
    }
}
