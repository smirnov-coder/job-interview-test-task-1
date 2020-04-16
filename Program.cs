using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace JobInterviewTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тестовые данные пользователей.
            var users = GetTestUsers();

            // Сформировать промежуточный словарь с номерами месяцев в качестве ключей.
            var tempResult = new Dictionary<int, int>();
            for (int i = 1; i <= 12; i++) 
                tempResult.Add(i, 0);

            // Подсчитать количество дней рождений пользователей по месяцам.
            var result = users.Aggregate(tempResult, (result, user) =>
            {
                result[user.Birthday.Month]++;
                return result;
            });

            // Вывести в консоль результат с названиями месяцов.
            foreach (var entry in result)
                Console.WriteLine($"{DateTimeFormatInfo.CurrentInfo.GetMonthName(entry.Key).ToLower()} - {entry.Value}");
        }

        static IEnumerable<User> GetTestUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "name_1", Birthday = new DateTime(2000, 1, 1) },
                new User { Id = 2, Name = "name_2", Birthday = new DateTime(2000, 2, 1) },
                new User { Id = 3, Name = "name_3", Birthday = new DateTime(2000, 1, 1) },
            };
        }
    }

    class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
