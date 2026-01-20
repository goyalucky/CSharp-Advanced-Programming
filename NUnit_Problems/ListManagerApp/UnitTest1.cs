/* Testing List Operations
Problem:
Create a ListManager class that has the following methods:
● AddElement(List<int> list, int element): Adds an element to a list.
● RemoveElement(List<int> list, int element): Removes an element from a list.
● GetSize(List<int> list): Returns the size of the list. */

using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ListManagerApp
{
    [TestFixture]
    public class UnitTest1
    {
        private ListManager mgr;
        private List<int> lst;

        [SetUp]
        public void Setup()
        {
            mgr = new ListManager();
            lst = new List<int>();
        }

        [Test]
        public void AddsElement()
        {
            mgr.Add(lst, 10);
            Assert.Contains(10, lst);
            Assert.AreEqual(1, lst.Count);
        }

        [Test]
        public void RemovesElement()
        {
            lst.Add(20);
            bool res = mgr.Remove(lst, 20);
            Assert.IsTrue(res);
            Assert.IsFalse(lst.Contains(20));
            Assert.AreEqual(0, lst.Count);
        }

        [Test]
        public void RemoveNotFound()
        {
            bool res = mgr.Remove(lst, 99);
            Assert.IsFalse(res);
            Assert.AreEqual(0, lst.Count);
        }

        [Test]
        public void SizeReturns()
        {
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            Assert.AreEqual(3, mgr.Size(lst));
        }

        [Test]
        public void NullThrows()
        {
            Assert.Throws<ArgumentNullException>(() => mgr.Add(null, 1));
            Assert.Throws<ArgumentNullException>(() => mgr.Remove(null, 1));
            Assert.Throws<ArgumentNullException>(() => mgr.Size(null));
        }
    }
}

