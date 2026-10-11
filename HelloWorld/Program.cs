// Информация о студенте
string firstName = "Бахмуд";
string lastName = "Саидов";
string group = "ИСП-243";
int birthYear = 2005;
double gpa = 4.5;
bool hasScholarship = true;

// Вычисление возраста
int currentYear = 2026;
int age = currentYear - birthYear;

// Вывод информации
Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");

// Интерактивный ввод
Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}.");