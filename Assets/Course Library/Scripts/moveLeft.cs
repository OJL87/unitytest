using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    private float speed = 30;
    private float leftBound = -15;
    private playerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
       if(playerControllerScript.gameOver == false)
       {
       
       transform.Translate(Vector3.left * Time.deltaTime * speed); 
       }

       if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
       {
           Destroy(gameObject);
       }
    }
}
