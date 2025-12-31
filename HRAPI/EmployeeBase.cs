using HRAPI;

public class EmployeeBase : IEmpolye
{
    public int Id { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public virtual decimal Salary { get; set; }
}

