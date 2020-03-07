using System.Collections.Generic;
using System.Threading.Tasks;
namespace XamarinFormsExamples.SQLiteExample
{
    public interface IPeopleRepository
    {
        List<People> GetPersonelList();
        Task<bool> AddPeople(People people);
    }
}
