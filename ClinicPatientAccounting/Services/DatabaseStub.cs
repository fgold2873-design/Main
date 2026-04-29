using ClinicPatientAccounting.Models;

namespace ClinicPatientAccounting.Services;

/// <summary>
/// Заглушка хранилища. Замените на реальную БД (EF/Dapper/ADO.NET).
/// </summary>
public class DatabaseStub
{
    public List<AppUser> Users { get; } = new();
    public List<Patient> Patients { get; } = new();
    public List<Doctor> Doctors { get; } = new();
    public List<MedicalService> Services { get; } = new();
    public List<Diagnosis> Diagnoses { get; } = new();
    public List<Appointment> Appointments { get; } = new();

    public DatabaseStub()
    {
        Seed();
    }

    private void Seed()
    {
        Doctors.AddRange(new[]
        {
            new Doctor { Id = 1, FullName = "Иванов И.И.", Specialty = "Терапевт" },
            new Doctor { Id = 2, FullName = "Петрова А.С.", Specialty = "Кардиолог" }
        });

        Services.AddRange(new[]
        {
            new MedicalService { Id = 1, Name = "Первичный осмотр", Price = 1500 },
            new MedicalService { Id = 2, Name = "ЭКГ", Price = 900 },
            new MedicalService { Id = 3, Name = "Анализ крови", Price = 1200 }
        });

        Diagnoses.AddRange(new[]
        {
            new Diagnosis { Id = 1, Code = "J00", Description = "ОРВИ" },
            new Diagnosis { Id = 2, Code = "I10", Description = "Гипертензия" }
        });

        Users.Add(new AppUser { Id = 1, Username = "admin", Password = "admin123", Role = UserRole.Admin });
    }
}
