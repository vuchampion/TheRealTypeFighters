using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour{

    public List<Word>  words;
    public List<Word> words2;
    public WordSpawner wordSpawner;
    public int counter = 0;


      private bool hasActiveWord;
      private Word activeWord;   // sotres the ActiveWord


    private void Start()
    {
        AddWord();
        AddWord();
        AddWord();
        AddWord();

    }

    public void AddWord()
      {

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {

        if (hasActiveWord)   // to check if the letter that we typed is in the sequence and remove it from the word if it is true
        {
            if(activeWord.GetNextLetter() == letter)
            {
                  activeWord.TypeLetter();
            }
        }
        else {
                foreach( Word word in words)
                {

                  if(word.GetNextLetter() == letter )
                    {
                        activeWord = word;
                        hasActiveWord = true;
                        word.TypeLetter();
                        break;

                    }
                }

        }

          if (hasActiveWord && activeWord.WordTyped())
          {
            //Word word2 = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
            hasActiveWord = false;
            words.Remove(activeWord);
            //words2.Add(word2);
            counter++;
            if(counter % 1 == 0)
            {
               AddWord();
            }
           
            Debug.Log("You have typed a word\n");
          }
    }

}
