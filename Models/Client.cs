using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace BlazorApp2.Models
{
    public class Client
    {
        public Guid ClientID { get; set; }
        public byte[] Portrait { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public EGender Gender { get; set; }
        public string SName { get; set; }
        public string SSurname { get; set; }
        public DateTime SDOB { get; set; }
        public EGender SGender { get; set; }

        public Client(Guid clientID, byte[] portrait, string name, string surname, DateTime dob, EGender gender, string sName, string sSurname, DateTime sDOB, EGender sGender)
        {
            ClientID = clientID;
            Portrait = portrait;
            Name = name;
            Surname = surname;
            DOB = dob;
            Gender = gender;
            SName = sName;
            SSurname = sSurname;
            SDOB = sDOB;
            SGender = sGender;
        }

        public enum EGender
        {
            Male,
            Female,
            Other
        }
    }
}
