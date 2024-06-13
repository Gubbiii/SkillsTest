using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Member
    {
        private int _Id = 1;
        private static int memberCounter = 1;
        private string _name;
        private string _adress;
        private DateTime _birthDate;
        private string _phone;
        private string _email;
        private int _yearOfBirth;
        private int _monthOfBirth;
        private int _dayOfBirth;
        public int _age;
        public int baseFee;
        
        List<Dog> dogs = new List<Dog>();


        public Member(string Name, string Adress, string Phone, string Email, int YearOfBirth, int MonthOfBirth, int DayOfBirth)
        {
            _name = Name;
            _adress = Adress;
            _phone = Phone;
            _email = Email;
            _yearOfBirth = YearOfBirth;
            _monthOfBirth = MonthOfBirth;
            _dayOfBirth = DayOfBirth;
            _age = DateTime.Now.Year - YearOfBirth;
            List<Dog> dogs = new List<Dog>();
            Id = memberCounter;
            memberCounter++;

        }

        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            private set { _yearOfBirth = value; }
        }

        public int MonthOfBirth
        {
            get { return _monthOfBirth; }
            private set { _monthOfBirth = value; }
        }

        public int DayOfBirth
        {
            get { return _dayOfBirth; }
            private set { _dayOfBirth = value; }
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            private set { _adress = value; }
        }

        public string Phone
        {
            get { return _phone; }
            private set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            private set { _email = value; }
        }
        public int Id { get; set; }

        void RegisterDog(Dog dog)
        {
            dogs.Add(dog);
        }

        void PrintDogs()
        {
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.ToString()); }
        }

        void RemoveDog(Dog dog)
        {
            dogs.Remove(dog);
        }

        public double MemberFee(double baseFee)
        {
            if (_age >= 65)
            {
                return baseFee = 500 * dogs.Count;
            }
            else
            {
                return baseFee + (500 * dogs.Count);
            }
        }

        public bool ValidateMember()
        {
            int NotOld = 18;

            if (_age < NotOld)
            {
                Console.WriteLine("You are not old enough to participate!");
                
            }
            else if(string.IsNullOrEmpty(Email))
            {
                throw new Exception("You need to write an email!");
               
            }
            else if(string.IsNullOrEmpty(Name)) 
            {
                throw new Exception("You need to write a name!");
                
            }
            else if (string.IsNullOrEmpty(Phone))
            {
                throw new Exception("You need to write a name!");
                
            }
            else if (string.IsNullOrEmpty(Adress))
            {
                throw new Exception("You need to write a name!");
                
            }
            else 
            {
                Console.WriteLine("You meet all the requirements!");
                return true;
            }
            return false;

        }




        public override string ToString()
        {
            return $"\nMember name: {Name}, Adress: {Adress}, Email: {Email}, Phone: {Phone}, Birthdate: {DayOfBirth}/{MonthOfBirth}-{YearOfBirth}, Age: {_age}, ID: {Id}";
        }

    }
}
