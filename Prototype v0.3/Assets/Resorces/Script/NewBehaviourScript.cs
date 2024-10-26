using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string[] textToCount;
    public char[] letter;

    void Start()
    {
        foreach (var item in textToCount) { 
            for (int i = 0; i > textToCount.Length; i++)
            {
                for (int j = 0; j > textToCount[i].Length; j++)
                {
                    if (textToCount[i].Contains(letter[i]))
                    {
                        
                    }
                }
            }
        }
    }
}
