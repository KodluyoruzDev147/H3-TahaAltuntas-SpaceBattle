using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursun : MonoBehaviour
{
    GeriSayimSayici geriSayimSayaci;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse); //kur�un de�eri olu�ur olu�maz yukar� do�ru hareket edecek. - h�z� de�erleri de�i�tirerek
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayici>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti) // kur�un uzayda kaybolduktan sonra backgroundda silinmesine sa�lar
        {
            Destroy(gameObject);
        }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Asteroid") // kur�un asteroidi yok ettikten sonra kaybolsun- tag ekleyerek yapt�k
        {
            Destroy(gameObject);
        } 
    }
}
