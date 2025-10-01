using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp1.Models;

namespace TodoListApp1.Managers
{
    internal class TodoListManager
    {

        private List<TodoItem> _todoList = new List<TodoItem>();

        public TodoListManager()
        {
            _todoList.Add(new TodoItem(1, "Buy groceries"));
            _todoList.Add(new TodoItem(2, "Read a book"));
            _todoList.Add(new TodoItem(3, "Go for a walk"));
        }

        public void DisplayTodoList()
        {
            Console.WriteLine("\n--- Your To-Do List ---");
            if (_todoList.Count == 0)
            {
                Console.WriteLine("Your list is empty!");
            }
            else
            {
                foreach (var item in _todoList)
                {
                    Console.WriteLine($"{item.Id}. {item.GetStatusDisplay()} {item.Description}");
                }
            }
            Console.WriteLine("---------");
        }
    }
}
