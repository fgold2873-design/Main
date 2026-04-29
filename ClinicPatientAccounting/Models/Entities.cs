namespace ClinicPatientAccounting.Models;

public enum UserRole
{
    Patient,
    Admin
}

public class AppUser
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; // Demo only
    public UserRole Role { get; set; }
    public int? PatientId { get; set; }
}

public class Patient
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string PassportNumber { get; set; } = string.Empty;
}

public class Doctor
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
}

public class MedicalService
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

public class Diagnosis
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class Appointment
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime StartAt { get; set; }
    public List<int> ServiceIds { get; set; } = new();
    public int? DiagnosisId { get; set; }
}
