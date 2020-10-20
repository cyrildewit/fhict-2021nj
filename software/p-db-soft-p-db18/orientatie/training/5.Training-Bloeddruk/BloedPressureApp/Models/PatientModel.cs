using BloedPressureApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloedPressureApp
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }

        public PatientGender Gender { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
