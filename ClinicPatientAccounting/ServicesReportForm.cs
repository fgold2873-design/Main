using ClinicPatientAccounting.Services;

namespace ClinicPatientAccounting;

public partial class ServicesReportForm : Form
{
    public ServicesReportForm()
    {
        InitializeComponent();
        LoadReport();
    }

    private void LoadReport()
    {
        var query = from a in AppContext.Db.Appointments
                    from sid in a.ServiceIds
                    join s in AppContext.Db.Services on sid equals s.Id
                    group s by new { s.Id, s.Name } into g
                    select new { g.Key.Name, Count = g.Count(), Revenue = g.Sum(x => x.Price) };

        gridReport.DataSource = query.ToList();
    }
}
