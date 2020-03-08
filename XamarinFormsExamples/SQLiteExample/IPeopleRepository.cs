using System;
using System.Collections.Generic;
namespace XamarinFormsExamples.SQLiteExample
{
    public interface IPeopleRepository
    {
        List<People> GetPersonelList();
        bool AddPeople(People people);
        bool DeletePeople(Guid id);
    }
}
