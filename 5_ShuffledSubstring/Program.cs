// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsShuffledSubstring("abcde", "abcdf"));
Console.WriteLine(IsShuffledSubstring("abcde", "abcde"));
Console.WriteLine(IsShuffledSubstring("abcde", "abdf"));
Console.WriteLine(IsShuffledSubstring("abeg", "gagber"));

static bool IsShuffledSubstring (string a, string b)
{
    if (a == string.Empty)
    {
        return true;
    }

    char[] arrA = a.ToCharArray();
    char[] arrB = b.ToCharArray();
    short count = 0;

    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < b.Length; j++)
        {
            if (arrA[i] == arrB[j])
            {
                count++;
                arrB[j] = ' ';
                break;
            }
        }
    }

    if (count == a.Length)
    {
        return true;
    }

    return false;
}