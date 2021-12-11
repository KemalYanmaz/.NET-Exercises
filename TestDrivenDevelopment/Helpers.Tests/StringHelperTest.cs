using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void Girilen_Ifadedenin_Basindaki_Ve_Sonundaki_Bosluklar_Silinmelidir()
        {
            //Arrange
            var Ifade = "  Kemal Yanmaz  ";
            var Beklenen = "Kemal Yanmaz";

            //Act
            string Gerceklesen = StringHelper.FazlaBosluklariSil(Ifade);

            //Assert
            Assert.AreEqual(Beklenen, Gerceklesen);
        }
        [TestMethod]
        public void Girilen_Ifadedenin_Icindeki_Fazla_Bosluklar_Silinmelidir()
        {
            //Arrange
            var Ifade = "Merhaba     Ben    Kemal     Yanmaz";
            var Beklenen = "Merhaba Ben Kemal Yanmaz";

            //Act
            string Gerceklesen = StringHelper.FazlaBosluklariSil(Ifade);

            //Assert
            Assert.AreEqual(Beklenen, Gerceklesen);
        }
    }
}
