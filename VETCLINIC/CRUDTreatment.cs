using System;
using System.Linq;
using System.Windows.Forms;
using VetClinic.Models.People;
using VetClinic.Models.Pets;
using VetClinic.Models.Treatments;

namespace VetClinic
{
    public partial class CRUDTreatment : Form
    {
        public Type SelectedClass { get; set; }
        public PersonManager PersonsManager { get; set; }
        public TreatmentManager TreatmentsManager { get; set; }
        public PetManager PetsManager { get; set; }


        public CRUDTreatment()
        {
            InitializeComponent();
        }

        public CRUDTreatment(Type selectedClass, PetManager petManager, TreatmentManager treatmentManager, PersonManager personManager) : this()
        {
            SelectedClass = selectedClass;
            PetsManager = petManager;
            TreatmentsManager = treatmentManager;
            PersonsManager = personManager;
            PopulatePetComboBox();
            PopulateVetComboBox();

            gbMedical.Visible = false;
            gbCheckUp.Visible = false;
            gbPreventive.Visible = false;
            gbSurgery.Visible = false;

            cbTreatment.SelectedIndexChanged += cbTreatment_SelectedIndexChanged;
        }

        private void PopulatePetComboBox()
        {
            cbPet.Items.Clear();
            var pets = PetsManager.GetAll().ToList();
            foreach (var pet in pets)
            {
                cbPet.Items.Add($"{pet.Name} ({pet.Breed})");
            }
        }

        private void PopulateVetComboBox()
        {
            cbVet.Items.Clear();
            var vets = PersonsManager.GetAll().OfType<Vet>().ToList();
            foreach (var vet in vets)
            {
                cbVet.Items.Add($"{vet.FirstName} {vet.LastName}");
            }
        }

        private void cbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbMedical.Visible = false;
            gbCheckUp.Visible = false;
            gbPreventive.Visible = false;
            gbSurgery.Visible = false;

            var selected = cbTreatment.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selected)) return;

            if (selected.Contains("Медичне лікування"))
                gbMedical.Visible = true;
            else if (selected.Contains("Огляд"))
                gbCheckUp.Visible = true;
            else if (selected.Contains("Превентимне лікування"))
                gbPreventive.Visible = true;
            else if (selected.Contains("Хірургічне втручання"))
                gbSurgery.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pet selectedPet = null;
            if (cbPet.SelectedItem != null)
            {
                string petDisplay = cbPet.SelectedItem.ToString();
                selectedPet = PetsManager.GetAll()
                    .FirstOrDefault(p => $"{p.Name} ({p.Breed})" == petDisplay);
            }

            Vet selectedVet = null;
            if (cbVet.SelectedItem != null)
            {
                string vetFullName = cbVet.SelectedItem.ToString();
                selectedVet = PersonsManager.GetAll()
                    .OfType<Vet>()
                    .FirstOrDefault(v => $"{v.FirstName} {v.LastName}" == vetFullName);
            }

            string treatmentType = cbTreatment.SelectedItem as string;
            Treatment newTreatment = null;

            string description = "";

            if (treatmentType != null)
            {
                if (treatmentType.Contains("Огляд"))
                {
                    newTreatment = new CheckUpTreatment(selectedPet, selectedVet, "Checkup", description);
                }
                else if (treatmentType.Contains("Медичне лікування"))
                {
                    newTreatment = new MedicalTreatment(selectedPet, selectedVet, "Medical", "", 0f, 0);
                }
                else if (treatmentType.Contains("Превентимне лікування"))
                {
                    newTreatment = new PreventiveTreatment(selectedPet, selectedVet, "Preventive", "", DateTime.Today);
                }
                else if (treatmentType.Contains("Хірургічне втручання"))
                {
                    newTreatment = new SurgicalTreatment(selectedPet, selectedVet, "Surgical", "", false);
                }
            }

            if (newTreatment != null)
            {
                TreatmentsManager.Create(newTreatment);
                MessageBox.Show("Лікування успішно додано!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не вдалося додати лікування. Будь ласка, перевірте введені дані.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
