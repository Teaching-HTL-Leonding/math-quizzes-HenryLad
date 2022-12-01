/*for(int i = 1; i <= 100; i++){
    if(i % 3 == 0 && i % 5 == 0){
        System.Console.WriteLine("FizzBuzz");
    }
    else if(i % 3 == 0){
        Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0 ){
        Console.WriteLine("Buzz");
    }
    
    else{System.Console.WriteLine(i);}
} */
System.Console.WriteLine("Please enter the number for n");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Please enter the number for a. For multeplies of a it will print Fizz");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Please enter the number for b. For multeplies of b it will print Buzz");
int b = int.Parse(Console.ReadLine()!);
for(int i = 1; i <= n; i++){
    if(i % a == 0 && i % b == 0){
        System.Console.WriteLine("FizzBuzz");
    }
    else if(i % a == 0){
        Console.WriteLine("Fizz");
    }
    else if(i % b == 0 ){
        Console.WriteLine("Buzz");
    }
    
    else{System.Console.WriteLine(i);}
} 