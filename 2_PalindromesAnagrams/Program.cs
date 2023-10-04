// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsPalindrome("radar"));
Console.WriteLine(IsPalindrome("test"));

Console.WriteLine(IsAnagram("listen", "silent"));
Console.WriteLine(IsAnagram("listrn", "silent"));
Console.WriteLine(IsAnagram("listen", "silrnt"));
Console.WriteLine(IsAnagram("test", "banana"));

Console.ReadLine();

static bool IsPalindrome (string word)
{
    string invertedWord = string.Empty;

    for (int i = word.Length - 1; i > -1; i--)
    {
        invertedWord += word[i];
    }

    if (invertedWord == word)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool IsAnagram (string word, string word2) 
{
    if (word.Length == word2.Length)
    {
        char[] charArrayWord = word.ToCharArray();
        char[] charArrayWord2 = word2.ToCharArray();
        short count = 0;

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < word.Length; j++)
            {
                if (charArrayWord[i] == charArrayWord2[j])
                {
                    count += 1;
                }
            }
        }

        if (count == word.Length)
        {
            return true;
        }
    }

    return false;
}