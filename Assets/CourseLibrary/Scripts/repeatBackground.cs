using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatBackground : MonoBehaviour
{
     private float speed = 30;
     private Vector3 startPos = new Vector3(45, 9.5f, 0);
     private float repeatWidth;
      private playerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        playerControllerScript = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
             if(playerControllerScript.gameOver == false)
       {
       
             transform.Translate(Vector3.left * Time.deltaTime * speed); 
       }   
             
             if(transform.position.x < startPos.x - repeatWidth)
             {
                 transform.position = startPos;
             }
    }
}
