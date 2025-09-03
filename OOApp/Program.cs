using OOApp.Model;

namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Teacher alice = new Teacher();
           Teacher bob = new();
           var kostas = new Teacher();

            Teacher anna = new Teacher() //Object Initializer
            {
                Id = 1,
                Lastname = "Papa",
                Firstname = "Anna"
            };

            Teacher andreas = new Teacher(1, "Andreas", "Mosxos");
        }
    }
}
