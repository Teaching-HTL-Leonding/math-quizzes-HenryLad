

System.Console.WriteLine("Enter your first number");
double firstnumber = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter your second number");
double secondnumber = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Enter you result");
double result = double.Parse(Console.ReadLine()!);

if(firstnumber + secondnumber == result){
    System.Console.WriteLine("You used the [+] operator");
}
if(firstnumber - secondnumber == result){
    System.Console.WriteLine("You used the [-] operator");
}
if(secondnumber - firstnumber == result){
    System.Console.WriteLine("You used the [-] operator");
}
if(secondnumber * firstnumber == result){
    System.Console.WriteLine("You used an [*] operator");
}
if(firstnumber / secondnumber == result){
    System.Console.WriteLine("You used the [/] operator");
}
if(secondnumber / firstnumber == result){
    System.Console.WriteLine("You used the [/] operator");
}
if(firstnumber % secondnumber == result){
    System.Console.WriteLine("You used an [%] operator");
}
if(secondnumber % firstnumber == result){
    System.Console.WriteLine("You used an [%] operator");
}

