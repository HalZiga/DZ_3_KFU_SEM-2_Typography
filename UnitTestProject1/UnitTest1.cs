using DZ_3_KFU_SEM_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1ForRull9_1()
        {
            string given = "штаны +- за 40 гривен";
            string expected = "штаны ± за 40 гривен";

            FormTypography form = new FormTypography();

            string result = form.Rull9(given);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod1ForRull9_2()
        {
            string given = "штаны -+ за 40 гривен";
            string expected = "штаны ± за 40 гривен";

            FormTypography form = new FormTypography();

            string result = form.Rull9(given);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod1ForRull13()
        {
            string given = "допка ...";
            string expected = "допка …";

            FormTypography form = new FormTypography();

            string result = form.Rull13(given);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod1ForRull2Exception()
        {
            string given1 = "Отрицательный Взлёт";
            string given2 = "";

            FormTypography form = new FormTypography();

            form.Rull2(given1,given2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1ForRull1Exception()
        {
            string given1 = "татар";
            string given2 = "";

            FormTypography form = new FormTypography();

            form.Rull1(given1,given2);
        }

        [TestMethod]
        public void TestMethod1ForRull2()
        {
            string given1 = "Отрицательный Взлёт";
            string given2 = "https://www.youtube.com/shorts/D7yxniEUh8U";

            FormTypography form = new FormTypography();

            form.Rull2(given1, given2);
        }

        [TestMethod]
        public void TestMethod1ForRull1()
        {
            string given1 = "татар";
            string given2 = @"..\..\..\sandugach.wav";

            FormTypography form = new FormTypography();

            form.Rull1(given1, given2);
        }

        [TestMethod]
        public void TestMethod1ForRull3()
        {
            string given = "хахахахахахахаха";
            string expected = "хохохохохохохохохохохохохохохохохохохохо";

            FormTypography form = new FormTypography();

            string result = form.Rull3(given);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod1ForRull5_1()
        {
            string given = "минусов - нет";
            string expected = "минусов-нет";

            FormTypography form = new FormTypography();

            string result = form.Rull5(given);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod1ForRull5_2()
        {
            string given = "минусов- нет";
            string expected = "минусов-нет";

            FormTypography form = new FormTypography();

            string result = form.Rull5(given);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod1ForRull5_3()
        {
            string given = "минусов -нет";
            string expected = "минусов-нет";

            FormTypography form = new FormTypography();

            string result = form.Rull5(given);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod1ForRull14_1()
        {
            string given = "В.В.Ненада";
            string expected = "В. В. Ненада";

            FormTypography form = new FormTypography();

            string result = form.Rull14(given);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod1ForRull14_2()
        {
            string given = "В. В.Ненада";
            string expected = "В. В. Ненада";

            FormTypography form = new FormTypography();

            string result = form.Rull14(given);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod1ForRull14_3()
        {
            string given = "В.В. Ненада";
            string expected = "В. В. Ненада";

            FormTypography form = new FormTypography();

            string result = form.Rull14(given);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod1ForRull14_4()
        {
            string given = "любил и т.д.";
            string expected = "любил и т. д.";

            FormTypography form = new FormTypography();

            string result = form.Rull14(given);

            Assert.AreEqual(expected, result);
        }
    }
}
