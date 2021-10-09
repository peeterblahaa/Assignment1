using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface AdultsData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        
        void RemoveAdult(int Id);
        void Update(Adult adult);
        Adult Get(int age);
    }
}