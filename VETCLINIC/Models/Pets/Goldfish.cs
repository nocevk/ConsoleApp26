using VetClinic.Models.People;

namespace VetClinic.Models.Pets
{
    public class Goldfish : Pet
    {
        private bool isSeaWater;
        private float recommendedTankVolume;
        private int tankSize;

        public bool IsSeaWater { get => isSeaWater; set => isSeaWater = value; }
        public float RecommendedTankVolume { get => recommendedTankVolume; set => recommendedTankVolume = value; }
        public int TankSize { get => tankSize; set => tankSize = value; }

        public Goldfish(string name, int age, int weight, string breed, Owner owner,
                        bool isSeaWater, float recommendedTankVolume, int tankSize)
            : base(name, age, weight, breed, owner)
        {
            IsSeaWater = isSeaWater;
            RecommendedTankVolume = recommendedTankVolume;
            TankSize = tankSize;
        }
    }
}