using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class PersonProcessor
    {
        public static int CreatePerson(string firstName, string lastName, string email,
            string phoneNumber, DateTime dateOfBirth, string password)
        {
            PersonModel data = new PersonModel 
            {   FirstName = firstName,
                LastName = lastName, 
                Email = email, 
                PhoneNumber = phoneNumber, 
                DateOfBirth = dateOfBirth, 
                Password = password 
            };

            string sql = @"insert into dbo.Person (FirstName, LastName, Email, PhoneNumber, DataOfBirth, Password)
                          values (@FirstName, @LastName, @Email, @PhoneNumber, @DateOfBirth, @Password";

            return SQLDataAccess.SaveData(sql, data);
        }
    }
}
