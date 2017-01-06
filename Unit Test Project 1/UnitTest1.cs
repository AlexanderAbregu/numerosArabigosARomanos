using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace NumberSystemConverter_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumeroMasGrandeQue3Mil()
        {
            var converter = new ConvertirANumeroRomano();
            converter.PasarANumueroRomano(4000);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumeroMasChicoQue3Mil()
        {
            var converter = new ConvertirANumeroRomano();
            converter.PasarANumueroRomano(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumeroNoPuedeSerCero()
        {
            var converter = new ConvertirANumeroRomano();
            converter.PasarANumueroRomano(0);
        }

        [TestMethod]
        public void EsperabaQueSea_01_Uno()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1);

            Assert.AreEqual(resultado, "I");
        }

        [TestMethod]
        public void EsperabaQueSea_02_Cinco()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(5);

            Assert.AreEqual(resultado, "V");
        }

        [TestMethod]
        public void EsperabaQueSea_03_Diez()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(10);

            Assert.AreEqual(resultado, "X");
        }

        [TestMethod]
        public void EsperabaQueSea_04_Cincuenta()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(50);

            Assert.AreEqual(resultado, "L");
        }

        [TestMethod]
        public void EsperabaQueSea_05_Cien()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(100);

            Assert.AreEqual(resultado, "C");
        }

        [TestMethod]
        public void EsperabaQueSea_06_Quinientos()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(500);

            Assert.AreEqual(resultado, "D");
        }
        
        [TestMethod]
        public void EsperabaQueSea_07_Mil()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1000);

            Assert.AreEqual(resultado, "M");
        }

        [TestMethod]
        public void EsperabaQueSea_08_DosMil()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(2000);

            Assert.AreEqual(resultado, "MM");
        }

        [TestMethod]
        public void EsperabaQueSea_09_TresMil()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(3000);

            Assert.AreEqual(resultado, "MMM");
        }

        [TestMethod]
        public void EsperabaQueSea_10_TresCientoCincuenta()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(350);

            Assert.AreEqual(resultado, "CCCL");
        }

        [TestMethod]
        public void EsperabaQueSea_11_SeteCientosCincuenta()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(750);

            Assert.AreEqual(resultado, "DCCL");
        }

        [TestMethod]
        public void EsperabaQueSea_12_DosMilSetecientosCincuenta()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(2750);

            Assert.AreEqual(resultado, "MMDCCL");
        }

        [TestMethod]
        public void EsperabaQueSea_13_Nueve()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(9);

            Assert.AreEqual(resultado, "IX");
        }

        [TestMethod]
        public void EsperabaQueSea_14_TreintaYOcho()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(38);

            Assert.AreEqual(resultado, "XXXVIII");
        }

        [TestMethod]
        public void EsperabaQueSea_15_MilQuinientosCincuenta()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1550);

            Assert.AreEqual(resultado, "MDL");
        }

        [TestMethod]
        public void EsperabaQueSea_16_MilQuinientosCincuentaYUno()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1551);

            Assert.AreEqual(resultado, "MDLI");
        }

        [TestMethod]
        public void EsperabaQueSea_17_MilQuinientosCincuentaYDos()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1552);

            Assert.AreEqual(resultado, "MDLII");
        }

        [TestMethod]
        public void EsperabaQueSea_18_MilQuinientosCincuentaYTres()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1553);

            Assert.AreEqual(resultado, "MDLIII");
        }

        [TestMethod]
        public void EsperabaQueSea_19_MilQuinientosCincuentaYCuatro()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1554);

            Assert.AreEqual(resultado, "MDLIV");
        }

        [TestMethod]
        public void EsperabaQueSea_20_MilQuinientosCincuentaYCinco()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1555);

            Assert.AreEqual(resultado, "MDLV");
        }

        [TestMethod]
        public void EsperabaQueSea_21_MilQuinientosCincuentaYSeis()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1556);

            Assert.AreEqual(resultado, "MDLVI");
        }

        [TestMethod]
        public void EsperabaQueSea_22_MilQuinientosCincuentaYSiete()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1557);

            Assert.AreEqual(resultado, "MDLVII");
        }

        [TestMethod]
        public void EsperabaQueSea_23_MilQuinientosCincuentaYOcho()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1558);

            Assert.AreEqual(resultado, "MDLVIII");
        }

        [TestMethod]
        public void EsperabaQueSea_24_MilQuinientosCincuentaYNueve()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1559);

            Assert.AreEqual(resultado, "MDLIX");
        }

        [TestMethod]
        public void EsperabaQueSea_25_MilQuinientosSesenta()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1560);

            Assert.AreEqual(resultado, "MDLX");
        }
        
        [TestMethod]
        public void EsperabaQueSea_26_Cuatrocientos()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(400);

            Assert.AreEqual(resultado, "CD");
        }

        [TestMethod]
        public void EsperabaQueSea_27_Novecientos()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(900);

            Assert.AreEqual(resultado, "CM");
        }

        [TestMethod]
        public void EsperabaQueSea_28_CuarentaYNueve()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(49);

            Assert.AreEqual(resultado, "XLIX");
        }

        [TestMethod]
        public void EsperabaQueSea_29_DieciNueve()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(19);

            Assert.AreEqual(resultado, "XIX");
        }

        [TestMethod]
        public void EsperabaQueSea_30_TreintaYNueve()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(39);

            Assert.AreEqual(resultado, "XXXIX");
        }

        [TestMethod]
        public void EsperabaQueSea_31_NoventaYCuatro()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(94);

            Assert.AreEqual(resultado, "XCIV");
        }

        [TestMethod]
        public void EsperabaQueSea_32_MilCuarenta()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1040);

            Assert.AreEqual(resultado, "MXL");
        }

        [TestMethod]
        public void EsperabaQueSea_33_MilCuatrocientos()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1400);

            Assert.AreEqual(resultado, "MCD");
        }

        [TestMethod]
        public void EsperabaQueSea_34_MilNoventa()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1090);

            Assert.AreEqual(resultado, "MXC");
        }

        [TestMethod]
        public void EsperabaQueSea_35_MilNovecientos()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1900);

            Assert.AreEqual(resultado, "MCM");
        }

        [TestMethod]
        public void EsperabaQueSea_36_MilCuatrocientosNoventa()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1490);

            Assert.AreEqual(resultado, "MCDXC");
        }

        [TestMethod]
        public void EsperabaQueSea_37_MilCuatrocientosNoventaYCuatro()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(1494);

            Assert.AreEqual(resultado, "MCDXCIV");
        }

        [TestMethod]
        public void EsperabaQueSea_38_TresMilNovecientosNoventaYNueve()
        {
            var converter = new ConvertirANumeroRomano();
            var resultado = converter.PasarANumueroRomano(3999);

            Assert.AreEqual(resultado, "MMMCMXCIX");
        }
    }
}