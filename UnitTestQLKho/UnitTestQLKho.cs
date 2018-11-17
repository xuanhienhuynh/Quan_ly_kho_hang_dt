using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhoHang;

namespace UnitTestQLKho
{
    [TestClass]
    public class UnitTestQLKho
    {
        private DangNhap Dn;
        private QLKhoHang cn;
        private DataSet ds;
        [TestInitialize] //phương thức thực thi trước khi chạy các test case.
        public void setUp()
        {
            Dn = new DangNhap();
            ds = cn.GetData();

        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
