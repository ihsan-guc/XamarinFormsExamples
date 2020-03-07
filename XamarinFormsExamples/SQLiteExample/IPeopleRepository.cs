using System.Collections.Generic;
using System.Threading.Tasks;
namespace XamarinFormsExamples.SQLiteExample
{
    public interface IPeopleRepository
    {
        Task<IEnumerable<People>> GetPersonelAsyncList();
        Task<bool> AddPeople(People people);
    }
}
