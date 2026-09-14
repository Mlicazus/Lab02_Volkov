// System.Console.WriteLine("Границы целочисленных типов");
// System.Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
// System.Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// System.Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// System.Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// System.Console.WriteLine();
// System.Console.WriteLine("Границы дробных типов");
// System.Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// System.Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
// System.Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

// System.Console.WriteLine();
// System.Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);
// System.Console.WriteLine($"255 + 1 для byte = {overflowed}");

// System.Console.WriteLine();
// System.Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter;
// System.Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// System.Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// System.Console.WriteLine($"Табуляция:\tпосле таба");
// System.Console.WriteLine($"Перенос:\nпосле переноса");

// System.Console.WriteLine();
// System.Console.WriteLine("decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// System.Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// System.Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

// System.Console.WriteLine();
// System.Console.WriteLine("var");

// var studentAge = 20;
// var gpa = 4.25;
// var fullName = "Смирнова А.С.";

// System.Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

// using System.Runtime.Intrinsics.Arm;

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод теста");

// System.Console.Write("Введите ваше имя: ");
// string enteredName = System.Console.ReadLine();

// System.Console.Write("Введите название вашей группы: ");
// string enteredGroup = System.Console.ReadLine();

// System.Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод чисел: Convert и Parse");

// System.Console.Write("Введите ваш год рождения: ");
// string birthYearInput = System.Console.ReadLine();
// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// System.Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// System.Console.WriteLine($"int.Parse: {birthYearParse}");
// System.Console.WriteLine($"В 2030 вам будет: {2030 - birthYearConvert} лет");

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод чисел: TryParse");

// System.Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

// System.Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// System.Console.WriteLine($"Значение переменной booksCount: {booksCount}");

// System.Console.Write("Введите имя и фамилию: ");
// string Name = System.Console.ReadLine();
// System.Console.Write("Введите название группы: ");
// string Group = System.Console.ReadLine();
// System.Console.Write("Введите год рождения: ");
// string BirthYearInput = System.Console.ReadLine();
// int BirthYear = int.Parse(BirthYearInput);
// System.Console.Write("Введите средний балл за прошлый семестр: ");
// string AverageScoreInput = System.Console.ReadLine();
// double AverageScore = double.Parse(AverageScoreInput);
// System.Console.Write("Введите любимую букву алфавита: ");
// char FavoriteLetter = System.Console.ReadLine()[0];
// System.Console.WriteLine();
// System.Console.WriteLine($"     Анкета");
// System.Console.WriteLine($"{Name}, группа {Group}");
// System.Console.WriteLine($"Год рождения: {BirthYear} (в 2030 будет {2030 - BirthYear} год)");
// System.Console.WriteLine($"Средний балл: {AverageScore}");
// System.Console.WriteLine($"Балл >= 4.0: {AverageScore >= 4.0}");
// System.Console.WriteLine($"Любимая буква: {FavoriteLetter}");

// System.Console.Write("Введите ваш рост (в метрах): ");
// string HeightInput = System.Console.ReadLine();
// double Height = double.Parse(HeightInput);
// System.Console.Write("Введите ваш вес (в килограммах): ");
// string WeightInput = System.Console.ReadLine();
// double Weight = double.Parse(WeightInput);
// double BMI = Weight / (Height * Height);
// Console.WriteLine($"ИМТ: {BMI:F2}");

System.Console.Write("Введите имя: ");
string Name = System.Console.ReadLine();
System.Console.Write("Введите фамилию: ");
string Surname = System.Console.ReadLine();
char FirstLetter = Name[0];
System.Console.WriteLine($"{Surname} {FirstLetter}.");