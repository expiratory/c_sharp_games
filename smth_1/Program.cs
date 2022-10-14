// // // // // Задача про номер дня недели
// // // // Console.WriteLine("Введите номер дня недели: ");
// // // // int number_for_day_of_the_week = Convert.ToInt32(Console.ReadLine());
// // // // if(number_for_day_of_the_week >=1 && number_for_day_of_the_week <=7)
// // // // {
// // // //     if(number_for_day_of_the_week == 1) Console.WriteLine("Понедельник");
// // // //     if(number_for_day_of_the_week == 2) Console.WriteLine("Вторник");
// // // //     if(number_for_day_of_the_week == 3) Console.WriteLine("Среда");
// // // //     if(number_for_day_of_the_week == 4) Console.WriteLine("Четверг");
// // // //     if(number_for_day_of_the_week == 5) Console.WriteLine("Пятница");
// // // //     if(number_for_day_of_the_week == 6) Console.WriteLine("Суббота");
// // // //     if(number_for_day_of_the_week == 7) Console.WriteLine("Воскресенье");
// // // // }
// // // // else
// // // // {
// // // //     Console.WriteLine("Дня недели с таким номером не существует");
// // // // }

// // // // // Задача про два числа и является ли одно квадратом другого
// // // Console.WriteLine("Введите первое число: ");
// // // int number1 = Convert.ToInt32(Console.ReadLine());
// // // Console.WriteLine("Введите второе число: ");
// // // int number2 = Convert.ToInt32(Console.ReadLine());

// // // if(number1 == Math.Pow(number2, 2))
// // // {
// // //     Console.WriteLine("Число " + number1 + " является числом " + number2 + " возведенным в квадрат");
// // // }
// // // if(number2 == Math.Pow(number1, 2))
// // // {
// // //     Console.WriteLine("Число " + number2 + " является числом " + number1 + " возведенным в квадрат");
// // // }
// // // else
// // // {
// // //     Console.WriteLine("Ни одно из этих чисел не является квадратом другого");
// // // }

// // // Задача про число N и все целые числа от -N до N
// // Console.WriteLine("Введите число");
// // int number1 = Convert.ToInt32(Console.ReadLine());
// // int number2 = number1 / -1;

// // while(number2 <= number1)
// // {
// //     Console.WriteLine(number2);
// //     number2++;
// // }

// // Задача про трехзначное число и его последнюю цифру
// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number_module = Math.Abs(number);
// int last_number = 0;

// if(number_module >= 99 && number_module <= 999)
// {
//     last_number = number_module % 10;
//     Console.WriteLine(last_number);
// }
// else
// {
//     Console.WriteLine("Число которое вы ввели не является трехзначным");
// }