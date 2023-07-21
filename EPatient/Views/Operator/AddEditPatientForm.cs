using System;
using System.ComponentModel;
using System.Windows.Forms;
using EPatient.Models;

namespace EPatient.Views.Operator
{
    public partial class AddEditPatientForm : MetroFramework.Forms.MetroForm
    {
        public Patient PatientInfo => patientBindingSource.Current as Patient;

        public AddEditPatientForm(Patient obj)
        {
            InitializeComponent();
            patientBindingSource.DataSource = obj;
        }

        private void AddEditPatientForm_Load(object sender, EventArgs e)
        {
            if (checkBoxGender.CheckState == CheckState.Checked)
                checkBoxGender.Text = "Муж";
            else if (checkBoxGender.CheckState == CheckState.Unchecked)
                checkBoxGender.Text = "Жен";
            else
                checkBoxGender.Text = "??";
        }

        private void checkBoxGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxGender.CheckState == CheckState.Checked)
                checkBoxGender.Text = "Муж";
            else if (checkBoxGender.CheckState == CheckState.Unchecked)
                checkBoxGender.Text = "Жен";
            else
                checkBoxGender.Text = "??";
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || textName.Text.Length > 255)
            {
                e.Cancel = true;
                textName.Focus();
                errorProvider.SetError(textName, "Пожалуйста, выберите имя пациента (не более 255 символов).");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textName, null);
            }
        }

        private void textSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textSurname.Text) || textSurname.Text.Length > 255)
            {
                e.Cancel = true;
                textSurname.Focus();
                errorProvider.SetError(textSurname, "Пожалуйста, введите фамилию пациента (максимум 255 символов).");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textSurname, null);
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textEmail.Text) || textEmail.Text.Length > 50)
            {
                e.Cancel = true;
                textEmail.Focus();
                errorProvider.SetError(textEmail, "Пожалуйста, введите адрес электронной почты пациента (не более 50 символов).");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textEmail, null);
            }
        }

        private void dateBirthday_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateBirthday.Text))
            {
                e.Cancel = true;
                dateBirthday.Focus();
                errorProvider.SetError(dateBirthday, "Пожалуйста, укажите день рождения пациента");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dateBirthday, null);
            }
        }

        private void textPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textPhone.Text) || textPhone.Text.Length > 255)
            {
                e.Cancel = true;
                textPhone.Focus();
                errorProvider.SetError(textPhone, "Пожалуйста, введите номер телефона пациента (максимум 255 символов).");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textPhone, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                patientBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
