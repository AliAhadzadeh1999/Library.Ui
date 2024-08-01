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
        private readonly IMedicineTypeService medicineTypeService;
        private readonly IRadiologyTypeService radiologyTypeService;
        private readonly IPrescriptionService prescriptionService;
        private readonly IMedicineService medicineService;
        private readonly IRadiologyService radiologyService;
        


        public PrescriptionForm()
        {
            personService = new PersonService();
            insuranceService = new InsuranceService();
            medicineTypeService = new MedicineTypeService();
            radiologyTypeService = new RadiologyTypeService();
            prescriptionService = new PrescriptionService();
            medicineService = new MedicineService();
            radiologyService = new RadiologyService();
            InitializeComponent();
        }

        private void FillInformationGB()
        {
            InsuranceInfo(PersonInfo());
            FillComboBoxMedicine();
            FillComboBoxRadiology();
        }

        private void FillComboBoxMedicine()
        {
            var medicineNames = medicineTypeService.GetAll();
            foreach (var item in medicineNames)
            {
                comboMedicine.Items.Add(item.Name);
            }
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
            var personInfo = personService.GetById(nationalCodeTxt2.Text);
            nameTxt.Text = personInfo.Name;
            familyTxt.Text = personInfo.Family;
            fatherNameTxt.Text = personInfo.FatherName;
            nationalCodeTxt.Text = personInfo.NationalId?.ToString();
            return personInfo;
        }

        private void SearchByNationalCode(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nationalCodeTxt2.Text))
            {
                FillInformationGB();
            }
            nationalCodeTxt2.Clear();
        }
        private void addRadiologyBtn_Click(object sender, EventArgs e)
        {
            var personInfo = personService.GetById(nationalCodeTxt2.Text);
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
            var personInfo = personService.GetById(nationalCodeTxt2.Text);
            var listMedicineNames = medicineService.GetKeyValue();

            var medicineKeyValue = new List<KeyValue>();
            List<int> result = new List<int>();

            for (int i = 0; i < dataGridViewMedicine.Rows.Count; i++)
            {
                var data = (string)dataGridViewMedicine[0, i].Value;
                if (listMedicineNames.Any(x => x.Value == data))
                {
                    medicineKeyValue.Add(listMedicineNames.FirstOrDefault(x => x.Value == data));
                }

            }

            foreach (var item in medicineKeyValue)
            {
                result.Add(item.Key);
            }

            var prescription = new PrescriptionMedicineAddDto()
            {
                DrId = 2,
                PersonId = personInfo.Id,
                Selected = result
            };
            prescriptionService.Add(prescription);
            dataGridViewMedicine.Rows.Clear();
            ClearGb();
        }
        private void AddMedicineToGw(object sender, EventArgs e)
        {
            var x = comboMedicine.SelectedItem;

            dataGridViewMedicine.ColumnCount = 1;
            dataGridViewMedicine.Columns[0].Name = "Medicine";


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
