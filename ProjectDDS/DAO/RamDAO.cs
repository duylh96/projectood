using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDS.DAO
{
    public class RamDAO
    {
        public static dynamic getListRamByLapTopId(string id)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();

            var lt = db.LAPTOPs.Single(p => p.Ten == id);

            var query = db.RAMs.Where(p => p.TenLoaiRam == lt.TenLoaiRam && p.TenXungNhip == lt.TenXungNhip && p.ForLapTop == true);

            return query.ToList();
        }

        public static dynamic getListHDByLapTopId(string id)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();

            var lt = db.LAPTOPs.Single(p => p.Ten == id);

            var query1 = db.HARDDISKs.Where(p => p.TenLoaiHD == "2.5" && p.Interface != "M2");
            var query2 = db.HARDDISKs.Where(p => p.Interface == "M2");

            if (lt.supportM2.Value)
                return query1.Concat(query2).ToList();

            return query1.ToList();
        }
    }
}
