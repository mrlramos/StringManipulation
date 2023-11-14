// See https://aka.ms/new-console-template for more information

Console.WriteLine(RunLength("aabbcvvvv")); 
Console.WriteLine(RunLength("aabbcvff")); 
Console.WriteLine(RunLength("aabbcvssdadsa")); 
Console.WriteLine(RunLength("aabbcvassddas")); 
Console.WriteLine(RunLength("aabbcvqweeeeew"));

Console.ReadLine();

static string RunLength(string strg)
{
    char[] charsStrg = strg.ToCharArray();
    short count = 1;
    string encodedStrg = string.Empty;

    for (int i = 0; i < charsStrg.Length; i++)
    {

        if (i + 1 != charsStrg.Length && charsStrg[i] == charsStrg[i + 1])
        {
            count++;
        }
        else
        {
            encodedStrg += count.ToString() + charsStrg[i];
            count = 1;
        }
    }

    return encodedStrg;
}