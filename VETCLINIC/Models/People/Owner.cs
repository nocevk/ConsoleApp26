using System;
using System.Collections.Generic;

namespace VetClinic.Models.People
{
    public class Owner : Person
    {
        private List<Owner> trustedOwners;

        public List<Owner> TrustedOwners { get => trustedOwners; set => trustedOwners = value; }

        public Owner(string firstName, string lastName, DateTime birthDay, List<Owner> trustedOwners = null)
            : base(firstName, lastName, birthDay)
        {
            TrustedOwners = trustedOwners ?? new List<Owner>();
        }
    }
}