using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody playerRun;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSFX; //membuat setting audioclip yang dipilih
    public AudioClip crashSFX;
    private AudioSource playerSFX; //memanggil method di komponen AudioSource

    public float jumpForce; //untuk menentukan tinggi lompatan
    public float gravityModifier; //untuk menentukan kekuatan gravitasi

    public bool onGround =  true;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        playerRun = GetComponent<Rigidbody>(); //Mengambil komponen pada Rigidbody
        playerAnim = GetComponent<Animator>(); //Mengambil komponen pada Animator
        playerSFX = GetComponent<AudioSource>(); //Mengambil komponen pada Audio Source + Add componen Audio Source pada Game Object Player agar SFX muncul.
        Physics.gravity *= gravityModifier; //pyhsic.gravity = mengambil fisik gravity. assigment operator a *= b. artinya a = a*b, berlaku untuk operator lain (+,-,/)
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround) //(!gameOver) = (gameOver != true) = (gameOver == false) . semua sama hanya penyerdehanaan. ! = operator not. 
        {
            playerRun.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); //AddForce = Komponen Rigidbody untuk menambah lompatan, vector untuk arah lompatan dan ForeceMode = jenis lompatan, terdapat 4 jenis (Force, Impluse, VelocityChange dan Acceleration)
            onGround = false;
            playerAnim.SetTrigger("Jump_trig"); //Set Trigger = fungsi untuk mentrigger componen pada animator
            dirtParticle.Stop(); //partikel di stop saat jump
            playerSFX.PlayOneShot(jumpSFX, 1.0f); //PlayOneShot merupakan perintah play 1x ketika ter-trigger.
        }
        else if (gameOver)
        {
            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision) //method khusus untuk definisi ground otomatis
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerSFX.PlayOneShot(crashSFX, 1.0f);
        }
    }
}
