namespace ClinicPatientAccounting;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtLogin;
    private TextBox txtPassword;
    private Button btnLogin;
    private Button btnRegister;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        txtLogin = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        btnRegister = new Button();
        SuspendLayout();
        txtLogin.Location = new Point(30, 30);
        txtLogin.PlaceholderText = "Логин";
        txtLogin.Size = new Size(220, 23);
        txtPassword.Location = new Point(30, 70);
        txtPassword.PlaceholderText = "Пароль";
        txtPassword.UseSystemPasswordChar = true;
        txtPassword.Size = new Size(220, 23);
        btnLogin.Location = new Point(30, 110);
        btnLogin.Text = "Войти";
        btnLogin.Click += btnLogin_Click;
        btnRegister.Location = new Point(130, 110);
        btnRegister.Text = "Регистрация";
        btnRegister.Click += btnRegister_Click;
        ClientSize = new Size(290, 170);
        Controls.AddRange(new Control[] { txtLogin, txtPassword, btnLogin, btnRegister });
        Text = "Вход";
        ResumeLayout(false);
        PerformLayout();
    }
}
