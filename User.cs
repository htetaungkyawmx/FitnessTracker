using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }

        public User(string username, string password, string gender, DateTime dob, int weight, int height, string phone, string address, string role)
        {
            Username = username;
            Password = password;
            Gender = gender;
            DateOfBirth = dob;
            Weight = weight;
            Height = height;
            PhoneNo = phone;
            Address = address;
            Role = role;
        }

        public User() { }
    }
}