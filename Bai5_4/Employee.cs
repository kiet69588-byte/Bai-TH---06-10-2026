namespace Bai5_4
{
    public class Employee
    {
        public string MaNV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string ChucVu { get; set; } = "";
        public string NgayVaoLam { get; set; } = "";
        public string PhongBan { get; set; } = "";
        public string Nhom { get; set; } = "";

        public Employee(
            string maNV,
            string hoTen,
            string chucVu,
            string ngayVaoLam,
            string phongBan,
            string nhom)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
            PhongBan = phongBan;
            Nhom = nhom;
        }
    }
}