namespace ClinicPatientAccounting;

partial class RegisterForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtName, txtPhone, txtPassport, txtUsername, txtUserPassword;
    private DateTimePicker dtBirth;
    private Button btnSave;
    protected override void Dispose(bool disposing){if(disposing&&(components!=null))components.Dispose();base.Dispose(disposing);}    
    private void InitializeComponent()
    {
        txtName = new TextBox { Location = new Point(20, 20), Size = new Size(260, 23), PlaceholderText = "ФИО" };
        dtBirth = new DateTimePicker { Location = new Point(20, 55), Size = new Size(260, 23) };
        txtPhone = new TextBox { Location = new Point(20, 90), Size = new Size(260, 23), PlaceholderText = "Телефон" };
        txtPassport = new TextBox { Location = new Point(20, 125), Size = new Size(260, 23), PlaceholderText = "Паспорт" };
        txtUsername = new TextBox { Location = new Point(20, 160), Size = new Size(260, 23), PlaceholderText = "Логин" };
        txtUserPassword = new TextBox { Location = new Point(20, 195), Size = new Size(260, 23), PlaceholderText = "Пароль", UseSystemPasswordChar = true };
        btnSave = new Button { Location = new Point(20, 230), Text = "Сохранить", Size = new Size(120, 30) };
        btnSave.Click += btnSave_Click;
        ClientSize = new Size(310, 280);
        Controls.AddRange(new Control[] { txtName, dtBirth, txtPhone, txtPassport, txtUsername, txtUserPassword, btnSave });
        Text = "Регистрация пациента";
    }
}
