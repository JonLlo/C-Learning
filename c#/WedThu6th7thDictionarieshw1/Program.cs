// See https://aka.ms/new-console-template for more information
/*
//Wednesday 
   
//arrays

using System.Diagnostics;

byte lengthOfInfo  = 6;
int[] arr = new int[lengthOfInfo];

string user1 = "Fred";
string user2 = "Barney";
string user3 = "James";

int[] array1 = new int[5];
int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
int[] array3 = new[] { 1, 2, 3, 4, 5 };
int[] array4 = {1,2,3,4,5};
int[] array5 = [1,2,3,4,5];
string[] array6 = { "Fred", "Barney", "James" };
Console.WriteLine(array6[0]);
array6[2] = "Jamie";
Console.WriteLine(array6[2]);
//If you want to copy an array, you must clone it.
//Otherwise any changes to one will occur to the other
string[] arr6Dup = (string[])array6.Clone();
Console.WriteLine(arr6Dup[2]);

//
int number = -45;
uint uNumber = (uint)number;
Console.WriteLine(number);
Console.WriteLine(uNumber);

//jagged arrays
//not jagged
byte[,] chessBoard = new byte[8,8];
//jagged
byte[][] hotel = new byte[10][];
hotel[0] = new byte[30]; //30 rooms on floor 1
hotel[1] = new byte[40]; //40 rooms on floor 2

//for loops
for (int i = 0; i < hotel.Length; i++)
{
    hotel[i] = new byte[30];
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"This is loop {i}");
}

string[] arr7 = ["A", "B", "C", "D", "E", "F", "D"];
Console.WriteLine(arr7);
for (int i = 0; i < arr7.Length; i++) 
{
    Console.WriteLine($"This is loop {i} and the value is {arr7[i]}");
    if (arr7[i] == "D")
    {
        Console.WriteLine($"D is found at index {i}");
    }
}
//while loops
/*
Console.Write("Enter your name:" );
string? name = Console.ReadLine();
while (name == "")
{
    Console.WriteLine("Enter your name.");
    Console.Write("Enter your name:");
    name = Console.ReadLine();
}
*/
//do while
/*
do
{
    //code
} while (//condition)
*/
//foreach
/*
string[] arr8 = ["A", "B", "C", "D", "E", "F", "D"];
foreach (string item in arr8)
{
    Console.WriteLine(item);
}

//whereas for loop would be like this:
for (int i = arr8.Length - 1; i >= 0; i--)
{
    Console.WriteLine(arr8[i]);
}
*/

//lists
/*
List<string> list = new List<string>();
//add some items
list.Add("Fred");
list.Add("Barney");
list.Add("Ellie");
Console.WriteLine(list);
Console.WriteLine(list.ToArray());
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine(list[0]);
Console.WriteLine(list);
Console.WriteLine(list.ToArray().Length);
Console.WriteLine(list.Count);

List<byte> list2 = new List<byte> { 1,2,3,4,5 };
List<byte> list3 = new List<byte> { 1,2,3,4,5 };
list3.AddRange(new byte[] {6,7,8,9});

List<string> list4 = new List<string> { "1", "2", "3" };
List<int> list5 = list4.ConvertAll(int.Parse);

//the two below show different notation for the same thing:
Console.WriteLine(list4[2]);
Console.WriteLine(list4.ElementAt(2));
//properties and methods found in lists:

*/
//Thursday - Dictionaries:

//Empty Dictionary
Dictionary<string,int> dict1 = new Dictionary<string,int>();

//Initialise with stuff
Dictionary<string, int> dict2 = new Dictionary<string, int>()
{
    { "Alice", 30 },
    { "Bob", 25 },
};
// creates a new dictionary
Dictionary<string, int> dict3 = new Dictionary<string, int>(dict2);
dict3.Add("Eve", 22);
dict3["Frank"] = 40;

//Access the value not the key
int age = dict3["Alice"];
Console.WriteLine($"Age is {age} years old!");

//Checking whether a key exists
if (dict3.ContainsKey("Grace"))
{
    Console.WriteLine($"Grace is age {dict3["Grace"]} years old!");
}
else
{
    Console.WriteLine("Grace not found!");
}



// Removing entries:
dict3.Remove("Eve");



foreach (var item in dict2)
{
    Console.WriteLine(item);
}
foreach (var item in dict3)
{
    Console.WriteLine(item);
}

// Iterate key-value pairs
foreach (KeyValuePair<string, int> item in dict3)
{
    Console.WriteLine($"The key is {item.Key} and the value is {item.Value}");
}
//Iterate for keys only
foreach (string key in dict3.Keys)
{
    Console.WriteLine(key);
}
//Iterate for keys only
foreach (int value in dict3.Values)
{
    Console.WriteLine(value);
}

dict3["Frank"] = 50;


//Using a TryGetValue to get Values

if (dict3.TryGetValue("Frank", out int frankAge))
{
    Console.WriteLine($"Frank's age is {frankAge}");
}
else
{
    Console.WriteLine("Frank's age not found!");
}


Console.ReadLine();

//Homework
//Come up with a login script using c#.



