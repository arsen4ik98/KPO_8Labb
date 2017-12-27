using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LR_CPO8;

namespace LR_CPO8_TEST
{
    [TestFixture()]
    public class DecoratorTest
    {
        [Test()]
        public void CoffeNameTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            string expected = "Кофе";
            string actual;
            actual = coffee_machine.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void CocoaNameTest()
        {
            CoffeeMachine coffee_machine = new Cocoa();
            string expected = "Какао";
            string actual;
            actual = coffee_machine.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ChocolateNameTest()
        {
            CoffeeMachine coffee_machine = new Chocolate();
            string expected = "Шоколад";
            string actual;
            actual = coffee_machine.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void SugarNameTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            coffee_machine = new Sugar(coffee_machine); 
            string expected = "Кофе, с сахаром";
            string actual;
            actual = coffee_machine.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void MilkNameTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            coffee_machine = new Milk(coffee_machine); 
            string expected = "Кофе, с молоком";
            string actual;
            actual = coffee_machine.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void CreamNameTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            coffee_machine = new Cream(coffee_machine); 
            string expected = "Кофе, со сливками";
            string actual;
            actual = coffee_machine.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void CoffeCostTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            int expected = 50;
            int actual;
            actual = coffee_machine.GetCost();
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void CocoaCostTest()
        {
            CoffeeMachine coffee_machine = new Cocoa();
            int expected = 35;
            int actual;
            actual = coffee_machine.GetCost();
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ChocolateCostTest()
        {
            CoffeeMachine coffee_machine = new Chocolate();
            int expected = 20;
            int actual;
            actual = coffee_machine.GetCost();
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void SugarCostTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            coffee_machine = new Sugar(coffee_machine);
            int expected = 52;
            int actual;
            actual = coffee_machine.GetCost();
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void MilkCostTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            coffee_machine = new Milk(coffee_machine);
            int expected = 55;
            int actual;
            actual = coffee_machine.GetCost();
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void CreamCostTest()
        {
            CoffeeMachine coffee_machine = new Coffee();
            coffee_machine = new Cream(coffee_machine);
            int expected = 57;
            int actual;
            actual = coffee_machine.GetCost();
            Assert.AreEqual(expected, actual);
        }
    }
}
