using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script setting kamera mengikuti objek player dan script ini diletakan pada Main Camera
public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //public agar dapat dirubah valuenya pada unity
    private Vector3 offset = new Vector3(0, 5, -7); //private agar tidak dapat dirubah valuenya di unity

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //LateUpdate digunakan untuk membuat pergerakan kamera lebih smooth, dipanggil setelah objek diupdate. sedangkan update memperbarui perintah bersamaan menyebabkan terjadinya glitter pada interaksi kamera dan objek.
    {
        //posisi = mengikuti posisi objek player atau game objek
        //new vector digunakan untuk posisi atau memberi view jarak terhadap titik objek dan kamera
        //transform.position = player.transform.position + new Vector3 (0, 5, -7) merupakan tampilan tanpa variable
        transform.position = player.transform.position + offset; //Tampilan setting jarak kamera menggunakan variable offset
    }
}
