using System.Security.Cryptography.X509Certificates;

static void getBase(){
    Console.Clear();
    Console.WriteLine("Enter a number :");
    int Number = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Enter the input Base (Int) :");
    int inputBase = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Enter the output Base (Int) :");
    int outputBase = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Processing...");
    var newNumber = "Error";
    if(inputBase == 10){
        newNumber = decToBase(Number, outputBase);
    }
    else if(outputBase == 10){
        newNumber = baseToDec(Number, inputBase).ToString();
    }
    else{
        newNumber = decToBase(baseToDec(Number, inputBase), outputBase);
    }
    Console.Clear();
    Console.WriteLine($"{Number} in base {inputBase} is equivalent to : {newNumber} in base {outputBase}");
}

static string decToBase(int Number, int Base){    
    int q = Number, r;
    string newNumber = "";

    while(q >= Base){
        r = q-(q/Base)*Base;
        q = q/Base;
        newNumber = Convert.ToString(r)+ newNumber;
    }
    newNumber = q.ToString() + newNumber;
    return newNumber;
    }

static int baseToDec(int Number, int Base){
    int newNumber = 0;
    for(int i = 0; i < Number.ToString().Length; i++)
    {
        if(Convert.ToInt32(Number.ToString().Substring(i,1)) < Base)
        {
            newNumber += Convert.ToInt32(Number.ToString().Substring(i,1))*Convert.ToInt32(Math.Pow(Base, Number.ToString().Length-i-1));
        }
        else
        {
            Console.WriteLine("Invalid Value");
            System.Environment.Exit(0);
        }
    }
    return newNumber;
}

getBase();