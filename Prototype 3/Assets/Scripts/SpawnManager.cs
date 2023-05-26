using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePreb;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 5.0f;
    public float repeatRate = 2.5f;

    public Playercontroller playerCOntrollerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerCOntrollerScript = GameObject.Find("Player").GetComponent<Playercontroller>();
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        if (playerCOntrollerScript.gameOver == false)
        {
            Instantiate(obstaclePreb, spawnPos, obstaclePreb.transform.rotation);
        }
        
    }
}
