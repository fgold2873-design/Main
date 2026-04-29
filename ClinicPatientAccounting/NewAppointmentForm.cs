using ClinicPatientAccounting.Models;
using ClinicPatientAccounting.Services;

namespace ClinicPatientAccounting;

public partial class NewAppointmentForm : Form
{
    private readonly int _patientId;
    public NewAppointmentForm(int patientId)
    {
        _patientId = patientId;
        InitializeComponent();
        cbDoctor.DataSource = AppContext.Db.Doctors;
        cbDoctor.DisplayMember = "FullName";
        cbDoctor.ValueMember = "Id";
        clbServices.DataSource = AppContext.Db.Services;
        clbServices.DisplayMember = "Name";
        clbServices.ValueMember = "Id";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (cbDoctor.SelectedValue is not int doctorId) return;
        var serviceIds = clbServices.CheckedItems.Cast<MedicalService>().Select(s => s.Id).ToList();
        AppContext.Db.Appointments.Add(new Appointment
        {
            Id = AppContext.Db.Appointments.Count + 1,
            PatientId = _patientId,
            DoctorId = doctorId,
            StartAt = dtDate.Value.Date.Add(dtTime.Value.TimeOfDay),
            ServiceIds = serviceIds
        });
        var total = AppContext.Db.Services.Where(s => serviceIds.Contains(s.Id)).Sum(s => s.Price);
        MessageBox.Show($"Прием сохранен. Счет: {total:C}");
        Close();
    }
}
