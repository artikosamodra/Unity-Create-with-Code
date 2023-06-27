using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //Script setting kontrol dari objek utama
{
    //rubah public menjadi private agar tidak dapat dirubah oleh pemain
    private float speed = 10.0f;
    private float turnSpeed = 22.0f;
    private float horizontalInput; // variable kanan kiri
    private float forwardInput; //variable maju mundur

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //berada di menu edit>projectsetting>inputManager> dengan nama "Horizontal". Get.Axis yaitu mendapatkan Axis di menu Input manager
        forwardInput = Input.GetAxis("Vertical"); //maju mundur dengan nama di input manager "Vertical"

        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //speed is variable menentukan kecepatan kedepan.. forwardInput berfungsi agar objek dapat maju dan mundur
        
        //mengatur gerakan ke kanan dan ke kiri +- menggunakan right.. jika menggunakan up, maka objek dapat sedikit berotasi saja menikung.. kemudian variable horizontalInput untuk setting pergerakan objek menggunakan keyboard di InputManager
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
