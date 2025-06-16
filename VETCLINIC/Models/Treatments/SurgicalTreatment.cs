using VetClinic.Models.Pets;
using VetClinic.Models.People;

namespace VetClinic.Models.Treatments
{
    public class SurgicalTreatment : Treatment
    {
        private string procedureName;
        private bool requiresAnesthesia;

        public string ProcedureName { get => procedureName; set => procedureName = value; }
        public bool RequiresAnesthesia { get => requiresAnesthesia; set => requiresAnesthesia = value; }

        public SurgicalTreatment(Pet pet, Vet vet, string description,
                                string procedureName, bool requiresAnesthesia)
            : base(pet, vet, description)
        {
            ProcedureName = procedureName;
            RequiresAnesthesia = requiresAnesthesia;
        }
    }
}