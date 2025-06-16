using System;
using System.Collections.Generic;
using System.Linq;

namespace VetClinic.Models.Treatments
{
    public class TreatmentManager : IManager<Treatment>
    {
        private readonly List<Treatment> treatments = new List<Treatment>();

        public void Create(Treatment item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            treatments.Add(item);
        }

        public void Update(Treatment item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            int index = treatments.FindIndex(t => t == item);
            if (index >= 0)
                treatments[index] = item;
        }

        public void Delete(Treatment item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            var toRemove = treatments.FirstOrDefault(t =>
                t.Description == item.Description &&
                t.Pet?.Name == item.Pet?.Name &&
                t.Pet?.Breed == item.Pet?.Breed &&
                t.Vet?.FirstName == item.Vet?.FirstName &&
                t.Vet?.LastName == item.Vet?.LastName
            );
            if (toRemove != null)
                treatments.Remove(toRemove);
        }

        public IEnumerable<Treatment> GetAll()
        {
            return new List<Treatment>(treatments);
        }

        public Treatment Get(Func<Treatment, bool> predicate)
        {
            return treatments.FirstOrDefault(predicate);
        }
    }
}