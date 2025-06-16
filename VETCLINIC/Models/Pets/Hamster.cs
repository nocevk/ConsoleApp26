using VetClinic.Models.People;

namespace VetClinic.Models.Pets
{
    public class Hamster : Pet
    {
        private string cageSize;
        private string wheelSize;
        private bool isNocturnal;
        private bool hasWheel;

        public string CageSize { get => cageSize; set => cageSize = value; }
        public string WheelSize { get => wheelSize; set => wheelSize = value; }
        public bool IsNocturnal { get => isNocturnal; set => isNocturnal = value; }
        public bool HasWheel { get => hasWheel; set => hasWheel = value; }

        public Hamster(string name, int age, int weight, string breed, Owner owner,
                       string cageSize, string wheelSize, bool isNocturnal, bool hasWheel)
            : base(name, age, weight, breed, owner)
        {
            CageSize = cageSize;
            WheelSize = wheelSize;
            IsNocturnal = isNocturnal;
            HasWheel = hasWheel;
        }
    }
}