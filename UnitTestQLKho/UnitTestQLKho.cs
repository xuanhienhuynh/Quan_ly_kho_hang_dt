using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhoHang;
using System.Data;
using System.Data.SqlClient;
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
        }

        [TestMethod]
        public void TestLogin()
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
        public void Test_Nguoi_Dung_Da_Nhap_Chua()
        {

        }
    }
}
