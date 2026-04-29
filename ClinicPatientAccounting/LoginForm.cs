using ClinicPatientAccounting.Models;
using ClinicPatientAccounting.Services;

namespace ClinicPatientAccounting;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var user = AppContext.Db.Users.FirstOrDefault(u => u.Username == txtLogin.Text && u.Password == txtPassword.Text);
        if (user == null)
        {
            MessageBox.Show("Неверный логин или пароль");
            return;
        }

        Hide();
        if (user.Role == UserRole.Admin)
        {
            using var admin = new AdminForm();
            admin.ShowDialog();
        }
        else
        {
            using var patient = new PatientForm(user);
            patient.ShowDialog();
        }
        Show();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        using var f = new RegisterForm();
        f.ShowDialog();
    }
}
