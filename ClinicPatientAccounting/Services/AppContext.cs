namespace ClinicPatientAccounting.Services;

public static class AppContext
{
    public static DatabaseStub Db { get; } = new();
}
