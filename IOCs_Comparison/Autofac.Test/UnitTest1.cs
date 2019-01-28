using Autofac;
using Autofac.Test;
using Common;
using NUnit.Framework;
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
            using (var scope = Registry.container.BeginLifetimeScope())
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();

                var handler = scope.Resolve<ContactStaffHandler>();
                var list = handler.HandlerGetPeople();

                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds);
                Assert.AreEqual(list.Count(), 5);

            }
        }
        [Test]
        public void ContactStaff_GetPerson()
        {
            using (var scope = Registry.container.BeginLifetimeScope())
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                var handler = scope.Resolve<ContactStaffHandler>();
                var person = handler.HandlerGetPerson();
                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds);
                Assert.AreEqual(person, "Maggie");
            }
        }

    }
}