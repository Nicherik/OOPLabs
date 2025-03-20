// See https://aka.ms/new-console-template for more information
using FirstTask.Classes;

bool check;
char ans, ch;
int num, den, num1, den1, choise;



do
{



    Console.WriteLine("Enter a first fraction in format x/y: ");
    string fraction = Console.ReadLine();
    string[] parts = fraction.Split('/');
    num = int.Parse(parts[0]);
    den = int.Parse(parts[1]);

    RationalNumbers rationalNumbers = new RationalNumbers(num, den);


    Console.WriteLine("Enter a second fraction in format x/y: ");
    fraction = Console.ReadLine();
    parts = fraction.Split('/');
    num1 = int.Parse(parts[0]);
    den1 = int.Parse(parts[1]);

    RationalNumbers rationalNumbers1 = new RationalNumbers(num1, den1);


    RationalNumbers rationalNumbers2 = new RationalNumbers();

    Console.WriteLine("Menu: ");
    Console.WriteLine("1. +");
    Console.WriteLine("2. -");
    Console.WriteLine("3. *");
    Console.WriteLine("4. /");
    Console.WriteLine("5. ==");
    Console.WriteLine("6. !=");
    Console.WriteLine("7. <");
    Console.WriteLine("8. >");
    Console.WriteLine("9. <=");
    Console.WriteLine("10. >=");
    Console.WriteLine("11. unar -");

    Console.WriteLine("Enter !number! of operation: ");
    choise = int.Parse(Console.ReadLine());


    switch (choise)
    {
        case 1:

            rationalNumbers2 = rationalNumbers + rationalNumbers1;
            Console.WriteLine("Result with +: ");
            Console.WriteLine(rationalNumbers2.ToString()); break;
        case 2:

            rationalNumbers2 = rationalNumbers - rationalNumbers1;
            Console.WriteLine("Result with -: ");
            Console.WriteLine(rationalNumbers2.ToString()); break;

        case 3:

            rationalNumbers2 = rationalNumbers * rationalNumbers1;
            Console.WriteLine("Result with *: ");
            Console.WriteLine(rationalNumbers2.ToString()); break;

        case 4:

            rationalNumbers2 = rationalNumbers / rationalNumbers1;
            Console.WriteLine("Result with /: ");
            Console.WriteLine(rationalNumbers2.ToString()); break;

        case 5:

            check = rationalNumbers == rationalNumbers1;
            Console.WriteLine("Result with ==: ");
            Console.WriteLine(check); break;

        case 6:

            check = rationalNumbers != rationalNumbers1;
            Console.WriteLine("Result with !=: ");
            Console.WriteLine(check); break;

        case 7:

            check = rationalNumbers < rationalNumbers1;
            Console.WriteLine("Result with <: ");
            Console.WriteLine(check); break;

        case 8:

            check = rationalNumbers > rationalNumbers1;
            Console.WriteLine("Result with >: ");
            Console.WriteLine(check); break;

        case 9:

            check = rationalNumbers <= rationalNumbers1;
            Console.WriteLine("Result with <=: ");
            Console.WriteLine(check); break;

        case 10:

            check = rationalNumbers >= rationalNumbers1;
            Console.WriteLine("Result with >=: ");
            Console.WriteLine(check); break;

        case 11:

            rationalNumbers2 = -rationalNumbers;
            Console.WriteLine("Result with unary -: ");
            Console.WriteLine(rationalNumbers2.ToString());
            rationalNumbers2 = -rationalNumbers1;
            Console.WriteLine("Result with unary -: ");
            Console.WriteLine(rationalNumbers2.ToString()); break;

    }

    Console.WriteLine("Want to proceed?(y/n): ");
    string input = Console.ReadLine();


    ans = input[0];



}
while (ans != 'n');

