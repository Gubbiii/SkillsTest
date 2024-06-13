using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Dog
    {
        private int _Id = 1;
        private static int dogCounter = 1;
        private string _name;
        private string _race;
        private int _yearOfBirth;
        


        public Dog(string Name, string Race, int YearOfBirth) 
        { 
            _name = Name;
            _race = Race;
            _yearOfBirth = YearOfBirth;
            Id = dogCounter;
            dogCounter++;
           

        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Race
        {
            get { return _race; }
            private set { _race = value; }
        }

        //enum Race
        //{
        //    Bordercollie,
        //    AustralianSheperd,
        //    Rottweiler
        //}

        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            private set { _yearOfBirth = value; }
        }

        public bool ValidateDog()
        {

            if (string.IsNullOrEmpty(Race))
            {
                throw new Exception("You need to write a race!");

            }
            else if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("You need to write a name!");

            }
            else if (YearOfBirth <= 0)
            {
                throw new Exception("You need to write a year of birth!!");
            }
            else if (YearOfBirth <= 2014)
            {
                throw new Exception("Your dog can't be older than 10!");
            }
            else
            {
                Console.WriteLine("The dog meet all the requirements!");
                return true;
            }
            return false;

        }

        public int Id { get; set; }

        public override string ToString()
        {
            return $"\nDog name: {Name}, Race: {Race}, Year Of Birth: {YearOfBirth}, ID: {Id}";
        }
    }
}
