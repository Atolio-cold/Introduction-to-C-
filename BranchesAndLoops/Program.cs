using System;

class BrancheAndLoops {

     public static void Main() {
// int a = 5;
// int b = 3;
// if (a + b > 10)
// {
//     Console.WriteLine("The answer is greater than 10");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
// }

// int a = 5;
// int b = 3;
// int c = 4;
// if ((a + b + c > 10) && (a == b))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("And the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("Or the first number is not equal to the second");
// }

// int x = 5;
// int y = 3;
// int z = 4;
// if ((x + y + z > 10) || (x == y))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("Or the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("And the first number is not equal to the second");
// }

// int counter = 0;
// while (counter < 10)
// {
//     Console.WriteLine($"Hello World! The counter is {counter}");
//     counter++;
// }

// Random random = new Random();
// int randomNumber;
// do
// {
//     randomNumber = random.Next(1, 100);
//     Console.WriteLine($"Generated number: {randomNumber}");
// } while (randomNumber < 90);

// for(int fortnite = 0; fortnite < 10; fortnite++){
//     Console.WriteLine($"Hello World! The counter is {fortnite}");
// }


// for (int row = 1; row < 11; row++)
// {
//   for (char column = 'a'; column < 'k'; column++)
//   {
//     Console.WriteLine($"The cell is ({row}, {column})");
//   }
// }


int sum = 0;

for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)  // Sprawdzenie, czy liczba jest podzielna przez 3
    {
        sum += i;  // Dodaj liczbę do sumy
    }
}

Console.WriteLine($"The sum of integers from 1 to 20 that are divisible by 3 is: {sum}");


int bro = 0;
for(int j = 0; j <=30; j++){
    if (j % 5 == 0){
        bro += j;
    }
}

Console.WriteLine($"The sum of integers from 1 to 20 that are divisible by 3 is: {bro}");


int brr = 0;
for(int k = 0; k < 100; k++) {
    if (k % 5 == 0) {
        brr += k;
    }
}
Console.WriteLine($"The sum of integers from 1 to 20 that are divisible by 3 is: {brr}");

int tyk = 0;
for(int number = 0; number < 15; number++) {
    if (number % 5 == 0){
        tyk += number;
     }
}

Console.WriteLine($"The sum is {tyk}");













     }
}