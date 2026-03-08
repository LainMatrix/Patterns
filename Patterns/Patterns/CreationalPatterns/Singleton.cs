using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreationalPatterns
{
    //гарантирует, что класс имеет только один экземпляр
    internal class Singleton
    {
            //Когда использовать Singleton

            //Для логирования(как в примере выше)
            //Для конфигурации приложения(например, AppSettings)
            //Для доступа к базе данных через единый объект
            //Для кэширования или менеджера ресурсов

    }

    //Пример использоваия
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        // Приватный конструктор — нельзя создать извне
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                // Двойная проверка блокировки для потокобезопасности
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Logger();
                    }
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
