﻿namespace Kata2;

public class Printable
{
    public static void PrintHealthChanged(Character character)
    {
        Console.WriteLine($"{character.Name}'s health is now {character.Health}.");
    }
}