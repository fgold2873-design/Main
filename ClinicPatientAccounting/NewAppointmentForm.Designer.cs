namespace ClinicPatientAccounting;
partial class NewAppointmentForm
{
    private System.ComponentModel.IContainer components = null;
    private ComboBox cbDoctor;
    private DateTimePicker dtDate, dtTime;
    private CheckedListBox clbServices;
    private MonthCalendar monthCalendar;
    private Button btnSave;
    protected override void Dispose(bool disposing){if(disposing&&(components!=null))components.Dispose();base.Dispose(disposing);}    
    private void InitializeComponent()
    {
        cbDoctor = new ComboBox { Location = new Point(20, 20), Size = new Size(270, 23), DropDownStyle = ComboBoxStyle.DropDownList };
        dtDate = new DateTimePicker { Location = new Point(20, 55), Size = new Size(270, 23) };
        dtTime = new DateTimePicker { Location = new Point(20, 90), Size = new Size(270, 23), Format = DateTimePickerFormat.Time, ShowUpDown = true };
        clbServices = new CheckedListBox { Location = new Point(20, 125), Size = new Size(270, 94) };
        monthCalendar = new MonthCalendar { Location = new Point(320, 20), MaxSelectionCount = 1 };
        monthCalendar.DateSelected += (_, e) => dtDate.Value = e.Start;
        btnSave = new Button { Location = new Point(20, 235), Size = new Size(120, 30), Text = "Сохранить" };
        btnSave.Click += btnSave_Click;
        ClientSize = new Size(570, 290);
        Controls.AddRange(new Control[] { cbDoctor, dtDate, dtTime, clbServices, monthCalendar, btnSave });
        Text = "Новый прием";
    }
}
