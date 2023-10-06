// See https://aka.ms/new-console-template for more information

Console.WriteLine(FirstUniqueChar("aaccdvv"));
Console.WriteLine(FirstUniqueChar("accdv"));
Console.WriteLine(FirstUniqueChar("aaccdv"));
Console.WriteLine(FirstUniqueChar("aaccddv"));

Console.ReadLine();

static string FirstUniqueChar (string word)
{
    char[] charArrayWord = word.ToCharArray();
    string firstUnique = ""; 

    for (int i = 0; i < word.Length && firstUnique == ""; i++)
    {
        firstUnique = word[i].ToString();

        for (int j = i + 1; j < word.Length; j++)
        {
            if (word[i] == word[j])
            {
                firstUnique = "";
                i++;
                j++;
                break;
            }
        }
    }

    return firstUnique != "" ? firstUnique : "Don't have unique char"; 
}