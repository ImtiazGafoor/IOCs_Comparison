using Common;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq;
using Windsor.Test;

namespace Tests
{
    public class Tests
    {
        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        public void ContactStaff_GetPeople()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var handler = Registry.container.Resolve<ContactStaffHandler>();
            var list = handler.HandlerGetPeople();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Assert.AreEqual(list.Count(), 5);
        }
        [Test]
        public void ContactStaff_GetPerson()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var handler = Registry.container.Resolve<ContactStaffHandler>();
            var person = handler.HandlerGetPerson();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Assert.AreEqual(person, "Maggie");
        }

        [Test]
        public void ContactStaff_GetPeople_Interface()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var root = Registry.container.Resolve<IRepository>();
            var list = root.GetPeople();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Assert.AreEqual(list.Count(), 5);
        }
        [Test]
        public void ContactStaff_GetPerson_Interface()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var root = Registry.container.Resolve<IRepository>();
            var person = root.GetById(2);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Assert.AreEqual(person, "Maggie");
        }

    }
}