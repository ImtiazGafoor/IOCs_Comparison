using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Common;


namespace Windsor.Test
{
    public class ContactStaffHandler
    {
        private readonly IRepository repository;

        public ContactStaffHandler(IRepository repository)
        {
            this.repository = repository;

        }

        public IEnumerable<string> HandlerGetPeople()
        {
            return this.repository.GetPeople();
           
        }
        public string HandlerGetPerson()
        {
            return this.repository.GetById(2);

        }
    }
}
