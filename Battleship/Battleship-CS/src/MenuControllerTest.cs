using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestFixture()]
    public class MenuControllerTests
    {
        [Test()]
        public void PerformSetupMenuActionTest()
        {
            int button = 0;

            MenuController _testMethod = new MenuController();
            _testMethod.PerformSetupMenuAction(button);

            Assert.IsTrue(GameController._aiSetting == AIOption.Easy);
        }
    }
}