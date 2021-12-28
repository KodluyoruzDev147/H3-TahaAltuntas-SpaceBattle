using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    [SerializeField]
    GameObject patlamaPrefab = default;

    OyunKontrol oyunKontrol;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>(); // asteroide kuvvet ekliyoruz
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();

        float yon = Random.Range(0f, 1.0f); // asteroidin ini� y�n�n� random ayarl�yoruz.
        if (yon < 0.5)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse); //asteroidlerin ini� koordinat� ve h�zlar�n� belirliyoruz.
            rb2d.AddTorque(yon * 2.0f); // asteroidler kendi etraf�nda d�n�yor
        }
        else
        {
            rb2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(-yon * 2.0f);

        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Kursun") //asteroidler kursun ile temas etti�inde patlas�n-bunu tag eklereyerek yapt�k.
        {
            oyunKontrol.AsteroidYokOldu(gameObject);
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
