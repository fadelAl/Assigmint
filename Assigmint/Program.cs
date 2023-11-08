// See https://aka.ms/new-console-template for more information
using NLipsum.Core;

Console.WriteLine("Hello, User! Enter your name, please!");

String result1 = method1();
Console.WriteLine(result1);

 static string method1()
{
    Console.WriteLine($"Nice to meet you! Can you describe yourself in one sentence, Please?");
    string userInput = Console.ReadLine();
    return userInput;
}

Console.WriteLine("Hello user! Enter one word, please!");

string result2 = method2();
Console.WriteLine(result2);

static String method2()
{

    Console.WriteLine($"Thank you! could you enter some text, please?");
    string userInput = Console.ReadLine();
    return userInput;

}


string result3 = method3("please enter a mumber");
Console.WriteLine(result3);
static string method3(string message)
{
    Console.WriteLine(message);
 string userInput = Console.ReadLine();
    return userInput;
    
}

string result4 = method4(Word:$"Please enter a {Word}", Console.WriteLine("Please enter your  lastName"));
Console.WriteLine(result4);

static string method4(string Word)
{
    Console.WriteLine(Word);
    string userInput = Console.ReadLine();
    return userInput;

        static string method4(string Word)
    {

        Console.WriteLine(Word);
        method4("boy name");
    }


    string result5 = (string firstName, string lastName);
    Console.WriteLine(result5);

    Static string method5;
    {
        Console.WriteLine("Please enter your firstName");
        string userfirstName = Console.ReadLine();
        return userfirstName;
        Console.WriteLine("Please enter your lastName");
        string userlastName = Console.ReadLine();
        return userlastName;
    }
    



}