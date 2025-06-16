using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Models.People;
using VetClinic.Models.Pets;

namespace VetClinic
{
    public partial class CRUDPet : Form
    {
        public Type SelectedClass { get; set; }
        public PetManager PetsManager { get; set; }
        public PersonManager PersonsManager { get; set; }

        // Спільне для всіх тварин
        public string PetName { get; set; }
        public int? Age { get; set; }
        public int? Weight { get; set; }
        public string Breed { get; set; }
        public Owner owner { get; set; }

        // Унікальне для кожного класу тварин
        // Dog
        public bool? IsTrained { get; set; }
        public int? AggressionLevel { get; set; }
        public bool? IsIndoorDog { get; set; }

        // Cat
        public bool? IsDeclawed { get; set; }
        public bool? IsIndoorCat { get; set; }

        // Goldfish
        public bool? IsSeaWater { get; set; }
        public float? RecommendedTankVolume { get; set; }
        public int? TankSize { get; set; }

        // Hamster
        public string CageSize { get; set; }
        public string WheelSize { get; set; }
        public bool? IsNocturnal { get; set; }
        public bool? HasWheel { get; set; }

        public CRUDPet()
        {
            InitializeComponent();
        }

        public CRUDPet(Type selectedClass, PetManager manager, PersonManager personsManager) : this()
        {
            SelectedClass = selectedClass;
            PetsManager = manager;
            PersonsManager = personsManager;
            SetGroupBoxVisibility();
            PopulateOwnerComboBox();
        }

        private void SetGroupBoxVisibility()
        {
            gbHamster.Enabled = gbHamster.Visible = SelectedClass == typeof(Hamster);
            gbCat.Enabled = gbCat.Visible = SelectedClass == typeof(Cat);
            gbDog.Enabled = gbDog.Visible = SelectedClass == typeof(Dog);
            gbGoldFish.Enabled = gbGoldFish.Visible = SelectedClass == typeof(Goldfish);
        }

        private void PopulateOwnerComboBox()
        {
            cbOwner.Items.Clear();
            var owners = PersonsManager.GetAll().OfType<Owner>().ToList();
            foreach (var owner in owners)
            {
                cbOwner.Items.Add($"{owner.FirstName} {owner.LastName}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int age = int.TryParse(tbAge.Text, out int a) ? a : 0;
            int weight = int.TryParse(tbWeight.Text, out int w) ? w : 0;
            string breed = tbBreed.Text;

            Owner selectedOwner = null;
            if (cbOwner.SelectedItem != null)
            {
                string selectedFullName = cbOwner.SelectedItem.ToString();
                selectedOwner = PersonsManager.GetAll()
                    .OfType<Owner>()
                    .FirstOrDefault(o => $"{o.FirstName} {o.LastName}" == selectedFullName);
            }

            Pet newPet = null;

            if (SelectedClass == typeof(Hamster))
            {
                string cageSize = tbCageSize.Text;
                string wheelSize = tbWheelSize.Text;
                bool isNocturnal = chkbIsNoctumal.Checked;
                bool hasWheel = chkbHasWheel.Checked;
                newPet = new Hamster(name, age, weight, breed, selectedOwner, cageSize, wheelSize, isNocturnal, hasWheel);
            }
            else if (SelectedClass == typeof(Cat))
            {
                bool isDeclawed = chkbIsDeclawed.Checked;
                bool isIndoor = chkbIsIndoorCat.Checked;
                newPet = new Cat(name, age, weight, breed, selectedOwner, isDeclawed, isIndoor);
            }
            else if (SelectedClass == typeof(Dog))
            {
                int aggressionLevel = int.TryParse(tbAgressionLevel.Text, out int al) ? al : 0;
                bool isTrained = chkbIsTrained.Checked;
                bool isIndoor = chkbIsIndoorDog.Checked;
                newPet = new Dog(name, age, weight, breed, selectedOwner, isTrained, aggressionLevel, isIndoor);
            }
            else if (SelectedClass == typeof(Goldfish))
            {
                float recommendedTankVolume = float.TryParse(tbRecomendedTankSize.Text, out float rtv) ? rtv : 0f;
                int tankSize = int.TryParse(tbTankSize.Text, out int ts) ? ts : 0;
                bool isSeaWater = chkbIsSeaWater.Checked;
                newPet = new Goldfish(name, age, weight, breed, selectedOwner, isSeaWater, recommendedTankVolume, tankSize);
            }

            if (newPet != null)
            {
                PetsManager.Create(newPet);
                MessageBox.Show("Тварину успішно додано!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не вдалося додати тварину. Будь ласка, перевірте введені дані.");
            }
        }
    }
}
