using System.Net;

int lenght = LenghtOfArray();
string[] myarr = UrArray(lenght);
Console.WriteLine();
PrintArray(myarr);
Console.WriteLine();
Console.WriteLine();
Test(myarr);
Console.WriteLine();
int newLenght = HowMany(myarr);
Console.WriteLine();
string[] newArray = ReadyArray(newLenght, myarr);
Console.WriteLine();
PrintArray(newArray);



int LenghtOfArray ()
{
Console.WriteLine ("u need to write a lenght of array here");
int l = Convert.ToInt32(Console.ReadLine());
return l;
}

string[] UrArray (int l)
{
    Console.WriteLine("Write any word and use 'enter' after each word for write a next");
    string[] array = new string[l];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

return array;
}

void PrintArray (string[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(",", arr));
    Console.Write("]");
}

void Test (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"the lenght of {array[i]} is {array[i].Length}");
    }
}


int HowMany (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count ++;
        }
        
    }
    Console.WriteLine($"count elements of array which include 3 or less simbols = {count}");
    return count;
}
 
string[] ReadyArray (int l, string[] oldarray)
{
    string[] array = new string[l];
    int j = 0;
    for (int i = 0; i < oldarray.Length; i++)
    {
        if (oldarray[i].Length <= 3)
        {
            array [j] = oldarray[i];
            j++;
        }
    }

return array;
}