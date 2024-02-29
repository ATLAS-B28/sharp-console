// See https://aka.ms/new-console-template for more information

/*using Humanizer;

static void HumanizerQuantities() 
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizerDates() 
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}

Console.WriteLine("Quantities: ");
HumanizerQuantities();
Console.WriteLine("Dates: ");
HumanizerDates();

string val1 = " a";
string val2 = "A ";
Console.WriteLine(val1.Trim().ToLower() == val2.Trim().ToLower());
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);
string myVal = "a";
Console.WriteLine(myVal == "a");

//use string - contain()
string pangram = "The quick brown fox jumps over lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// >, <, <=, >=, ==, !=  ? option1 : option2
int sales = 1000;
int discount = sales > 100 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Discount: {(sales > 100 ? 100 : 50)}");

//random 
Random coin = new Random();
int flip = coin.Next(0,2);
Console.WriteLine((flip == 0)? "heads" : "tails");
Console.WriteLine((coin.Next(0,3)) ? "heads" : "tails");
//remember to use string.Contains and revise this
string permissions = "Manger|Admin";
int level = 59;
if(permissions.Contains("Admin")) 
{
    if(level > 55) 
    {
        Console.WriteLine("Welcome, Super Admin");
    } 
    else
    {
        Console.WriteLine("Welcome, Admin");
    }
} 
else if(permissions.Contains("Manager")) 
{
    if(level >= 55) 
    {
        Console.WriteLine("Welcome, Super Manager");
    } 
    else 
    {
        Console.WriteLine("Welcome, Manager");
    }
} 

//Math.Max
int firstVal = 500;
int secondVal = 100;
int largerVal;
largerVal = Math.Max(firstVal, secondVal);
Console.WriteLine(largerVal);

//array and foreach
string[] names = {"Rowena","Robin","Bao"};
foreach(string name in names) {
    Console.WriteLine(name);
}
int[] inventory = {200,40,450,789,600,934};
int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} item (Running total at that time: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");
Console.WriteLine($"Bin {bin} = {sum / bin}");

string[] pallets = {"B14","A11","B12","A13"};
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets) 
{
    Console.WriteLine($" -- {pallet}");
}
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach(var pallet in pallets) 
{
    Console.WriteLine($" -- {pallet}");
}

///resize
Array.Resize(ref pallets, 6);//new index is 6
Console.WriteLine("Resized...");
pallets[4] = "A14";
pallets[5] = "A15";
foreach(var pallet in pallets) {
    Console.WriteLine($" -- {pallet}");
}
///clear 
Array.Clear(pallets,0,2);
Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");
Console.WriteLine("Removing the first 2 elements 0 means start index and 2 are the no. of elements");
Console.WriteLine($"After: {pallets[2].ToLower()}");
foreach(var pallet in pallets) 
{
    Console.WriteLine($" -- {pallet}");
}

//ToCharArray()
string value = "abc123";
char[] valArray = value.ToCharArray();
foreach(var val in valArray) 
{
    Console.WriteLine(val);
}
//join
string result = string.Join(" , ", valArray);
Console.WriteLine(result);
string[] items = result.Split(',');
Console.WriteLine(items[0]);
Console.WriteLine(items[1]);
Console.WriteLine(items[2]);

string pangram = "The quick brown fox jumps over lazy dog.";

string[] message = pangram.Split(' ');

string[] newMessage = new string[message.Length];

for(int i = 0; i < message.Length; i++) 
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result2 = string.Join(" ", newMessage);
Console.WriteLine(result2);*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(' ');
Array.Sort(items);
foreach(var item in items) 
{
    if(item.Length == 4) 
    {
        Console.WriteLine(item);
    }
    else 
    {
        Console.WriteLine(item);
    }
}