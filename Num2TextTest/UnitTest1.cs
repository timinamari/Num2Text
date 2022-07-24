namespace Num2TextTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodConvert1()
        {
            //
            Assert.AreEqual("����", new Num2Text.Num2Text().Convert(0));
        }

        [TestMethod]
        public void TestMethodConvert2()
        {
            //
            Assert.AreEqual("������", new Num2Text.Num2Text().Convert(10));
        }

        [TestMethod]
        public void TestMethodConvert3()
        {
            //
            Assert.AreEqual("��� �����������", new Num2Text.Num2Text().Convert(111));
        }

        [TestMethod]
        public void TestMethodConvert4()
        {
            //
            Assert.AreEqual("���� ������ �����������", new Num2Text.Num2Text().Convert(1011));
        }


        [TestMethod]
        public void TestMethodConvert6()
        {
            //
            Assert.AreEqual("�������� ����", new Num2Text.Num2Text().Convert(25));
        }

        [TestMethod]
        public void TestMethodConvert7()
        {
            //
            Assert.AreEqual("��������� ������", new Num2Text.Num2Text().Convert(99));
        }

        [TestMethod]
        public void TestMethodConvert8()
        {
            //
            Assert.AreEqual("����� ����", new Num2Text.Num2Text().Convert(41));
        }

        [TestMethod]
        public void TestMethodConvert9()
        {
            //
            Assert.AreEqual("����������� �����", new Num2Text.Num2Text().Convert(86));
        }

        [TestMethod]
        public void TestMethodConvert10()
        {
            //
            Assert.AreEqual("�����������", new Num2Text.Num2Text().Convert(11));
        }

        [TestMethod]
        public void TestMethodConvert11()
        {
            //
            Assert.AreEqual("����", new Num2Text.Num2Text().Convert(5));
        }

        [TestMethod]
        public void TestMethodConvert12()
        {
            //
            Assert.AreEqual("��������", new Num2Text.Num2Text().Convert(20));
        }

        [TestMethod]
        public void TestMethodConvert13()
        {
            //
            Assert.AreEqual("��������", new Num2Text.Num2Text().Convert(30));
        }

        [TestMethod]
        public void TestMethodConvert14()
        {
            //
            Assert.AreEqual("�������� ����", new Num2Text.Num2Text().Convert(37));
        }
    }
}
}