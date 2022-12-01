int i = 0;
int newnumber = 0;
System.Console.WriteLine("Please enter the number you want to start with ? " );
int startnumber = int.Parse(Console.ReadLine()!);
do{
    
    if(startnumber % 2 == 0){
        i ++;
        newnumber = startnumber / 2;
    }
    
    else if (startnumber % 2 != 0){
        newnumber = startnumber * 3 + 1;
        i++;
    }
    startnumber = newnumber;
    //System.Console.WriteLine($"Your currentnumber is {startnumber}");
}while(startnumber != 1);
i ++;
System.Console.WriteLine($" The lenght of your secens is {i}");