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
        if (geriSayimSayaci.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
