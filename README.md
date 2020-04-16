# Задание с собеседования на вакансию "Программист C#"

## Описание

Имеется коллекция пользователей, получаемая, например, из БД через EntityFramework
```c#
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
}
...
var users = dbContext.Users();
```
Необходимо вывести количество дней рождений пользователей по месяцам в формате:
```
январь - 1
февраль - 2
март - 0
...
```