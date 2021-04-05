using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ender : MonoBehaviour
{
    // Start is called before the first frame update
    
    GameObject ui_gameover,player;
    Button retry;
    Text txt;
    Image img;

     void Start()
    {
       
       ui_gameover = GameObject.FindGameObjectWithTag("game_over");
       player = GameObject.FindGameObjectWithTag("Player");
       retry = ui_gameover.GetComponent<Button>();
       txt = ui_gameover.GetComponentInChildren<Text>();
       img = ui_gameover.GetComponent<Image>();

        img.enabled =false;        
       retry.enabled =false;
       txt.enabled =false;
    }


    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            Destroy(player);
            img.enabled =true;
            retry.enabled = true;
            txt.enabled = true;
        }
    }


}
