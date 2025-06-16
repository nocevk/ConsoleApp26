using System;
using System.Collections.Generic;

namespace VetClinic.Models
{
    public interface IManager<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        IEnumerable<T> GetAll();
        T Get(Func<T, bool> predicate);
    }
}