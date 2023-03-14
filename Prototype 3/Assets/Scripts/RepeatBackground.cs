using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float widthBackground; 
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        widthBackground = GetComponent<BoxCollider>().size.x / 2; //memanggil komponen box colider dan setting size x dibagi 2 atau reset dilakukan 50% dari total panjang background.
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - widthBackground)
        {
            transform.position = startPos;
        }
    }
}
