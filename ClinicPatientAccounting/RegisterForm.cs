using ClinicPatientAccounting.Models;
using ClinicPatientAccounting.Services;

namespace ClinicPatientAccounting;

public partial class RegisterForm : Form
{
    public RegisterForm() => InitializeComponent();

    private void btnSave_Click(object sender, EventArgs e)
    {
        var patient = new Patient
        {
            Id = AppContext.Db.Patients.Count + 1,
            FullName = txtName.Text,
            BirthDate = dtBirth.Value.Date,
            Phone = txtPhone.Text,
            PassportNumber = txtPassport.Text
        };
        AppContext.Db.Patients.Add(patient);
        AppContext.Db.Users.Add(new AppUser
        {
            Id = AppContext.Db.Users.Count + 1,
            Username = txtUsername.Text,
            Password = txtUserPassword.Text,
            Role = UserRole.Patient,
            PatientId = patient.Id
        });
        MessageBox.Show("Регистрация завершена");
        Close();
    }
}
