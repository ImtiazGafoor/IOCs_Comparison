using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface IRepository
    {
        string GetById(int id);
        IEnumerable<string> GetPeople();
        void Save(string person);
       
    }
}
