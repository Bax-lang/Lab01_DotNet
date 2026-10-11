// // Информация о студенте
// string ame = "Бахмуд";
// string lastName = "Саидов";
// string group = "ИСП-243";
// int birthYear = 2005;
// double gpa = 4.5;
// bool hasScholarship = true;

// // Вычисление возраста
// int currentYear = 2026;
// int age = currentYear - birthYear;

// // Вывод информации
// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {ame} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// // Интерактивный ввод
// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично! {firstName} любит {subject}.");


// // 8.1. Математические операции
// int a = 15;
// int b = 4;

// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b}");
// Console.WriteLine($"Частное (int): {a / b}");
// Console.WriteLine($"Остаток: {a % b}");

// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");

// // 8.2. Математические функции
// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));

// // 8.3. Практическое задание
// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");

// if (num2 != 0)
// {
//     Console.WriteLine($"Частное: {num1 / num2}");
// }
// else
// {
//     Console.WriteLine("Деление на ноль невозможно!");
// }


Console.WriteLine("Добро пожаловать в анкету!");

// Ввод данных
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();

Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();

Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();

Console.Write("Введите ваш год рождения: ");
int birthYear = int.Parse(Console.ReadLine());

Console.Write("Введите ваш средний балл (например, 4.5): ");
double gpa = double.Parse(Console.ReadLine());

// Вычисления
int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;

string status;
if (isExcellent == true) 
    status = "Отличник";
else 
    status = "Хорошист";

// Вывод результата
Console.WriteLine("\nВаша анкета");
Console.WriteLine($"Имя: {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Статус: {status}");
Console.WriteLine($"Лет до 30: {30 - age}");

Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();
