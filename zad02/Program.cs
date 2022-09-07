// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void PozitivNumbers()
{
      Console.WriteLine("Сколько чисел Вы хотите ввести: ");
      int M = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      int countNum = 0;
            while (countNum < M)
            {
                Console.Write("Введите число: "); 
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 0) count += 1;
                countNum += 1;
            }
      Console.WriteLine($"Положительных чисел: {count}");
}

PozitivNumbers();