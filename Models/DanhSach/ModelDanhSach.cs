namespace TranKhanhLinh.Models.DanhSach
{
    public class ModelDanhSach
    {
        public String TenSanPham {  get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public int TamTinh { get; set; }

        public int GiamGia { get; set; }

        public ModelDanhSach() { }

        public ModelDanhSach(string tenSanPham, int soLuong, int donGia, int giamGia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
            GiamGia = giamGia;
            TamTinh = soLuong * donGia;
        }
    }
}
