using System;
using VetClinic.Models.Pets;
using VetClinic.Models.People;

namespace VetClinic.Models.Treatments
{
    public abstract class Treatment
    {
        private Pet pet;
        private Vet vet;
        private string description;

        public Pet Pet
        {
            get => pet;
            set
            {
                pet = value;
                ValidateVetCapability();
            }
        }
        public Vet Vet
        {
            get => vet;
            set
            {
                vet = value;
                ValidateVetCapability();
            }
        }
        public string Description { get => description; set => description = value; }

        protected Treatment(Pet pet, Vet vet, string description)
        {
            this.pet = pet;
            this.vet = vet;
            Description = description;
            ValidateVetCapability();
        }
        protected void ValidateVetCapability()
        {
            if (vet == null || pet == null)
                return;

            bool canWorkWithPet = vet.CertifiedToWorkWith != null &&
                                  vet.CertifiedToWorkWith.Contains(pet.GetType());

            bool canDoTreatment = vet.CertifiedToDo != null &&
                                  vet.CertifiedToDo.Contains(this.GetType());

            if (!canWorkWithPet)
                throw new InvalidOperationException("Vet is not certified to work with this type of pet.");

            if (!canDoTreatment)
                throw new InvalidOperationException("Vet is not certified to perform this type of treatment.");
        }
    }
}