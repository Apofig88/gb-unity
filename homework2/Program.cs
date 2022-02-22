using System;

namespace homework2  //Сергей Самойлов
{
    class Program
    {
        static void Main(string[] args)
        {

           


                    //1. Написать метод, возвращающий минимальное из трёх чисел.


                    Min3(23, 452, 72);


                    static int Min3(int a, int b, int c)
                    {
                        if (a <= b && a <= c)
                        {
                            return a;
                        }
                        else if (b <= c)
                        {
                            return b;
                        }
                        else
                        {
                            return c;
                        }
                    }

            


            //2. Написать метод подсчета количества цифр числа.


            SumNum(123456789);

            static int SumNum(int a)
            {
                int count = 0;
                while (a != 0) 
                {
                    a = a / 10;
                    count++;
                }
                return count;
            }



            //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.


            SumOdd();

            static int SumOdd()
            {
                Console.WriteLine("Введите число");
                int a = Convert.ToInt32(Console.ReadLine());
                int Sum = 0;
                while (true)
                {
                    if (a == 0)
                    {
                        break;
                    }
                    else if (a > 0 & a % 2 != 0)
                    {
                        Sum += a;
                    }
                    Console.WriteLine("Введите число");
                    a = Convert.ToInt32(Console.ReadLine());


                }
                return  Sum;

            }

            //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.


            static string SignIn(string login, string password)
            {
                int MaxCount = 3;
                for(int i = MaxCount; i>0;i--)
                {
                    Console.WriteLine("Введите логин");
                    string Login = Console.ReadLine();
                    Console.WriteLine("Введите пароль");
                    string Password = Console.ReadLine();

                    if (login == Login && password == Password)
                    {
                        return "Вы успешно авторизовались";
                    }
                    else Console.WriteLine("Вы ввели неверный логин или пароль, попыток осталось:"+(i-1));

                }
                return "Ошибка авторизации";
            }



        }

    }

}

