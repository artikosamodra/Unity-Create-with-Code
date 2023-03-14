using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 20.0f;

    private Playercontroller PlayerControllerScript;

    public float leftBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<Playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
        
    }
}
