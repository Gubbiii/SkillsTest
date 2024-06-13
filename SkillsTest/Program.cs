namespace SkillsTest
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Bella", "Hyrdehund", 2018);
            Dog dog2 = new Dog("Bella", "Hyrdehund", 2009); //you need to outcomment this object in order for the program to work, as it will break, because of an exception in "dog" class, because of the dog age (userstory 2)

            Member member1 = null;

            try
            {
                member1 = new Member("Mads", "Madsvej 1", "+4512345678", "mads123@live.dk", 2000, 2, 1);
            }
            catch (WrongValidationCriteriaException e)
            {
                Console.WriteLine("Your're missing 1 or more validation criteria!" + e.Message);
            }

            Member member2 = new Member($"Lars", "Balladevej 11", "+4512345678", "larsballade@gmail.com", 1955, 2, 24);
            Member member3 = new Member($"Mathias", "Hanekamvej 4", "+4512345678", "mathiashanekam@gmail.com", 2010, 1, 8);
            Console.WriteLine(dog1);

            Console.WriteLine(member1);
            Console.WriteLine(member2);
            Console.WriteLine(member3);

            Console.WriteLine(member1.ValidateMember());
            Console.WriteLine(member2.ValidateMember());
            Console.WriteLine(member3.ValidateMember());

            Console.WriteLine(dog1.ValidateDog());
            Console.WriteLine(dog2.ValidateDog());

        }
    }
}
