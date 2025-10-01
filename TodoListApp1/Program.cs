
using TodoListApp1.Managers;

namespace TodoListApp
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Your Personal To-Do ");
            var todoManager = new TodoListManager();
            todoManager.DisplayTodoList();
            Console.WriteLine("\nPress any key to exit…");
            Console.ReadKey();
        }
    }
}
