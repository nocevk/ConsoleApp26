using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VetClinic.Models.Appointments;
using VetClinic.Models.Treatments;

namespace VetClinic
{
    public partial class CRUDAppointment : Form
    {
        public Type SelectedClass { get; set; }
        public AppointmentManager AppointmentsManager { get; set; }
        public TreatmentManager TreatmentManager { get; set; }
        public CRUDAppointment()
        {
            InitializeComponent();
        }
        public CRUDAppointment(Type selectedClass, AppointmentManager appointmentManager, TreatmentManager treatmentManager) : this()
        {
            SelectedClass = selectedClass;
            AppointmentsManager = appointmentManager;
            TreatmentManager = treatmentManager;
            PopulateComboBoxes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbPets.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть тварину.");
                return;
            }
            if (cbTreatment.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть лікування.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbProblemDescription.Text))
            {
                MessageBox.Show("Будь ласка, введіть опис проблеми.");
                return;
            }

            var petName = cbPets.SelectedItem.ToString().Split('(')[0].Trim();
            var pet = AppointmentsManager.GetAll()
                .Where(a => a.Pet != null && a.Pet.Name == petName)
                .Select(a => a.Pet)
                .FirstOrDefault();

            var treatmentDesc = cbTreatment.SelectedItem.ToString().Split('(')[0].Trim();
            var treatment = TreatmentManager.GetAll()
                .FirstOrDefault(t => t.Description == treatmentDesc && t.Pet != null && t.Pet.Name == petName);

            if (pet == null || treatment == null)
            {
                MessageBox.Show("Не вдалося знайти вибрану тварину або лікування.");
                return;
            }

            var appointment = new Appointment(
                dtpDate.Value,
                pet,
                tbProblemDescription.Text.Trim(),
                treatment
            );

            try
            {
                AppointmentsManager.Create(appointment);
                MessageBox.Show("Запис успішно додано.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при додаванні запису: " + ex.Message);
            }
        }

        private void PopulateComboBoxes()
        {
            var pets = AppointmentsManager.GetAll()
                .Where(a => a.Pet != null)
                .Select(a => a.Pet)
                .Distinct()
                .ToList();

            cbPets.Items.Clear();
            foreach (var pet in pets)
            {
                cbPets.Items.Add($"{pet.Name} ({pet.Breed})");
            }

            var treatments = TreatmentManager.GetAll()
                .Where(t => t != null && t.Pet != null)
                .ToList();

            cbTreatment.Items.Clear();
            foreach (var treatment in treatments)
            {
                cbTreatment.Items.Add($"{treatment.Description} ({treatment.Pet.Name})");
            }
        }
    }
}
