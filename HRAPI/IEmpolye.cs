using System;
using System.Collections.Generic;
using System.Text;

namespace HRAPI
{
    public interface IEmpolye
    {
        int Id { get; set; }
        string FirstName { get; set; }
        String LastName { get; set; }   
        decimal Salary { get; set; }

    }
}
