using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhoHang;
using DAO;
using DTO;
using BUS;


namespace UnitTestQLKho
{
    /// <summary>
    /// Summary description for UnitTestLayHang
    /// </summary>
    [TestClass]
    public class UnitTestLayHang
    {
        private DataProvider daPro;
        private CatHangDAO CHD;

        [TestInitialize] //phương thức thực thi trước khi chạy các test case.
        public void setUp()
        {
            daPro = new DataProvider();
            CHD = new CatHangDAO();
        }

        /// <summary>
        /// Test Lấy Hàng
        /// </summary>
        [TestMethod]
        public void TestLayHang()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(0, a);
        }






        /// <summary>
        /// Thiếu 1 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuTenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuNgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuNguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test thiếu 2 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMake_TenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuMaKe_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuMaKe_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuNgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test Thiếu 3 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test thiếu 4 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test thiếu 5 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe__TenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// Test Rỗng 
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }
    }
}
