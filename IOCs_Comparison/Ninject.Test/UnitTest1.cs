using Ninject;
using Ninject.Test;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        private IKernel kernel;

        [OneTimeSetUp]
        public void Setup()
        {
            kernel = new StandardKernel();
            kernel.Load(new Registry());
        }

        [Test]
        public void ContactStaff_GetPeople()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var handler =kernel.Get<ContactStaffHandler>();
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
            var handler = kernel.Get<ContactStaffHandler>();
            var person = handler.HandlerGetPerson();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Assert.AreEqual(person, "Maggie");
        }
    }
}