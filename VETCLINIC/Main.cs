using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VetClinic.Models.Appointments;
using VetClinic.Models.People;
using VetClinic.Models.Pets;
using VetClinic.Models.Treatments;

namespace VetClinic
{
    public partial class Main : Form
    {
        private PetManager petManager = new PetManager();
        private PersonManager personManager = new PersonManager();
        private AppointmentManager appointmentManager = new AppointmentManager();
        private TreatmentManager treatmentManager = new TreatmentManager();

        public Main()
        {
            InitializeComponent();
            GenerateData();
            PopulatePetComboBoxes(petManager);
            PopulatePersonAndVetTreatmentComboBoxes(personManager, treatmentManager);
            PopulateTreatmentDescriptionAndVetComboBoxes(treatmentManager);
            gvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShowDogs_Click(object sender, EventArgs e)
        {
            ShowPetsOfType<Dog>("Dogs");
        }

        private void btnShowCats_Click(object sender, EventArgs e)
        {
            ShowPetsOfType<Cat>("Cats");
        }

        private void btnShowGoldfisshes_Click(object sender, EventArgs e)
        {
            ShowPetsOfType<Goldfish>("Goldfishes");
        }

        private void btnShowHamsters_Click(object sender, EventArgs e)
        {
            ShowPetsOfType<Hamster>("Hamsters");
        }

        private void btnShowOwners_Click(object sender, EventArgs e)
        {
            var owners = personManager.GetAll().OfType<Owner>();
            ShowPeopleOfType<Owner>("Owners", owners);
        }

        private void btnShowVets_Click(object sender, EventArgs e)
        {
            var vets = personManager.GetAll().OfType<Vet>();
            ShowPeopleOfType<Vet>("Vets", vets);
        }


        private void btnShowAppointments_Click(object sender, EventArgs e)
        {
            ShowAppointments(appointmentManager.ShowByDay(dtpFrom.Value, dtpTo.Value), "Appointments");
        }

        private void btnShowAppointmentsByVet_Click(object sender, EventArgs e)
        {
            var nameParts = tbName.Text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2)
            {
                MessageBox.Show("Будь ласка, введіть ім'я та прізвище ветеринара (наприклад, 'Грег Міллер').", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string firstName = nameParts[0];
            string lastName = string.Join(" ", nameParts.Skip(1)); // Support multi-part last names

            try
            {
                var appointments = appointmentManager.ShowByVetName(firstName, lastName);
                ShowAppointments(appointments, $"Записи для ветеринара: {firstName} {lastName}");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAppointmentsByPet_Click(object sender, EventArgs e)
        {
            var petName = tbName.Text.Trim();
            if (string.IsNullOrWhiteSpace(petName))
            {
                MessageBox.Show("Будь ласка, введіть ім'я тварини.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var petKind = tbPetKind.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(petKind))
            {
                MessageBox.Show("Будь ласка, виберіть тип тварини.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Type petType = null;
            switch (tbPetKind.SelectedIndex)
            {
                case 0:
                    petType = typeof(Goldfish);
                    break;
                case 1:
                    petType = typeof(Cat);
                    break;
                case 2:
                    petType = typeof(Hamster);
                    break;
                case 3:
                    petType = typeof(Dog);
                    break;
                default:
                    MessageBox.Show("Обрано невідомий тип тварини.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            try
            {
                var appointments = appointmentManager.ShowByPetNameAndType(petName, petType);
                ShowAppointments(appointments, $"Записи для {petKind}: {petName}");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPetsOfOwner_Click(object sender, EventArgs e)
        {
            var nameParts = tbName.Text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2)
            {
                MessageBox.Show("Будь ласка, введіть ім'я та прізвище власника (наприклад, 'Аліса Сміт').", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string firstName = nameParts[0];
            string lastName = string.Join(" ", nameParts.Skip(1));

            try
            {
                var pets = petManager.GetPetsByOwnerName(firstName, lastName).ToList();
                if (pets.Count == 0)
                {
                    MessageBox.Show($"Не знайдено тварин для власника: {firstName} {lastName}.", "Немає результатів", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                gvMain.Rows.Clear();
                gvMain.Columns.Clear();
                gvMain.Columns.Add("Name", "Name");
                gvMain.Columns.Add("Age", "Age");
                gvMain.Columns.Add("Weight", "Weight");
                gvMain.Columns.Add("Breed", "Breed");
                gvMain.Columns.Add("Owner", "Owner");

                foreach (var pet in pets)
                {
                    gvMain.Rows.Add(
                        pet.Name,
                        pet.Age,
                        pet.Weight,
                        pet.Breed,
                        pet.Owner != null ? $"{pet.Owner.FirstName} {pet.Owner.LastName}" : ""
                    );
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTableSelect.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть таблицю для додавання запису.", "Потрібно вибрати", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selected = cbTableSelect.SelectedItem.ToString();
            Type selectedClass = null;

            switch (selected)
            {
                case string s when s.Contains("Запис"): selectedClass = typeof(Appointment); break;
                case string s when s.Contains("Власник"): selectedClass = typeof(Owner); break;
                case string s when s.Contains("Ветеринар"): selectedClass = typeof(Vet); break;
                case string s when s.Contains("Кіт"): selectedClass = typeof(Cat); break;
                case string s when s.Contains("Собака"): selectedClass = typeof(Dog); break;
                case string s when s.Contains("Хом'як"): selectedClass = typeof(Hamster); break;
                case string s when s.Contains("Рибка"): selectedClass = typeof(Goldfish); break;
                case string s when s.Contains("Лікування"): selectedClass = typeof(Treatment); break;
                default:
                    MessageBox.Show("Обрано невідому таблицю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            Form form = null;
            if (selected.Contains("Запис"))
                form = new CRUDAppointment(selectedClass, appointmentManager, treatmentManager);
            else if (selected.Contains("Власник") || selected.Contains("Ветеринар"))
                form = new CRUDPerson(selectedClass, personManager);
            else if (selected.Contains("Кіт") || selected.Contains("Собака") || selected.Contains("Хом'як") || selected.Contains("Рибка"))
                form = new CRUDPet(selectedClass, petManager, personManager);
            else if (selected.Contains("Лікування"))
                form = new CRUDTreatment(selectedClass, petManager, treatmentManager, personManager);

            if (form != null)
            {
                form.ShowDialog();
            }
        }

        private void ShowAppointments(List<Appointment> appointments, string title)
        {
            gvMain.Rows.Clear();
            gvMain.Columns.Clear();

            gvMain.Columns.Add("Date", "Date");
            gvMain.Columns.Add("Pet", "Pet");
            gvMain.Columns.Add("Owner", "Owner");
            gvMain.Columns.Add("Vet", "Vet");
            gvMain.Columns.Add("Treatment", "Treatment");

            foreach (var appt in appointments)
            {
                string petName = appt.Pet != null ? appt.Pet.Name : "";
                string ownerName = appt.Pet != null && appt.Pet.Owner != null
                    ? $"{appt.Pet.Owner.FirstName} {appt.Pet.Owner.LastName}" : "";
                string vetName = appt.Treatment != null && appt.Treatment.Vet != null
                    ? $"{appt.Treatment.Vet.FirstName} {appt.Treatment.Vet.LastName}" : "";
                string treatmentName = appt.Treatment != null ? appt.Treatment.Description : "";

                gvMain.Rows.Add(
                    appt.Date.ToString("g"),
                    petName,
                    ownerName,
                    vetName,
                    treatmentName
                );
            }
        }

        private void ShowPetsOfType<T>(string title) where T : Pet
        {
            var pets = petManager.GetAll().Where(p => p is T).ToList();
            gvMain.Rows.Clear();
            gvMain.Columns.Clear();

            gvMain.Columns.Add("Name", "Name");
            gvMain.Columns.Add("Age", "Age");
            gvMain.Columns.Add("Weight", "Weight");
            gvMain.Columns.Add("Breed", "Breed");
            gvMain.Columns.Add("Owner", "Owner");

            if (typeof(T) == typeof(Dog))
            {
                gvMain.Columns.Add("IsTrained", "IsTrained");
                gvMain.Columns.Add("AggressionLevel", "AggressionLevel");
                gvMain.Columns.Add("IsIndoor", "IsIndoor");
            }
            else if (typeof(T) == typeof(Cat))
            {
                gvMain.Columns.Add("IsDeclawed", "IsDeclawed");
                gvMain.Columns.Add("IsIndoor", "IsIndoor");
            }
            else if (typeof(T) == typeof(Goldfish))
            {
                gvMain.Columns.Add("IsSeaWater", "IsSeaWater");
                gvMain.Columns.Add("RecommendedTankVolume", "RecommendedTankVolume");
                gvMain.Columns.Add("TankSize", "TankSize");
            }
            else if (typeof(T) == typeof(Hamster))
            {
                gvMain.Columns.Add("CageSize", "CageSize");
                gvMain.Columns.Add("WheelSize", "WheelSize");
                gvMain.Columns.Add("IsNocturnal", "IsNocturnal");
                gvMain.Columns.Add("HasWheel", "HasWheel");
            }

            foreach (var pet in pets)
            {
                var values = new List<object>
                {
                    pet.Name,
                    pet.Age,
                    pet.Weight,
                    pet.Breed,
                    pet.Owner != null ? $"{pet.Owner.FirstName} {pet.Owner.LastName}" : ""
                };

                if (pet is Dog dog)
                {
                    values.Add(dog.IsTrained);
                    values.Add(dog.AggressionLevel);
                    values.Add(dog.IsIndoor);
                }
                else if (pet is Cat cat)
                {
                    values.Add(cat.IsDeclawed);
                    values.Add(cat.IsIndoor);
                }
                else if (pet is Goldfish goldfish)
                {
                    values.Add(goldfish.IsSeaWater);
                    values.Add(goldfish.RecommendedTankVolume);
                    values.Add(goldfish.TankSize);
                }
                else if (pet is Hamster hamster)
                {
                    values.Add(hamster.CageSize);
                    values.Add(hamster.WheelSize);
                    values.Add(hamster.IsNocturnal);
                    values.Add(hamster.HasWheel);
                }

                gvMain.Rows.Add(values.ToArray());
            }
        }

        private void ShowPeopleOfType<T>(string title, IEnumerable<T> people) where T : Person
        {
            gvMain.Rows.Clear();
            gvMain.Columns.Clear();

            gvMain.Columns.Add("FirstName", "First Name");
            gvMain.Columns.Add("LastName", "Last Name");
            gvMain.Columns.Add("BirthDay", "Birth Day");

            if (typeof(T) == typeof(Owner))
            {
                gvMain.Columns.Add("TrustedOwners", "Trusted Owners");
            }
            else if (typeof(T) == typeof(Vet))
            {
                gvMain.Columns.Add("CertifiedToWorkWith", "Certified To Work With");
                gvMain.Columns.Add("CertifiedToDo", "Certified To Do");
                gvMain.Columns.Add("EmploymentDate", "Employment Date");
            }

            foreach (var person in people)
            {
                var values = new List<object>
                {
                    person.FirstName,
                    person.LastName,
                    person.BirthDay.ToShortDateString()
                };

                if (person is Owner owner)
                {
                    values.Add(owner.TrustedOwners != null
                        ? string.Join(", ", owner.TrustedOwners.Select(o => o.FirstName + " " + o.LastName))
                        : "");
                }
                else if (person is Vet vet)
                {
                    values.Add(
                        vet.CertifiedToWorkWith != null
                            ? string.Join(", ", vet.CertifiedToWorkWith.Select(t => t.Name))
                            : ""
                    );
                    values.Add(
                        vet.CertifiedToDo != null
                            ? string.Join(", ", vet.CertifiedToDo.Select(t => t.Name))
                            : ""
                    );
                    values.Add(vet.EmploymentDate.ToShortDateString());
                }

                gvMain.Rows.Add(values.ToArray());
            }

        }

        private void GenerateData() 
        {
            var rnd = new Random();
            
            // Власники
            var owner1 = new Owner("Марічка", "Байрактарівна", new DateTime(1980, 5, 12));
            var owner2 = new Owner("Перемогослав", "Незламенко", new DateTime(1975, 3, 22));
            personManager.Create(owner1);
            personManager.Create(owner2);
            
            // Ветеринари
            var vet1 = new Vet(
                "Григорій", "Чорновіл", new DateTime(1970, 1, 1),
                new List<Type> { typeof(Dog), typeof(Cat) },
                new List<Type> { typeof(CheckUpTreatment), typeof(MedicalTreatment) },
                new DateTime(2000, 1, 1)
            );
            var vet2 = new Vet(
                "Олена", "Світлодай", new DateTime(1985, 2, 2),
                new List<Type> { typeof(Goldfish), typeof(Hamster) },
                new List<Type> { typeof(PreventiveTreatment), typeof(SurgicalTreatment) },
                new DateTime(2010, 2, 2)
            );
            personManager.Create(vet1);
            personManager.Create(vet2);
            
            // Тварини
            var dog = new Dog("Бім", 5, 20, "Лабрадор", owner1, true, 2, true);
            var cat = new Cat("Вусик", 3, 5, "Сіамський", owner2, false, true);
            var goldfish = new Goldfish("Золотко", 1, 0, "Комета", owner1, false, 10f, 5);
            var hamster = new Hamster("Гризунчик", 2, 1, "Сирійський", owner2, "Маленька", "Середня", true, true);
            petManager.Create(dog);
            petManager.Create(cat);
            petManager.Create(goldfish);
            petManager.Create(hamster);
            
            // Лікування
            var treatment1 = new CheckUpTreatment(dog, vet1, "Огляд", "Плановий огляд");
            var treatment2 = new MedicalTreatment(cat, vet1, "Медичне", "Антибіотики", 100f, 7);
            var treatment3 = new PreventiveTreatment(goldfish, vet2, "Профілактика", "Вакцинація", DateTime.Today.AddMonths(6));
            var treatment4 = new SurgicalTreatment(hamster, vet2, "Хірургія", "Стерилізація", true);
            treatmentManager.Create(treatment1);
            treatmentManager.Create(treatment2);
            treatmentManager.Create(treatment3);
            treatmentManager.Create(treatment4);
            
            // Записи
            var appt1 = new Appointment(DateTime.Today.AddDays(-1), dog, "Щорічний огляд", treatment1);
            var appt2 = new Appointment(DateTime.Today, cat, "Візит через хворобу", treatment2);
            var appt3 = new Appointment(DateTime.Today.AddDays(2), goldfish, "Вакцинація", treatment3);
            var appt4 = new Appointment(DateTime.Today.AddDays(3), hamster, "Операція", treatment4);
            appointmentManager.Create(appt1);
            appointmentManager.Create(appt2);
            appointmentManager.Create(appt3);
            appointmentManager.Create(appt4);
        }

        private void PopulatePetComboBoxes(PetManager petManager)
        {
            var pets = petManager?.GetAll()?.ToList() ?? new List<Pet>();

            var petDisplayList = pets
                .Select(pet => $"{pet.Name} ({pet.Breed})")
                .ToArray();

            cbPetPet.Items.Clear();
            cbPetPet.Items.AddRange(petDisplayList);

            cbPetAppointment.Items.Clear();
            cbPetAppointment.Items.AddRange(petDisplayList);

            cbPetTreatment.Items.Clear();
            cbPetTreatment.Items.AddRange(petDisplayList);
        }

        private void PopulatePersonAndVetTreatmentComboBoxes(PersonManager personManager, TreatmentManager treatmentManager)
        {
            var people = personManager?.GetAll()?.ToList() ?? new List<Person>();
            cbPersonPerson.Items.Clear();
            cbPersonPerson.Items.AddRange(
                people.Select(p => $"{p.FirstName} {p.LastName}").ToArray()
            );

            var treatments = treatmentManager?.GetAll()?.ToList() ?? new List<Treatment>();
            cbVetTreatment.Items.Clear();
            cbVetTreatment.Items.AddRange(
                treatments.Select(t =>
                    $"{t.Description} [{(t.Vet != null ? t.Vet.FirstName + " " + t.Vet.LastName : "No Vet")}]"
                ).ToArray()
            );
        }

        private void PopulateTreatmentDescriptionAndVetComboBoxes(TreatmentManager treatmentManager)
        {
            var treatments = treatmentManager?.GetAll()?.ToList() ?? new List<Treatment>();
            cbDescriptionTreatment.Items.Clear();
            cbDescriptionTreatment.Items.AddRange(
                treatments
                    .Select(t => t.Description)
                    .Where(desc => !string.IsNullOrWhiteSpace(desc))
                    .Distinct()
                    .ToArray()
            );

            cbTreatmentAppointment.Items.Clear();
            cbTreatmentAppointment.Items.AddRange(
                treatments
                    .Where(t => t.Vet != null)
                    .Select(t => $"{t.Vet.FirstName} {t.Vet.LastName}")
                    .Distinct()
                    .ToArray()
            );
        }

        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            if (cbPetPet.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть тварину для видалення.", "Потрібно вибрати", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selected = cbPetPet.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selected))
            {
                MessageBox.Show("Невірний вибір тварини.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var name = selected.Split('(')[0].Trim();
            var pet = petManager.Get(p => p.Name == name);
            if (pet == null)
            {
                MessageBox.Show("Тварину не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            petManager.Delete(pet);
            MessageBox.Show($"Тварину '{pet.Name}' видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulatePetComboBoxes(petManager);
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (cbPersonPerson.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть особу для видалення.", "Потрібно вибрати", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selected = cbPersonPerson.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selected))
            {
                MessageBox.Show("Невірний вибір особи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var parts = selected.Split(' ');
            if (parts.Length < 2)
            {
                MessageBox.Show("Невірний формат імені особи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var firstName = parts[0];
            var lastName = string.Join(" ", parts.Skip(1));
            var person = personManager.Get(p => p.FirstName == firstName && p.LastName == lastName);
            if (person == null)
            {
                MessageBox.Show("Особу не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            personManager.Delete(person);
            MessageBox.Show($"Особу '{firstName} {lastName}' видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulatePersonAndVetTreatmentComboBoxes(personManager, treatmentManager);
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (cbPetAppointment.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть тварину для видалення запису.", "Потрібно вибрати", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selected = cbPetAppointment.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selected))
            {
                MessageBox.Show("Невірний вибір тварини.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var name = selected.Split('(')[0].Trim();
            var pet = petManager.Get(p => p.Name == name);
            if (pet == null)
            {
                MessageBox.Show("Тварину не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var appt = appointmentManager.GetAll().Where(a => a.Pet == pet).OrderByDescending(a => a.Date).FirstOrDefault();
            if (appt == null)
            {
                MessageBox.Show("Не знайдено запису для цієї тварини.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            appointmentManager.Delete(appt);
            MessageBox.Show($"Запис для тварини '{pet.Name}' видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteTreatment_Click(object sender, EventArgs e)
        {
            if (cbDescriptionTreatment.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть опис лікування для видалення.", "Потрібно вибрати", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var desc = cbDescriptionTreatment.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(desc))
            {
                MessageBox.Show("Невірний опис лікування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var treatment = treatmentManager.Get(t => t.Description == desc);
            if (treatment == null)
            {
                MessageBox.Show("Лікування не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            treatmentManager.Delete(treatment);
            MessageBox.Show($"Лікування '{desc}' видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateTreatmentDescriptionAndVetComboBoxes(treatmentManager);
        }
    }
}
