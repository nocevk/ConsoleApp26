using VetClinic.Models.Pets;
using VetClinic.Models.People;

namespace VetClinic.Models.Treatments
{
    public class MedicalTreatment : Treatment
    {
        private string medicationName;
        private float dosageMg;
        private int durationDays;

        public string MedicationName { get => medicationName; set => medicationName = value; }
        public float DosageMg { get => dosageMg; set => dosageMg = value; }
        public int DurationDays { get => durationDays; set => durationDays = value; }

        public MedicalTreatment(Pet pet, Vet vet, string description,
                               string medicationName, float dosageMg, int durationDays)
            : base(pet, vet, description)
        {
            MedicationName = medicationName;
            DosageMg = dosageMg;
            DurationDays = durationDays;
        }
    }
}