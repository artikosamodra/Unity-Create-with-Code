using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex; = berfungsi untuk meng-index data array objek animal
    private float spawnRangeX = 10.0f;
    private float spawnRangeZ = 20.0f;
    private float startDelay = 2.0f; //delay ketika di start
    private float spawnInterval = 1.5f; //delay tiap objek muncul

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating(nama fungsi, delay start, delay per objek muncul)
        //InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); //objek muncul otomatis

    }

    // Update is called once per frame
    void Update()
    {


      //  if (Input.GetKeyDown(KeyCode.S)) //jika input S = objek muncul
      //  {
      //      SpawnRandomAnimal(); //memanggil perintah pada fungsi SpawnRandomAnimal

            //perintah dibawah dipindahkan ke fungsi "SpawnRandomAnimal" agar void update lebih rapi dan terstruktur
            //Random.Range digunakan untuk mengacak objek animal yang keluar
            //animalPrefabs.Length diartikan panjang array.. di tampilkan dari data ke 1/array 0. dengan panjang data 3 (0,1,2)
            //int animalIndex = Random.Range(0, animalPrefabs.Length);
           
            //Vector3 spawnPos = new Vector3(0, 0, 20);
            //Vector3 spawnPos = new Vector3(Random.Range(-20,20), 0, 20); //random.range(-20,20) = spawn diantara titik x -20 sd 20
            // Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ); //titik dipanggil dengan variable spawnrangeX dan spawnrangeZ


            //Instiate diikuti (nama objek/variable, set posisi, set rotasi)
            //Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
            //Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
      //  }
    }

    //SpawnRandomAnimal = method baru seperti start dan update, untuk inisialisasi grup memudahkan pemanggilan fungsi
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
