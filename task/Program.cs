string[] array1 = new string[] { "Cat", "likes", "Mau", "and", "Kus'", "dog","liz","murmur"};
//Console.WriteLine($"{array1[1]}");
//Console.WriteLine(array1[1].Length);
for (int i = 0; i < array1.Length; i++)
{
Console.Write($"{(i == 0? array1[i]: ", " + array1[i])} ");
}
Console.Write(" ---> ");
string[] newArray = new string[array1.Length];  //array2.Length
   for (int j = 0; j < array1.Length; j++)
{
    if (array1[j].Length <= 3)
{
var temp =  array1[j];
temp = newArray[j];
newArray[j] = array1[j];
Console.Write($"{(j == 0? newArray[j]: ", " + newArray[j])}");
}
}                                                                                                                                                                             
