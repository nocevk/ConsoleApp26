using VetClinic.Models.Pets;
using VetClinic.Models.People;

namespace VetClinic.Models.Treatments
{
    public class CheckUpTreatment : Treatment
    {
        private string problemDescription;

        public string ProblemDescription { get => problemDescription; set => problemDescription = value; }

        public CheckUpTreatment(Pet pet, Vet vet, string description, string problemDescription)
            : base(pet, vet, description)
        {
            ProblemDescription = problemDescription;
        }
    }
}