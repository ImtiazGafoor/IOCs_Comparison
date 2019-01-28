using Common;
using System.Collections.Generic;

namespace Unity.Test
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
