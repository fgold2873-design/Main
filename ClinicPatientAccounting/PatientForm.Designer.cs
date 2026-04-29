namespace ClinicPatientAccounting;
partial class PatientForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblName,lblPhone,lblPassportMasked;
    private DataGridView gridAppointments;
    private Button btnNewAppointment;
    protected override void Dispose(bool disposing){if(disposing&&(components!=null))components.Dispose();base.Dispose(disposing);}    
    private void InitializeComponent()
    {
        lblName = new Label { Location = new Point(20, 20), AutoSize = true };
        lblPhone = new Label { Location = new Point(20, 45), AutoSize = true };
        lblPassportMasked = new Label { Location = new Point(20, 70), AutoSize = true };
        btnNewAppointment = new Button { Location = new Point(20, 100), Size = new Size(170, 30), Text = "Записаться на прием" };
        btnNewAppointment.Click += btnNewAppointment_Click;
        gridAppointments = new DataGridView { Location = new Point(20, 145), Size = new Size(520, 220), ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
        ClientSize = new Size(570, 390);
        Controls.AddRange(new Control[] { lblName, lblPhone, lblPassportMasked, btnNewAppointment, gridAppointments });
        Text = "Кабинет пациента";
    }
}
