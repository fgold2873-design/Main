namespace ClinicPatientAccounting;
partial class ServicesReportForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView gridReport;
    protected override void Dispose(bool disposing){if(disposing&&(components!=null))components.Dispose();base.Dispose(disposing);}    
    private void InitializeComponent()
    {
        gridReport = new DataGridView { Location = new Point(20, 20), Size = new Size(520, 250), ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
        ClientSize = new Size(565, 295);
        Controls.Add(gridReport);
        Text = "Отчет по услугам";
    }
}
