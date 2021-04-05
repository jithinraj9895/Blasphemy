using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cam;
    GameObject playering;
    Vector3 temp;
    public float startx,starty,endx,endy;
    void Start()
    {
       
       playering = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        temp = cam.transform.position;
         
        if(playering != null)
        {
            temp.x = Mathf.Clamp(playering.transform.position.x,startx,endx);
            temp.y = Mathf.Clamp(playering.transform.position.y,starty,endy);
        }

     //   cam.transform.position = temp;

        cam.transform.position = Vector3.Lerp(cam.transform.position,temp, 0.07f);

   


    }
}
