// See https://aka.ms/new-console-template for more information

using System.Text;

string prinT = InversionCapitalization("The life is great you need to know that");
Console.WriteLine(prinT);
Console.ReadLine();

string InversionCapitalization(string strg)
{
    strg = strg.ToLower();

    StringBuilder stringBuilder = new();

    for (int j = strg.Length - 1; j > -1; j--)
    {
        stringBuilder.Append(strg[j]);
    }

    string stringInverted = stringBuilder.ToString();

    string[] strgV = stringInverted.Split(' ');

    for (int i = 0; i < strgV.Length; i++)
    {
        char[] charArray = strgV[i].ToCharArray();
        charArray[0] = Char.ToUpper(charArray[0]);
        strgV[i] = new string(charArray);
    }

    return string.Join(" ", strgV);
}