using ClinicPatientAccounting.Services;

namespace ClinicPatientAccounting;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
        LoadTables();
    }

    private void LoadTables()
    {
        gridPatients.DataSource = null;
        gridAppointments.DataSource = null;
        gridPatients.DataSource = AppContext.Db.Patients.Select(p => new { p.Id, p.FullName, p.Phone, p.BirthDate }).ToList();
        gridAppointments.DataSource = AppContext.Db.Appointments.Select(a => new { a.Id, a.PatientId, a.DoctorId, a.StartAt, Services = string.Join(",", a.ServiceIds) }).ToList();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadTables();

    private void btnReport_Click(object sender, EventArgs e)
    {
        using var f = new ServicesReportForm();
        f.ShowDialog();
    }
}
