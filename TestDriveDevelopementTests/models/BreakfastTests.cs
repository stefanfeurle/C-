using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDriveDevelopement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestDriveDevelopement.Extensions;

namespace TestDriveDevelopement.Tests
{
    [TestClass()]
    public class BreakfastTests
    {
        [TestMethod()]
        public void ToastBreadTest()
        {
            var coffee = Breakfast.PourCoffee();
            Assert.IsTrue(typeof(Coffee) == coffee.GetType());
        }

        [TestMethod()]
        public void TestCoffeeTemperature()
        {
            var coffee = Breakfast.PourCoffee();
            Assert.AreEqual("Hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.AreEqual("Quite hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.AreEqual("Not so hot", coffee.Temperature);
            Thread.Sleep(500);
            Assert.AreEqual("Cold", coffee.Temperature);
        }

        [TestMethod()]
        public void TestFryingEggsLength()
        {
            var eggs = Breakfast.FryEggs(2);
            Assert.AreEqual(2, eggs.Length);
            Assert.AreEqual("2 eggs", eggs.Print());
        }

        [TestMethod()]
        public void TestFryingBaconLength()
        {
            var bacon = Breakfast.FryBacon(3);
            Assert.AreEqual(3, bacon.Length);
            Breakfast.EatBacon(ref bacon, 2);
            Assert.AreEqual(1, bacon.Length);
        }

        [TestMethod()]
        public void TestToastingBreadLength()
        {
            var toasts = Breakfast.ToastBread(2);
            Assert.AreEqual(2, toasts.Length);
        }

        [TestMethod()]
        public void TestApplyingToToast()
        {
            var toasts = Breakfast.ToastBread(2);

            Breakfast.ApplyButter(toasts[0]);
            Breakfast.ApplyJam(toasts[1]);

            Assert.IsFalse(toasts[0].JamApplied);
            Assert.IsFalse(toasts[1].ButterApplied);
            Assert.IsTrue(toasts[1].JamApplied);
            Assert.IsTrue(toasts[0].ButterApplied);
        }
    }
}