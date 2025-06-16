using System;
using System.Collections.Generic;
using VetClinic.Models.Pets;
using VetClinic.Models.Treatments;

namespace VetClinic.Models.People
{
    public class Vet : Person
    {
        private List<Type> certifiedToWorkWith;
        private List<Type> certifiedToDo;
        private DateTime employmentDate;

        public List<Type> CertifiedToWorkWith { get => certifiedToWorkWith; set => certifiedToWorkWith = value; }
        public List<Type> CertifiedToDo { get => certifiedToDo; set => certifiedToDo = value; }
        public DateTime EmploymentDate { get => employmentDate; set => employmentDate = value; }

        public Vet(string firstName, string lastName, DateTime birthDay,
                   List<Type> certifiedToWorkWith, List<Type> certifiedToDo, DateTime employmentDate)
            : base(firstName, lastName, birthDay)
        {
            CertifiedToWorkWith = certifiedToWorkWith ?? new List<Type>();
            CertifiedToDo = certifiedToDo ?? new List<Type>();
            EmploymentDate = employmentDate;
        }
    }
}