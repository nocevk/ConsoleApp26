using VetClinic.Models.People;

namespace VetClinic.Models.Pets
{
    public class Cat : Pet
    {
        private bool isDeclawed;
        private bool isIndoor;

        public bool IsDeclawed { get => isDeclawed; set => isDeclawed = value; }
        public bool IsIndoor { get => isIndoor; set => isIndoor = value; }

        public Cat(string name, int age, int weight, string breed, Owner owner, bool isDeclawed, bool isIndoor)
            : base(name, age, weight, breed, owner)
        {
            IsDeclawed = isDeclawed;
            IsIndoor = isIndoor;
        }
    }
}   