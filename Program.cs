namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doYouWantToAddStudent;

            Console.WriteLine("Please enter Group`s Name: ");
            string groupName = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Please enter Group`s Limit: ");
            byte limitOfGroup = Convert.ToByte(Console.ReadLine());

            
            Group grooup = new Group(groupName, limitOfGroup);

            for (int i = 0; i < limitOfGroup + 1; i++)
            {
                Console.WriteLine("Do you want to add student ? yes/no ");
                string answer = Console.ReadLine();

                if (answer == "yes" && i < limitOfGroup)
                {

                    grooup.addStudents();
                }
                else if ( answer == "no" && i <= limitOfGroup )
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Sorry, there are no place in the group.\n");
                }
            }

            grooup.getStudentss();
        }
    }
}