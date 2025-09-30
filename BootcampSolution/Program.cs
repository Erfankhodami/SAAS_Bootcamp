using BootcampClassLibrary;
namespace BootcampSolution
{
    class Program
    {
        
        public static void Main()
        {
            Person me = new Person("erfan","home");       
            Console.WriteLine(me.Address);
        }
    }
}