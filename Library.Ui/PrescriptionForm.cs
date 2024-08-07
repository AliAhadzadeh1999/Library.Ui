using Library.Application.Contract.DTOs;
using Library.Application.Contract.DTOs.Prescriptions;
using Library.Application.Contract.IServices;
using Library.Application.Services;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing;

namespace Library.Ui
{
    public partial class PrescriptionForm : Form
    {
        private readonly IPersonService personService;
        private readonly IInsuranceService insuranceService;
        private readonly IMedicineService medicineService;
        private readonly IRadiologyTypeService radiologyTypeService;
        private readonly IPrescriptionService prescriptionService;
        private readonly IRadiologyService radiologyService;
        private Person? person;
        private List<Medicine>? selectedMedicines = new();


        public PrescriptionForm()
        {
            personService = new PersonService();
            insuranceService = new InsuranceService();
            medicineService = new MedicineService();
            radiologyTypeService = new RadiologyTypeService();
            prescriptionService = new PrescriptionService();
            radiologyService = new RadiologyService();
            InitializeComponent();
            FillComboBoxMedicine();
            txtNationalCode.Text = "0312020244";
        }

        private void FillInformationGB()
        {
            InsuranceInfo(PersonInfo());
            FillComboBoxRadiology();
        }

        private void FillComboBoxMedicine()
        {
            var medicines = medicineService.GetAll();
            comboMedicine.DataSource = medicines;
            comboMedicine.ValueMember = "Id";
            comboMedicine.DisplayMember = "Name";
        }
        private void FillComboBoxRadiology()
        {
            var radiologyNames = radiologyTypeService.GetAll();
            foreach (var item in radiologyNames)
            {
                comboRadiology.Items.Add(item.Name);
            }
        }

        private void InsuranceInfo(Person personInfo)
        {
            var info2 = insuranceService.GetById(personInfo.Id);
            expireDateTxt.Text = info2.ExpireDate;
            insuranceType.Text = info2.InsuranceType?.Name;
        }

        private Person PersonInfo()
        {
            person = personService.GetById(txtNationalCode.Text);
            if (person is not null)
            {
                nameTxt.Text = person.Name;
                familyTxt.Text = person.Family;
                fatherNameTxt.Text = person.FatherName;
                lblNationalCode.Text = person.NationalId?.ToString();
            }

            return person;
        }

        private void SearchByNationalCode(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalCode.Text))
            {
                MessageBox.Show("Error");
                return;
                //FillInformationGB();
            }
            person = PersonInfo();
            //nationalCodeTxt2.Clear();
        }
        private void addRadiologyBtn_Click(object sender, EventArgs e)
        {
            var personInfo = personService.GetById(txtNationalCode.Text);
            var listRadiologyName = radiologyService.GetKeyValues();

            var radiologyKeyValue = new List<KeyValue>();
            List<int> result = new List<int>();

            for (int i = 0; i < dataGridViewRadiology.Rows.Count; i++)
            {
                var data = (string)dataGridViewRadiology[0, i].Value;
                if (listRadiologyName.Any(x => x.Value == data))
                {
                    radiologyKeyValue.Add(listRadiologyName.FirstOrDefault(x => x.Value == data));
                }
            }

            foreach (var item in radiologyKeyValue)
            {
                result.Add(item.Key);
            }
            var x = new PrescriptionRadiologyAddDto()
            {
                DrId = 2,
                PersonId = personInfo.Id,
                Selected = result
            };
            prescriptionService.Add(x);
            dataGridViewRadiology.Rows.Clear();
        }
        private void AddRadiologyToGv_Click(object sender, EventArgs e)
        {
            var x = comboRadiology.SelectedItem;

            dataGridViewRadiology.ColumnCount = 1;
            dataGridViewRadiology.Columns[0].Name = "Radiology";

            dataGridViewRadiology.Rows.Add(x.ToString());
        }

        private void AddMedicineBtn_Click(object sender, EventArgs e)
        {
            if (person is null)
            {
                MessageBox.Show("Error");
                return;
            }

            var selectedMedicines = dataGridViewMedicine.DataSource as List<Medicine>;

            prescriptionService.Add(new PrescriptionMedicineAddDto()
            {
                DrId = 2,
                PersonId = person.Id,
                Selected = selectedMedicines.Select(x => x.Id).ToList()
            });
            dataGridViewMedicine.Rows.Clear();
            ClearGb();
        }

        private void AddMedicineToGw(object sender, EventArgs e)
        {
            var selectedItem = comboMedicine.SelectedItem as Medicine;
            if (selectedItem is not null)
            {
                selectedMedicines.Add(selectedItem);
                dataGridViewMedicine.DataSource = selectedMedicines;
                dataGridViewMedicine.Refresh();
            }
        }

        private void ClearGb()
        {
            nameTxt.Text = "";
            familyTxt.Text = "";
            fatherNameTxt.Text = "";
            lblNationalCode.Text = "";
            expireDateTxt.Text = "";
            insuranceType.Text = "";
        }


    }
}
