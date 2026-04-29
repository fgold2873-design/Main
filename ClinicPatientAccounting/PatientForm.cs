using ClinicPatientAccounting.Models;
using ClinicPatientAccounting.Services;

namespace ClinicPatientAccounting;

public partial class PatientForm : Form
{
    private readonly AppUser _user;
    public PatientForm(AppUser user)
    {
        _user = user;
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        var patient = AppContext.Db.Patients.FirstOrDefault(p => p.Id == _user.PatientId);
        if (patient == null) return;
        lblName.Text = patient.FullName;
        lblPhone.Text = patient.Phone;
        lblPassportMasked.Text = MaskPassport(patient.PassportNumber);

        var apps = from a in AppContext.Db.Appointments
                   join d in AppContext.Db.Doctors on a.DoctorId equals d.Id
                   where a.PatientId == patient.Id
                   select new { a.StartAt, Doctor = d.FullName };
        gridAppointments.DataSource = apps.ToList();
    }

    private static string MaskPassport(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length < 4) return "****";
        return new string('*', value.Length - 4) + value[^4..];
    }

    private void btnNewAppointment_Click(object sender, EventArgs e)
    {
        if (_user.PatientId == null) return;
        using var f = new NewAppointmentForm(_user.PatientId.Value);
        f.ShowDialog();
        LoadData();
    }
}
