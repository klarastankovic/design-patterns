using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.ToDo
{
    public static class ToDoTester
    {
        public static void Test()
        {
            CareTaker careTaker = new CareTaker();
            ToDoItem item = new ToDoItem("Cleaning", "Room cleaning", DateTime.Today);
            Console.WriteLine(item);

            item.Rename("Room cleaning");
            Console.WriteLine(item);

            careTaker.StoreState(item.StoreState());
            item.ChangeTimeDue(DateTime.Now);
            Console.WriteLine(item);

            item.RestoreState(careTaker.GetLastState());
            Console.WriteLine(item);
        }
    }
}
