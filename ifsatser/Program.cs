if (6 >= 3)
{
Console.WriteLine("hello");
}



string pass = "L";
Console.WriteLine("wats ya name");
string name = Console.ReadLine();
while (pass != "nopass")
{
    Console.WriteLine("wats ya password");
    pass = Console.ReadLine();
}

if (name == "noname" && pass == "nopass")
{
    Console.WriteLine("welcome");
}
else
{
    Console.WriteLine("wrong username or password");
}
int a = 0;
while (a < 32)
{
    a++;
    Console.WriteLine($"hello.world.{a}");
}
int x = 0;
while (x<5){
    Console.WriteLine("number");
    string tal = Console.ReadLine();
    int number;
    int.TryParse(tal , out number);
    if (number>5){
        Console.WriteLine("more than 5!");
    }
    x++;
}

bool aerd =false;
while (aerd == false){
    Console.WriteLine("give number");
   string frf= Console.ReadLine();
   int bab;
   aerd = int.TryParse(frf , out bab);
}
int fj=1;
while (fj != 3){

Console.WriteLine("guess number");
string fawe= Console.ReadLine();

int.TryParse(fawe,out fj);
if (fj<3){
    Console.WriteLine("toolow");
}
if (fj==3){
    Console.WriteLine("correct");

}
if (fj>3){
    Console.WriteLine("toohigh");
}

}

Console.ReadLine();