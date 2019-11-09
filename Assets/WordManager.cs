using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour{

    public List<Word>  words;
    public WordSpawner wordSpawner;
    public int counter = 0;
    public int word_damage = 0;
    private bool hasActiveWord;
    private bool gameActive = true;
    private Word activeWord;   // stores the ActiveWord

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
        words.Add(word);
        //Debug.Log("MY DEBUG LINE 1: " + word.word); // The letters of the word that just spawned
        //Debug.Log("MY DEBUG LINE 2: " + word.damage); //The damage of the word that just spawned
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
            //Debug.Log("DEBUG LINE 3: " + activeWord.word); //This is the word that you have just typed
            //Debug.Log("DEBUG LINE 4: " + activeWord.damage);
            hasActiveWord = false;
            words.Remove(activeWord); //activeWord is the word that spawns after typing a word
            counter++;
            if(counter % 1 == 0)
            {
               AddWord();
            }
            commonWordScore.scoreValue += activeWord.damage;
            if (commonWordScore.scoreValue == 0)
            {
                Debug.Log("YOU WIN");
                gameActive = false;
                Debug.Log(gameActive);
            }

          }
    }

}
