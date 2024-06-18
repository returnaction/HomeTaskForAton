namespace HomeTaskForAton.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; }
        public DateTime DOB { get; set; }
        public long INN { get; set; }
        public string ResponsiblePerson { get; set; }

        public Status Status { get; set; } = Status.Authorized;

    }

    public enum Status
    {
        Unauthorized,
        Authorized,
        Canceled,
        Closed
    }
}
