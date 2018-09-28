using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCounter;
using System.Linq;

namespace MSTestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PushTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            Assert.AreEqual(3, calc.stack.Count);
        }

        [TestMethod]
        public void TopTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            Assert.AreEqual(10, calc.stack.Peek());
            Assert.AreEqual(3, calc.stack.Count);
        }

        [TestMethod]
        public void PopTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            calc.Pop();
            Assert.AreEqual(2, calc.stack.Count);
            Assert.AreEqual(40, calc.stack.Peek());
        }

        [TestMethod]
        public void AddTest()
        {
            var calc = new StackCountImpl();
            calc.Clear();
            calc.StackNumbers();
            Assert.AreEqual(100, calc.AddAll());
        }

        [TestMethod]
        public void AddPop()
        {
            var calc = new StackCountImpl();
            calc.Clear();
            calc.StackNumbers();
            Assert.AreEqual(50, calc.AddPop());
        }

        [TestMethod]
        public void SubAllTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            Assert.AreEqual(-30, calc.SubAll());
        }

        [TestMethod]
        public void MultAllTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            Assert.AreEqual(20000, calc.MultAll());
        }

        [TestMethod]
        public void MultPopTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            Assert.AreEqual(400, calc.MultPop());
        }

        [TestMethod]
        public void DivTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            Assert.AreEqual(0.25, calc.Div());
        }
        
        [TestMethod]
        public void ClearTest()
        {
            var calc = new StackCountImpl();
            calc.StackNumbers();
            calc.Clear();
            Assert.AreEqual(0, calc.stack.Count);
        }
    }
}
