using System;
using VetClinic.Models.People;

namespace VetClinic.Models.Pets
{
    public abstract class Pet
    {
        private string name;
        private int age;
        private int weight;
        private string breed;
        private Owner owner;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Breed { get => breed; set => breed = value; }
        public Owner Owner { get => owner; set => owner = value; }

        protected Pet(string name, int age, int weight, string breed, Owner owner)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Breed = breed;
            Owner = owner;
        }
    }
}