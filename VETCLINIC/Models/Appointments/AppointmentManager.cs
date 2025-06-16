using System;
using System.Collections.Generic;
using System.Linq;

namespace VetClinic.Models.Appointments
{
    public class AppointmentManager : IManager<Appointment>
    {
        private readonly List<Appointment> appointments;

        public AppointmentManager()
        {
            appointments = new List<Appointment>();
        }

        public void Create(Appointment appointment)
        {
            if (appointment == null) throw new ArgumentNullException(nameof(appointment));
            appointments.Add(appointment);
        }

        public void Update(Appointment appointment)
        {
            if (appointment == null) throw new ArgumentNullException(nameof(appointment));
            int index = appointments.FindIndex(a => a == appointment);
            if (index >= 0)
            {
                appointments[index] = appointment;
            }
        }

        public void Delete(Appointment item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            var toRemove = appointments.FirstOrDefault(a =>
                a.Pet?.Name == item.Pet?.Name &&
                a.Pet?.Breed == item.Pet?.Breed &&
                a.Treatment?.Vet?.FirstName == item.Treatment?.Vet?.FirstName &&
                a.Treatment?.Vet?.LastName == item.Treatment?.Vet?.LastName &&
                a.Date == item.Date
            );
            if (toRemove != null)
                appointments.Remove(toRemove);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return new List<Appointment>(appointments);
        }

        public Appointment Get(Func<Appointment, bool> predicate)
        {
            return appointments.FirstOrDefault(predicate);
        }

        public List<Appointment> ShowByDay(DateTime day)
        {
            return appointments
                .Where(appt => appt.Date.Date == day.Date)
                .ToList();
        }

        public List<Appointment> ShowByDay(DateTime startFrom, DateTime endAt)
        {
            return appointments
                .Where(appt => appt.Date.Date >= startFrom.Date && appt.Date.Date <= endAt.Date)
                .ToList();
        }

        public List<Appointment> ShowByPetNameAndType(string petName, Type petType)
        {
            if (string.IsNullOrWhiteSpace(petName)) throw new ArgumentNullException(nameof(petName));
            if (petType == null) throw new ArgumentNullException(nameof(petType));
            return appointments
                .Where(appt => appt.Pet != null &&
                               string.Equals(appt.Pet.Name, petName, StringComparison.OrdinalIgnoreCase) &&
                               appt.Pet.GetType() == petType)
                .ToList();
        }

        public List<Appointment> ShowByVetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentNullException(nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentNullException(nameof(lastName));
            return appointments
                .Where(appt => appt.Treatment != null &&
                               appt.Treatment.Vet != null &&
                               string.Equals(appt.Treatment.Vet.FirstName, firstName, StringComparison.OrdinalIgnoreCase) &&
                               string.Equals(appt.Treatment.Vet.LastName, lastName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}