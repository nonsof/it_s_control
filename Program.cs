using System.Net;

int lenght = LenghtOfArray();
string[] myarr = UrArray(lenght);
Console.WriteLine();
PrintArray(myarr);


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


