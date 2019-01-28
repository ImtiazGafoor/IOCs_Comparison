using NUnit.Framework;
using SimpleInjector.Test;
using System;
using System.Diagnostics;
using System.Linq;

namespace Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        { 
        }

        [Test]
        public void ContactStaff_GetPeople()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var handler = Registry.container.GetInstance<ContactStaffHandler>();
            var list = handler.HandlerGetPeople();
            watch.Stop();
            Console.WriteLine("Time took:" + watch.ElapsedMilliseconds);
            Assert.AreEqual(list.Count(), 5);
        }
        [Test]
        public void ContactStaff_GetPerson()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var handler = Registry.container.GetInstance<ContactStaffHandler>();
            var person = handler.HandlerGetPerson();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Assert.AreEqual(person,"Maggie");
        }
    }
}