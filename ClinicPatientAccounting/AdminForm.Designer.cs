namespace ClinicPatientAccounting;
partial class AdminForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView gridPatients, gridAppointments;
    private Button btnRefresh, btnReport;
    protected override void Dispose(bool disposing){if(disposing&&(components!=null))components.Dispose();base.Dispose(disposing);}    
    private void InitializeComponent()
    {
        gridPatients = new DataGridView { Location = new Point(20, 20), Size = new Size(740, 180), ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
        gridAppointments = new DataGridView { Location = new Point(20, 220), Size = new Size(740, 180), ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
        btnRefresh = new Button { Location = new Point(20, 415), Text = "Обновить", Size = new Size(120, 30) };
        btnReport = new Button { Location = new Point(155, 415), Text = "Отчет услуг", Size = new Size(120, 30) };
        btnRefresh.Click += btnRefresh_Click;
        btnReport.Click += btnReport_Click;
        ClientSize = new Size(790, 465);
        Controls.AddRange(new Control[] { gridPatients, gridAppointments, btnRefresh, btnReport });
        Text = "Админ-панель";
    }
}
