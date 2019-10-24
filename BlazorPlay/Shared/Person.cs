using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPlay.Shared
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
