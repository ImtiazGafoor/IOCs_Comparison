using NUnit.Framework;
using Microsoft.Practices.Unity;
using Unity.Test;
using Unity;
using System.Linq;
using System.Diagnostics;
using System;

namespace Tests
{
    public class Tests
    {
        IUnityContainer container;
        [OneTimeSetUp]
        public void Setup()
        {
            container = Registry.container;
        }

        [Test]
        public void ContactStaff_GetPeople()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var handler = container.Resolve<ContactStaffHandler>();
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
            var handler = container.Resolve<ContactStaffHandler>();
            var person = handler.HandlerGetPerson();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Assert.AreEqual(person, "Maggie");
        }
    }
}