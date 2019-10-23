using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour{



  private static string[] wordlist = {"kick","punch","sidewalk","jump","smile","run","close","study","represent","random"};

    public static string GetRandomWord()
    {

        int randomIndex = Random.Range(0,wordlist.Length);
        string randomWord = wordlist[randomIndex];

        return randomWord;



    }


}
