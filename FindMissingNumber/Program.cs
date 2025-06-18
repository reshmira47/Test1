// Program Entry Point
namespace MissingNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IFindMissingNumber finder = new FindMissingNumber();
            Application app = new Application(finder);
            app.Run();
        }
    }
}