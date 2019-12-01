using System;
using System.Windows.Forms;

namespace SysPro_Lab_05
{
    static class Program
    {
        // Варіант 5. Додаток зберігає інформацію про співробітників і
        // підрозділи підприємства.Через діалогові вікна можна редагувати
        // інформацію про підрозділи (додавання, видалення, зміна назви) та
        // співробітників (додавання інформації, видалення, зміна прізвища
        // та / або заробітної плати). Вивести список всіх співробітників із
        // зазначенням підрозділу і поточної латки з можливістю сортування
        // по кожному полю по зростанню і зменшенням.Реалізувати можливість
        // накладення фільтра, що дозволяє виводити список співробітників тільки одного підрозділу.

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
