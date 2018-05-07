using System;
using System.Threading.Tasks;
using ChickenAPI.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChickenAPI.Test
{
    [TestClass]
    public class EventManagerTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        public class EventArgsTest : ChickenEventArgs
        {
            public string Name { get; set; }
        }


        private IEventManager _eventManager;
        private bool _registerTest;
        private int _instanceHash;

        [TestInitialize]
        public void Initialize()
        {
            _eventManager = new SimpleEventManager();
        }


        [TestMethod]
        public void RegisterTest()
        {
            _eventManager.Register<EventArgsTest>(TestCallback);
            _instanceHash = GetHashCode();
            _eventManager.Invoke(this, new EventArgsTest { Name = "test" });
            Assert.IsTrue(_registerTest);
        }

        private void TestCallback(object sender, ChickenEventArgs e)
        {
            if (!(e is EventArgsTest ev))
            {
                return;
            }
            _registerTest = sender.GetHashCode() == _instanceHash && ev.Name == "test";
        }
    }
}