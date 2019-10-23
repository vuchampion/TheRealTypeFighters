using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{


    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord()
    {
        int y1 = 300;
        int y2 = 200;
        int x1 = 100;
        int x2 = 200;
        Vector3 randomPosition = new Vector3 (Random.Range(100f,300f), Random.Range(100f,300f));


        GameObject wordObj = Instantiate(wordPrefab,randomPosition, Quaternion.identity,wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
