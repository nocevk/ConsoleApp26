using VetClinic.Models.People;

namespace VetClinic.Models.Pets
{
    public class Dog : Pet
    {
        private bool isTrained;
        private int aggressionLevel;
        private bool isIndoor;

        public bool IsTrained { get => isTrained; set => isTrained = value; }
        public int AggressionLevel { get => aggressionLevel; set => aggressionLevel = value; }
        public bool IsIndoor { get => isIndoor; set => isIndoor = value; }

        public Dog(string name, int age, int weight, string breed, Owner owner,
                   bool isTrained, int aggressionLevel, bool isIndoor)
            : base(name, age, weight, breed, owner)
        {
            IsTrained = isTrained;
            AggressionLevel = aggressionLevel;
            IsIndoor = isIndoor;
        }
    }
}