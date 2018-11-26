using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhoHang;
using DAO;
using DTO;
using BUS;

namespace UnitTestQLKho
{
    [TestClass]
    public class UnitTestQLKho
    {
        private DataProvider daPro;
        private NhapHangDAO NHD;
        private CatHangDAO CHD;
        private LayHangDAO LHD;

        [TestInitialize] //phương thức thực thi trước khi chạy các test case.
        public void setUp()
        {
            daPro = new DataProvider();
            NHD = new NhapHangDAO();
            CHD = new CatHangDAO();
            LHD = new LayHangDAO();
        }

        /// <summary>
        /// TestDangNhap
        /// </summary>
        [TestMethod]
        public void TestDangNhap()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "admin";
            string pass = "admin";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestDangNhap_Thieu_User()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "";
            string pass = "admin";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreNotEqual(true, b);
        }

        [TestMethod]
        public void TestDangNhap_Thieu_Pass()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "admin";
            string pass = "";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreNotEqual(true, b);
        }

        [TestMethod]
        public void TestDangNhap_Rong()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "";
            string pass = "";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreEqual(false, b);
        }

        






























        


        
    }
}
