using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<bool> AddPeople(People people)
        {
            try
            {
                var tracking = await context.Peoples.AddAsync(people);
                await context.SaveChangesAsync();
                var isAdd = tracking.State == EntityState.Added;
                return isAdd;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<People>> GetPersonelAsyncList()
        {
            try
            {
                var list = await context.Peoples.ToListAsync();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
