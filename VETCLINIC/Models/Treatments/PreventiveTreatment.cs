using System;
using VetClinic.Models.Pets;
using VetClinic.Models.People;

namespace VetClinic.Models.Treatments
{
    public class PreventiveTreatment : Treatment
    {
        private string vaccineName;
        private DateTime nextDoseDue;

        public string VaccineName { get => vaccineName; set => vaccineName = value; }
        public DateTime NextDoseDue { get => nextDoseDue; set => nextDoseDue = value; }

        public PreventiveTreatment(Pet pet, Vet vet, string description,
                                  string vaccineName, DateTime nextDoseDue)
            : base(pet, vet, description)
        {
            VaccineName = vaccineName;
            NextDoseDue = nextDoseDue;
        }
    }
}