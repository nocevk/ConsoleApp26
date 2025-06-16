using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VetClinic.Models.People;

namespace VetClinic
{
    public partial class CRUDPerson : Form
    {
        public Type SelectedClass { get; set; }
        public PersonManager PersonsManager { get; set; }

        public CRUDPerson()
        {
            InitializeComponent();
        }

        public CRUDPerson(Type selectedClass, PersonManager personsManager) : this()
        {
            SelectedClass = selectedClass;
            PersonsManager = personsManager;
            gbOwner.Enabled = gbOwner.Visible = SelectedClass == typeof(Owner);
            gbVet.Enabled = gbVet.Visible = SelectedClass == typeof(Vet);
            PopulateCertifiedOwnerComboBoxes();
        }

        private void PopulateCertifiedOwnerComboBoxes()
        {
            var owners = PersonsManager.GetAll().OfType<Owner>().ToList();
            var ownerNames = owners.Select(o => $"{o.FirstName} {o.LastName}").ToArray();

            cbCertifiedOwner1.Items.Clear();
            cbCertifiedOwner2.Items.Clear();
            cbCertifiedOwner3.Items.Clear();

            cbCertifiedOwner1.Items.AddRange(ownerNames);
            cbCertifiedOwner2.Items.AddRange(ownerNames);
            cbCertifiedOwner3.Items.AddRange(ownerNames);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            DateTime birthDay = dtpBirthDay.Value;

            Person newPerson = null;

            if (SelectedClass == typeof(Owner))
            {
                var allOwners = PersonsManager.GetAll().OfType<Owner>().ToList();
                var trustedOwners = new List<Owner>();

                var trusted1 = cbCertifiedOwner1.SelectedItem as string;
                var trusted2 = cbCertifiedOwner2.SelectedItem as string;
                var trusted3 = cbCertifiedOwner3.SelectedItem as string;

                if (!string.IsNullOrWhiteSpace(trusted1))
                {
                    var owner = allOwners.FirstOrDefault(o => $"{o.FirstName} {o.LastName}" == trusted1);
                    if (owner != null) trustedOwners.Add(owner);
                }
                if (!string.IsNullOrWhiteSpace(trusted2))
                {
                    var owner = allOwners.FirstOrDefault(o => $"{o.FirstName} {o.LastName}" == trusted2);
                    if (owner != null && !trustedOwners.Contains(owner)) trustedOwners.Add(owner);
                }
                if (!string.IsNullOrWhiteSpace(trusted3))
                {
                    var owner = allOwners.FirstOrDefault(o => $"{o.FirstName} {o.LastName}" == trusted3);
                    if (owner != null && !trustedOwners.Contains(owner)) trustedOwners.Add(owner);
                }

                newPerson = new Owner(firstName, lastName, birthDay)
                {
                    TrustedOwners = trustedOwners
                };
            }
            else if (SelectedClass == typeof(Vet))
            {
                var certifiedPetTypes = new List<Type>();
                if (chkbCertifiedDog.Checked) certifiedPetTypes.Add(typeof(Models.Pets.Dog));
                if (chkbCertifiedCat.Checked) certifiedPetTypes.Add(typeof(Models.Pets.Cat));
                if (chkbCertifiedGoldfish.Checked) certifiedPetTypes.Add(typeof(Models.Pets.Goldfish));
                if (chkbCertifiedHamster.Checked) certifiedPetTypes.Add(typeof(Models.Pets.Hamster));

                var certifiedTreatmentTypes = new List<Type>();
                if (chkbCertifiedCheckup.Checked) certifiedTreatmentTypes.Add(typeof(Models.Treatments.CheckUpTreatment));
                if (chkbCertifiedMedical.Checked) certifiedTreatmentTypes.Add(typeof(Models.Treatments.MedicalTreatment));
                if (chkbCertifiedPreventive.Checked) certifiedTreatmentTypes.Add(typeof(Models.Treatments.PreventiveTreatment));
                if (chkbCertifiedSurgery.Checked) certifiedTreatmentTypes.Add(typeof(Models.Treatments.SurgicalTreatment));

                newPerson = new Vet(firstName, lastName, birthDay, certifiedPetTypes, certifiedTreatmentTypes, DateTime.Today);
            }

            if (newPerson != null)
            {
                PersonsManager.Create(newPerson);
                MessageBox.Show("Людину успішно додано!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не вдалося додати людину. Будь ласка, перевірте введені дані.");
            }
        }
    }
}
