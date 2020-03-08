using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using XamarinFormsExamples.SQLiteExample;

namespace SQLiteExample
{
    public class PeopleRepository : IPeopleRepository
    {
        EfContext context;
        public PeopleRepository(string path)
        {
            context = new EfContext(path);
        }
        public bool AddPeople(People people)
        {
            try
            {
                var tracking = context.Peoples.Add(people);
                context.SaveChangesAsync();
                var isAdd = tracking.State == EntityState.Added;
                return isAdd;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<People> GetPersonelList()
        {
            try
            {
                var list = context.Peoples.ToList();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
