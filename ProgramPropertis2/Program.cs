using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPropertis2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Age))
            {
                Console.WriteLine("Введите возраст пользователя");
                Properties.Settings.Default.Age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Activity))
            {
                Console.WriteLine("Введите род деятельности пользователя");
                Properties.Settings.Default.Age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            string ageUser = Properties.Settings.Default.Age;
            string activityUser = Properties.Settings.Default.Activity;
            Console.WriteLine("Имя пользователя:{0}; Возраст:{1}; Род деятельности:{2}", userName, ageUser, activityUser);
        }
    }
}
