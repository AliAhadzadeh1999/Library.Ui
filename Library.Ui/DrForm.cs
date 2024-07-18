using Library.Infrastructure.IRepository;
using Library.Infrastructure.Repository;
using Library.Model.Models;

namespace Library.Ui
{
    public partial class DrForm : Form
    {
        private readonly IPersonRepository personRepository;
        private readonly IInsuranceRepository insuranceRepository;
        private readonly IMedicineRepository medicineRepository;
        private readonly IMedicineTypeRepository medicineTypeRepository;
        private readonly IRadiologyTypeRepositry radiologyTypeRepository;
        private readonly IRadiologyRepositry radiologyRepository;
        private readonly IPrescriptionRepository prescriptionRepository;

        public DrForm()
        {
            personRepository = new PersonRepository();
            insuranceRepository = new InsuranceRepository();
            medicineTypeRepository = new MedicineTypeRepository();
            prescriptionRepository = new PrescriptionRepository();
            medicineRepository = new MedicineRepository();
            radiologyTypeRepository = new RadiologyTypeRepositry();
            radiologyRepository = new RadiologyRepositry();
            InitializeComponent();
        }
        List<string> listMedicineNames = new List<string>();
        List<string> listRadiologyNames = new List<string>();
        private void FillInformationGB()
        {
            Person personInfo = PersonInfo();
            InsuranceInfo(personInfo);
            FillComboBoxMedicine();
            FillComboBoxRadiology();
        }

        private void FillComboBoxMedicine()
        {
            var medicineNames = medicineTypeRepository.GetAll();
            foreach (var item in medicineNames)
            {
                comboMedicine.Items.Add(item);
            }
        }
        private void FillComboBoxRadiology()
        {
            var radiologyNames = radiologyTypeRepository.GetAll();
            foreach (var item in radiologyNames)
            {
                comboRadiology.Items.Add(item);
            }
        }

        private void InsuranceInfo(Person personInfo)
        {
            var info2 = insuranceRepository.GetById(personInfo.Id);
            expireDateTxt.Text = info2.ExpireDate;
            insuranceType.Text = info2.InsuranceType?.Name;
        }

        private Person PersonInfo()
        {
            var personInfo = personRepository.GetById(nationalCodeTxt2.Text);
            nameTxt.Text = personInfo.Name;
            familyTxt.Text = personInfo.Family;
            fatherNameTxt.Text = personInfo.FatherName;
            nationalCodeTxt.Text = personInfo.NationalId?.ToString();
            return personInfo;
        }



        private void searchByNationalCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nationalCodeTxt2.Text)) //&& nationalCodeTxt2.TextLength == 10
            {
                FillInformationGB();
            }
            nationalCodeTxt2.Clear();
        }
        private void addRadiologyBtn_Click_1(object sender, EventArgs e)
        {
            var personInfo = personRepository.GetById(nationalCodeTxt2.Text);

            var x = new Prescription()
            {
                DrId = 2,
                PersonId = personInfo.Id
            };
            prescriptionRepository.Add(x);
            foreach (var item in listRadiologyNames)
            {
                var y = radiologyTypeRepository.GetByName(item);
                AddMedicineRepository(y.Id, x.Id);
            }

            dataGridViewRadiology.Rows.Clear();
            ClearGb();
        }

        private void AddRadiologyRepository(int radiologyTypeId, int prescriptionId)
        {
            radiologyRepository.Add(new Radiology { RadiologyTypeId = radiologyTypeId, PrescriptionId = prescriptionId });
        }

        private void addRadiologyToGv_Click(object sender, EventArgs e)
        {
            var x = comboRadiology.SelectedItem;

            dataGridViewRadiology.ColumnCount = 1;
            dataGridViewRadiology.Columns[0].Name = "Radiology";

            listRadiologyNames.Add(x.ToString());
            dataGridViewRadiology.Rows.Add(x.ToString());
        }

        private void addMedicineBtn_Click(object sender, EventArgs e)
        {
            var personInfo = personRepository.GetById(nationalCodeTxt2.Text);

            var x = new Prescription()
            {
                DrId = 2,
                PersonId = personInfo.Id
            };
            prescriptionRepository.Add(x);
            foreach (var item in listMedicineNames)
            {
                var y = medicineTypeRepository.GetByName(item);
                AddRadiologyRepository(y.Id, x.Id);
            }

            dataGridViewRadiology.Rows.Clear();
            ClearGb();
        }
        private void AddMedicineRepository(int medicineTypeId, int prescriptionId)
        {
            medicineRepository.Add(new Medicine { MedicineTypeId = medicineTypeId, PrescriptionId = prescriptionId });
        }
        private void addMedicnebtnToGw_Click(object sender, EventArgs e)
        {
            var x = comboMedicine.SelectedItem;

            dataGridViewMedicine.ColumnCount = 1;
            dataGridViewMedicine.Columns[0].Name = "Medicine";

            listMedicineNames.Add(x.ToString());
            dataGridViewMedicine.Rows.Add(x.ToString());
        }

        private void ClearGb()
        {
            nameTxt.Text = "";
            familyTxt.Text = "";
            fatherNameTxt.Text = "";
            nationalCodeTxt.Text = "";
            expireDateTxt.Text = "";
            insuranceType.Text = "";
        }


    }
}
