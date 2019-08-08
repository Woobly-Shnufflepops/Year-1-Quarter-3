using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using John.SocialClub.Desktop;
using John.SocialClub.Desktop.Properties;

namespace John.SocialClub.DesktopTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool isvalid = Login.validateLogin(Settings.Default.Username, Settings.Default.Password);
            
            Assert.IsTrue(isvalid);
        }
    }
}
