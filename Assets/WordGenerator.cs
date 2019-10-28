using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour{



  //private static string[] wordlist = {"jugular", "lethal", "malice", "onslaught", "palpitate", "vicious", "xenohobia"};

    public static string[] commonWords = { "punch", "tamper", "wane", "yank", "quake", "choke", "smash","invade","hadouken", "grab","rabid" };
    public static string[] healingWords = { "armor-up", "dodge", "cure", "heal", "elixir", "intercept", "dodge", "cure", "heal", "elixir", "intercept" };
    public static string[] critWords = { "beatdown","zero-in-on","fatality", "ultimatum", "kNUckLe-SandWICh", "encroach","shinku-hadouken", "uppercut", "FaLcoN-PuNcH", "zero-in-on", "fatality" };
    public static string[] freezeWords = { "neutralize","blizzard", "frost", "icy", "pk-freeze", "ice-climber's", "exhaust","neutralize", "blizzard", "frost", "icy" };

    public static string GetRandomWord()
    {

        int randomIndex = Random.Range(0,10);
        //string randomWord = wordlist[randomIndex];

        int randomNumber = Random.Range(0, 4);
        string randomWord = "";

        switch (randomNumber)
        {
            case 0:
                randomWord = commonWords[randomIndex];
                break;
            case 1:
                randomWord = healingWords[randomIndex];
                break;
            case 2:
                randomWord = critWords[randomIndex];
                break;
            case 3:
                randomWord = freezeWords[randomIndex];
                break;
        }



        return randomWord;
    }
}

  
