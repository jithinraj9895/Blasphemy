using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class talker : MonoBehaviour
{
    // Start is called before the first frame update
  

    // Update is called once per frame

    public GameObject bars;
    [TextArea(3,5)]
    public string dialougue;
    public Text texter;

    
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            bars.SetActive(true);

            StartCoroutine(TypeMessage(dialougue, texter));

            
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            bars.SetActive(false);

            texter.text = dialougue;
        }
    }


    IEnumerator TypeMessage(string msg, Text msgTxt)
    {

        char[] tempString = new char[msg.Length];
        tempString = msg.ToCharArray();
        int j =0;
        string temper;
      //  string tempString = "";
      //  msgTxt.text = tempString;
        int runningIndx = 0;

        while (runningIndx < msg.Length)
        {
            if(runningIndx % 36 == 0)
            {
                Array.Clear(tempString,0,tempString.Length);
                j = 0;
            }

            tempString[j] += msg[runningIndx];
            runningIndx++;
            j++;
            temper = string.Join("", tempString);
            msgTxt.text = temper;
            yield return new WaitForSeconds(0.1f);
        }
    }
    
}
