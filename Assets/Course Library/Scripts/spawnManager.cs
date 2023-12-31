using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2;
    public float repeatRate = 2;

    private playerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
     private void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);   
    }}
}
