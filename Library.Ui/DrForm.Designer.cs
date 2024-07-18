namespace Library.Ui
{
    partial class DrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nationalCodeLbl = new Label();
            groupBox1 = new GroupBox();
            searchByNationalCode = new Button();
            nationalCodeTxt2 = new TextBox();
            timeLbl = new Label();
            groupBox2 = new GroupBox();
            expireDateTxt = new Label();
            nationalCodeTxt = new Label();
            insuranceType = new Label();
            fatherNameTxt = new Label();
            familyTxt = new Label();
            nameTxt = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageMedicine = new TabPage();
            dataGridViewMedicine = new DataGridView();
            addMedicnebtnToGw = new Button();
            comboMedicine = new ComboBox();
            addMedicineBtn = new Button();
            tabPageRadiology = new TabPage();
            dataGridViewRadiology = new DataGridView();
            addRadiologyToGv = new Button();
            comboRadiology = new ComboBox();
            addRadiologyBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicine).BeginInit();
            tabPageRadiology.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRadiology).BeginInit();
            SuspendLayout();
            // 
            // nationalCodeLbl
            // 
            nationalCodeLbl.AutoSize = true;
            nationalCodeLbl.Location = new Point(638, 33);
            nationalCodeLbl.Name = "nationalCodeLbl";
            nationalCodeLbl.Size = new Size(67, 20);
            nationalCodeLbl.TabIndex = 0;
            nationalCodeLbl.Text = ": کد ملی ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchByNationalCode);
            groupBox1.Controls.Add(nationalCodeTxt2);
            groupBox1.Controls.Add(nationalCodeLbl);
            groupBox1.Location = new Point(36, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 72);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // searchByNationalCode
            // 
            searchByNationalCode.Location = new Point(24, 29);
            searchByNationalCode.Name = "searchByNationalCode";
            searchByNationalCode.Size = new Size(94, 29);
            searchByNationalCode.TabIndex = 2;
            searchByNationalCode.Text = "جست و جو";
            searchByNationalCode.UseVisualStyleBackColor = true;
            searchByNationalCode.Click += searchByNationalCode_Click;
            // 
            // nationalCodeTxt2
            // 
            nationalCodeTxt2.Location = new Point(388, 28);
            nationalCodeTxt2.Name = "nationalCodeTxt2";
            nationalCodeTxt2.Size = new Size(201, 27);
            nationalCodeTxt2.TabIndex = 1;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Location = new Point(36, 13);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(0, 20);
            timeLbl.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(expireDateTxt);
            groupBox2.Controls.Add(nationalCodeTxt);
            groupBox2.Controls.Add(insuranceType);
            groupBox2.Controls.Add(fatherNameTxt);
            groupBox2.Controls.Add(familyTxt);
            groupBox2.Controls.Add(nameTxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(36, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 173);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // expireDateTxt
            // 
            expireDateTxt.AutoSize = true;
            expireDateTxt.Location = new Point(283, 122);
            expireDateTxt.Name = "expireDateTxt";
            expireDateTxt.RightToLeft = RightToLeft.Yes;
            expireDateTxt.Size = new Size(0, 20);
            expireDateTxt.TabIndex = 11;
            // 
            // nationalCodeTxt
            // 
            nationalCodeTxt.AutoSize = true;
            nationalCodeTxt.Location = new Point(283, 76);
            nationalCodeTxt.Name = "nationalCodeTxt";
            nationalCodeTxt.RightToLeft = RightToLeft.Yes;
            nationalCodeTxt.Size = new Size(0, 20);
            nationalCodeTxt.TabIndex = 10;
            // 
            // insuranceType
            // 
            insuranceType.AutoSize = true;
            insuranceType.Location = new Point(536, 122);
            insuranceType.Name = "insuranceType";
            insuranceType.RightToLeft = RightToLeft.Yes;
            insuranceType.Size = new Size(0, 20);
            insuranceType.TabIndex = 9;
            // 
            // fatherNameTxt
            // 
            fatherNameTxt.AutoSize = true;
            fatherNameTxt.Location = new Point(536, 80);
            fatherNameTxt.Name = "fatherNameTxt";
            fatherNameTxt.RightToLeft = RightToLeft.Yes;
            fatherNameTxt.Size = new Size(0, 20);
            fatherNameTxt.TabIndex = 8;
            // 
            // familyTxt
            // 
            familyTxt.AutoSize = true;
            familyTxt.Location = new Point(283, 42);
            familyTxt.Name = "familyTxt";
            familyTxt.RightToLeft = RightToLeft.Yes;
            familyTxt.Size = new Size(0, 20);
            familyTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            nameTxt.AutoSize = true;
            nameTxt.Location = new Point(536, 42);
            nameTxt.Name = "nameTxt";
            nameTxt.RightToLeft = RightToLeft.Yes;
            nameTxt.Size = new Size(0, 20);
            nameTxt.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 122);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = ": اعتبار";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 122);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = ": نوع بیمه";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 80);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = ": کد ملی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 80);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = ": نام پدر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 38);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = ": نام خانوادگی";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(638, 38);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = ": نام";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageMedicine);
            tabControl1.Controls.Add(tabPageRadiology);
            tabControl1.Location = new Point(36, 293);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(723, 293);
            tabControl1.TabIndex = 4;
            // 
            // tabPageMedicine
            // 
            tabPageMedicine.Controls.Add(dataGridViewMedicine);
            tabPageMedicine.Controls.Add(addMedicnebtnToGw);
            tabPageMedicine.Controls.Add(comboMedicine);
            tabPageMedicine.Controls.Add(addMedicineBtn);
            tabPageMedicine.Location = new Point(4, 29);
            tabPageMedicine.Name = "tabPageMedicine";
            tabPageMedicine.Padding = new Padding(3);
            tabPageMedicine.RightToLeft = RightToLeft.No;
            tabPageMedicine.Size = new Size(715, 260);
            tabPageMedicine.TabIndex = 0;
            tabPageMedicine.Text = "دارو";
            tabPageMedicine.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedicine
            // 
            dataGridViewMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicine.Location = new Point(20, 60);
            dataGridViewMedicine.Name = "dataGridViewMedicine";
            dataGridViewMedicine.RowHeadersWidth = 51;
            dataGridViewMedicine.RowTemplate.Height = 29;
            dataGridViewMedicine.Size = new Size(681, 152);
            dataGridViewMedicine.TabIndex = 9;
            // 
            // addMedicnebtnToGw
            // 
            addMedicnebtnToGw.Location = new Point(20, 25);
            addMedicnebtnToGw.Name = "addMedicnebtnToGw";
            addMedicnebtnToGw.Size = new Size(94, 29);
            addMedicnebtnToGw.TabIndex = 8;
            addMedicnebtnToGw.Text = "Add";
            addMedicnebtnToGw.UseVisualStyleBackColor = true;
            addMedicnebtnToGw.Click += addMedicnebtnToGw_Click;
            // 
            // comboMedicine
            // 
            comboMedicine.FormattingEnabled = true;
            comboMedicine.Location = new Point(130, 26);
            comboMedicine.Name = "comboMedicine";
            comboMedicine.Size = new Size(571, 28);
            comboMedicine.TabIndex = 6;
            // 
            // addMedicineBtn
            // 
            addMedicineBtn.Location = new Point(615, 225);
            addMedicineBtn.Name = "addMedicineBtn";
            addMedicineBtn.Size = new Size(94, 29);
            addMedicineBtn.TabIndex = 5;
            addMedicineBtn.Text = "ثبت نسخه";
            addMedicineBtn.UseVisualStyleBackColor = true;
            addMedicineBtn.Click += addMedicineBtn_Click;
            // 
            // tabPageRadiology
            // 
            tabPageRadiology.Controls.Add(dataGridViewRadiology);
            tabPageRadiology.Controls.Add(addRadiologyToGv);
            tabPageRadiology.Controls.Add(comboRadiology);
            tabPageRadiology.Controls.Add(addRadiologyBtn);
            tabPageRadiology.Location = new Point(4, 29);
            tabPageRadiology.Name = "tabPageRadiology";
            tabPageRadiology.Padding = new Padding(3);
            tabPageRadiology.Size = new Size(715, 260);
            tabPageRadiology.TabIndex = 1;
            tabPageRadiology.Text = "رادیولوژی";
            tabPageRadiology.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRadiology
            // 
            dataGridViewRadiology.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRadiology.Location = new Point(13, 51);
            dataGridViewRadiology.Name = "dataGridViewRadiology";
            dataGridViewRadiology.RowHeadersWidth = 51;
            dataGridViewRadiology.RowTemplate.Height = 29;
            dataGridViewRadiology.Size = new Size(681, 152);
            dataGridViewRadiology.TabIndex = 13;
            // 
            // addRadiologyToGv
            // 
            addRadiologyToGv.Location = new Point(13, 16);
            addRadiologyToGv.Name = "addRadiologyToGv";
            addRadiologyToGv.Size = new Size(94, 29);
            addRadiologyToGv.TabIndex = 12;
            addRadiologyToGv.Text = "Add";
            addRadiologyToGv.UseVisualStyleBackColor = true;
            addRadiologyToGv.Click += addRadiologyToGv_Click;
            // 
            // comboRadiology
            // 
            comboRadiology.FormattingEnabled = true;
            comboRadiology.Location = new Point(123, 17);
            comboRadiology.Name = "comboRadiology";
            comboRadiology.Size = new Size(571, 28);
            comboRadiology.TabIndex = 11;
            // 
            // addRadiologyBtn
            // 
            addRadiologyBtn.Location = new Point(600, 225);
            addRadiologyBtn.Name = "addRadiologyBtn";
            addRadiologyBtn.Size = new Size(94, 29);
            addRadiologyBtn.TabIndex = 10;
            addRadiologyBtn.Text = "ثبت نسخه";
            addRadiologyBtn.UseVisualStyleBackColor = true;
            addRadiologyBtn.Click += addRadiologyBtn_Click_1;
            // 
            // DrForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(timeLbl);
            Controls.Add(groupBox1);
            Name = "DrForm";
            Text = "DrForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageMedicine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicine).EndInit();
            tabPageRadiology.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRadiology).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nationalCodeLbl;
        private GroupBox groupBox1;
        private Label timeLbl;
        private Button searchByNationalCode;
        private TextBox nationalCodeTxt2;
        private GroupBox groupBox2;
        private Label expireDateTxt;
        private Label nationalCodeTxt;
        private Label insuranceType;
        private Label fatherNameTxt;
        private Label familyTxt;
        private Label nameTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageMedicine;
        private TabPage tabPageRadiology;
        private Button addMedicineBtn;
        private Button button2;
        private ComboBox comboMedicine;
        private Button addMedicnebtnToGw;
        private DataGridView dataGridViewMedicine;
        private DataGridView dataGridViewRadiology;
        private Button addRadiologyToGv;
        private ComboBox comboRadiology;
        private Button addRadiologyBtn;
    }
}