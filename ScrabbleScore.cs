using System;
using System.Collections.Generic;
public static class ScrabbleScore
{

    public static int Score(string input)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>(){
            {"AEIOULNRST", 1},
            {"DG", 2},
            {"BCMP", 3},
            {"FHVWY", 4},
            {"K", 5},
            {"JX", 8},
            {"QZ", 10}
        };
        string word = input.ToLower();
        int score = 0;

        foreach (char letter in word)
        {
            foreach (var item in dict)
            {
                if (item.Key.ToLower().Contains(letter))
                {
                    score += item.Value;
                }
            }
        }
        return score;
    }
}