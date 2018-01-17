using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDS.DAO
{
    public class TuVanPCDAO
    {
        public static List<string> GetDeXuatAMDByGia(decimal gia, bool haveVGA, bool haveSSD)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            List<string> result = new List<string>();

            var currentGia = gia / 2;
            //cpu
            var q1 = from c in db.CPUs
                     where c.DonGia <= currentGia && c.TenHangSXCPU == "AMD"
                     orderby c.DonGia descending
                     select c;
            var cpu = q1.FirstOrDefault();
            if (cpu == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("CPU : " + cpu.Ten + "      " + cpu.DonGia);

            currentGia = gia - cpu.DonGia.Value;
            gia = currentGia;
            currentGia /= 2;
            //mainboard
            var q2 = from main in db.MAINBOARDs
                     where main.TenHangSXCPU == "AMD" && main.TenSocket == cpu.TenSocket && main.DonGia <= currentGia
                     orderby main.DonGia descending
                     select main;
            var mainboard = q2.FirstOrDefault();
            if (mainboard == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("MAINBOARD: " + mainboard.Ten + "      " + mainboard.DonGia.ToString());

            currentGia = gia - mainboard.DonGia.Value;
            gia = currentGia;
            currentGia /= 2;
            //hdd
            var q3 = from hdd in db.HARDDISKs
                     where hdd.DonGia <= currentGia && hdd.Interface != "M2"
                     orderby hdd.DonGia descending
                     select hdd;
            var harddisk = q3.FirstOrDefault();
            if (harddisk == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("HDD : " + harddisk.Ten + "   " + harddisk.TenSize.ToString() + "   " + harddisk.DonGia.ToString());

            if (mainboard.SupportM2.Value)
            {
                q3 = from hdd in db.HARDDISKs
                     where hdd.DonGia <= currentGia
                     orderby hdd.DonGia descending
                     select hdd;
                harddisk = q3.FirstOrDefault();
                result.RemoveAt(result.Count - 1);
                result.Add("HDD : " + harddisk.Ten + "   " + harddisk.TenSize + "   " + harddisk.DonGia.ToString());
            }

            currentGia = gia - harddisk.DonGia.Value;
            gia = currentGia;
            currentGia /= 2;
            //vga
            if (haveVGA)
            {
                var q4 = from v in db.VGAs
                         where v.DonGia <= currentGia
                         orderby v.DonGia ascending
                         select v;
                var vga = q4.FirstOrDefault();
                currentGia -= vga.DonGia.Value;
                currentGia /= 2;
                result.Add(vga.Ten);
            }

            //ram
            var q5 = from r in db.RAMs
                     where r.TenLoaiRam == mainboard.TenLoaiRam && r.DonGia <= currentGia
                     orderby r.DonGia descending
                     select r;
            var ram = q5.FirstOrDefault();
            if (ram == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("RAM : " + ram.Ten + "   " + ram.Size.ToString() + "   " + ram.DonGia.ToString());

            currentGia = gia - ram.DonGia.Value;
            //psu
            var q6 = from p in db.PSUs
                     where p.DonGia <= currentGia
                     orderby p.DonGia descending
                     select p;
            var psu = q6.FirstOrDefault();
            if (psu == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("PSU : " + psu.Ten + "   " + psu.Power.ToString() + "   " + psu.DonGia.ToString());

            var sum = cpu.DonGia + mainboard.DonGia + ram.DonGia + psu.DonGia + harddisk.DonGia;
            result.Add("");
            result.Add("");
            result.Add("");
            result.Add("            Tổng trị giá: " + sum.ToString() + "VNĐ");

            return result;
        }

        public static List<string> GetDeXuatIntelByGia(decimal gia, bool haveVGA, bool haveSSD)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            List<string> result = new List<string>();

            var currentGia = gia / 2;
            //cpu
            var q1 = from c in db.CPUs
                     where c.DonGia <= currentGia && c.TenHangSXCPU == "Intel"
                     orderby c.DonGia descending
                     select c;
            var cpu = q1.FirstOrDefault();
            if (cpu == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("CPU : " + cpu.Ten + "      " + cpu.DonGia);

            currentGia = gia - cpu.DonGia.Value;
            gia = currentGia;
            currentGia /= 2;
            //mainboard
            var q2 = from main in db.MAINBOARDs
                     where main.TenHangSXCPU == "Intel" && main.TenSocket == cpu.TenSocket && main.DonGia <= currentGia
                     orderby main.DonGia descending
                     select main;
            var mainboard = q2.FirstOrDefault();
            if (mainboard == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("MAINBOARD: " + mainboard.Ten + "      " + mainboard.DonGia.ToString());

            currentGia = gia - mainboard.DonGia.Value;
            gia = currentGia;
            currentGia /= 2;
            //hdd
            var q3 = from hdd in db.HARDDISKs
                     where hdd.DonGia <= currentGia && hdd.Interface != "M2"
                     orderby hdd.DonGia descending
                     select hdd;
            var harddisk = q3.FirstOrDefault();
            if (harddisk == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("HDD : " + harddisk.Ten + "   " + harddisk.TenSize.ToString() + "   " + harddisk.DonGia.ToString());

            if (mainboard.SupportM2.Value)
            {
                q3 = from hdd in db.HARDDISKs
                     where hdd.DonGia <= currentGia
                     orderby hdd.DonGia descending
                     select hdd;
                harddisk = q3.FirstOrDefault();
                result.RemoveAt(result.Count - 1);
                result.Add("HDD : " + harddisk.Ten + "   " + harddisk.TenSize + "   " + harddisk.DonGia.ToString());
            }

            currentGia = gia - harddisk.DonGia.Value;
            gia = currentGia;
            currentGia /= 2;
            //vga
            if (haveVGA)
            {
                var q4 = from v in db.VGAs
                         where v.DonGia <= currentGia
                         orderby v.DonGia ascending
                         select v;
                var vga = q4.FirstOrDefault();
                currentGia -= vga.DonGia.Value;
                currentGia /= 2;
                result.Add(vga.Ten);
            }

            //ram
            var q5 = from r in db.RAMs
                     where r.TenLoaiRam == mainboard.TenLoaiRam && r.DonGia <= currentGia
                     orderby r.DonGia descending
                     select r;
            var ram = q5.FirstOrDefault();
            if (ram == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("RAM : " + ram.Ten + "   " + ram.Size.ToString() + "   " + ram.DonGia.ToString());

            currentGia = gia - ram.DonGia.Value;
            //psu
            var q6 = from p in db.PSUs
                     where p.DonGia <= currentGia
                     orderby p.DonGia descending
                     select p;
            var psu = q6.FirstOrDefault();
            if (psu == null)
            {
                result.Clear();
                result.Add("Lỗi ! không có đề xuất cho yêu cầu này");
                return result;
            }
            result.Add("PSU : " + psu.Ten + "   " + psu.Power.ToString() + "   " + psu.DonGia.ToString());

            var sum = cpu.DonGia + mainboard.DonGia + ram.DonGia + psu.DonGia + harddisk.DonGia;
            result.Add("");
            result.Add("");
            result.Add("");
            result.Add("            Tổng trị giá: " + sum.ToString() + "VNĐ");

            return result;
        }
    }
}
