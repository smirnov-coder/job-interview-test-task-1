# ������� � ������������� �� �������� "����������� C#"

## ��������

������� ��������� �������������, ����������, ��������, �� �� ����� EntityFramework
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
���������� ������� ���������� ���� �������� ������������� �� ������� � �������:
```
������ - 1
������� - 2
���� - 0
...
```