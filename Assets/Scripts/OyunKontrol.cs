using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject uzayGemisiPrefab;

    [SerializeField]
    List<GameObject> asteroidPrefabs = new List<GameObject>();
        
    GameObject uzayGemisi;
    List<GameObject> asteroidList = new List<GameObject>(); //ekranda ka�tane asteroid oldu�umuzu daha sonras�nda bilmemiz laz�m, �retti�imiz asteroidler bu listeye

    // Start is called before the first frame update
    void Start()
    {
       uzayGemisi =  Instantiate(uzayGemisiPrefab); //uzay gemisinin olu�mas� i�in instantiate veriyoruz.
       uzayGemisi.transform.position = new Vector3(0, EkranHesaplayicisi.Alt + 1.5f); // uzay gemisinin ba�lang�� konumunu belirliyoruz.

        AsteroidUret(5); // asteroiduret metodunu �a��r�yoruz ve 5 tane metod kurallar�na g�re �retiyor.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AsteroidUret(int adet)
    {
        Vector3 position = new Vector3(); // her bir asteroidin konumu i�in

        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z; // kameray� referans alarak olu�turuyoruz.
            position = Camera.main.ScreenToWorldPoint(position); // oyun d�nyas�n�n koordinatlar�na �eviriyoruz.
            position.x = Random.Range(EkranHesaplayicisi.Sol, EkranHesaplayicisi.Sag); //asteroidlerin x de�eri kameran�n sa� ve sol aral�klar� olucak
            position.y = EkranHesaplayicisi.Ust - 1; //asteroidlerin y de�erini ust k�s�mdan biraz daha a��a��da olucak.

            GameObject asteroid = Instantiate(asteroidPrefabs[Random.Range(0, 2)], position, Quaternion.identity); // asteroidler 3 tane oldu�u i�in random, konumunu , rotasyonunda de�i�iklik olmas�n diye
            asteroidList.Add(asteroid);


        }
    }
}
