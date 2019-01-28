using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class SQLRepository: IRepository
    {
        public string GetById(int id)
        {
            // Retrieve from db.
            return "Maggie";
        }

        public IEnumerable<string> GetPeople()
        {
            List<string> people = new List<string>();
            for (int i = 0; i < 5; i++)
                people.Add("Maggie");
            return people;
        }

        public void Save(string person)
        {
            // Save to db.
        }
    }
}
