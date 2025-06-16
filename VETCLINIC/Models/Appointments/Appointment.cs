using System;
using VetClinic.Models.Pets;
using VetClinic.Models.Treatments;

namespace VetClinic.Models.Appointments
{
    public class Appointment
    {
        private DateTime date;
        private Pet pet;
        private string problemDescription;
        private Treatment treatment;

        public DateTime Date { get => date; set => date = value; }
        public Pet Pet { get => pet; set => pet = value; }
        public string ProblemDescription { get => problemDescription; set => problemDescription = value; }
        public Treatment Treatment { get => treatment; set => treatment = value; }

        public Appointment(DateTime date, Pet pet, string problemDescription, Treatment treatment)
        {
            Date = date;
            Pet = pet;
            ProblemDescription = problemDescription;
            Treatment = treatment;
        }
    }
}