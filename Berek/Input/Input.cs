namespace Berek.Input;

internal static class Input
{
    public static bool GetNextKey(char pKey)
    {
        char key = Console.ReadKey().KeyChar;
        Console.Clear();
        return key == pKey;
    }
}
