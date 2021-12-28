using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisiKontrol : MonoBehaviour
{

    const float hareketGucu = 5; 

    bool topluyor = false;  // toplama i�lemi ba�lad�ktan sonra bir daha gemiye t�klasak bile hedeften �a�m�yor
    
    GameObject hedef; 

    Rigidbody2D myrigidbody2D; // uzay gemimizin hareketlerini kontrol etmek i�in fizik kurallar�na ihtiyac�m�z var.

    Toplayici toplayici; 

    // Start is called before the first frame update
    void Start()
    {
        // yukaradaki de�i�kenlerin hangi componentlara ait oldu�unu belirtiyoruz.

        myrigidbody2D = GetComponent<Rigidbody2D>();   //uzay gemimizi ait oldu�u i�in
        toplayici = Camera.main.GetComponent<Toplayici>(); // toplayici bile�enimiz main kamerada
    }

    void OnMouseDown()  // uzay gemimizi t�klad���nda �a��r�yor
    {
        if (!topluyor) // toplama i�lemi ba�lamad�ysa git topla
        {
            GitVeTopla();
        }
        
    }
    void OnTriggerStay2D(Collider2D other) // uzay gemimiz yildiz colliderine temas etti�inde bize onu bildir. ( GitveTopla metodunu yapt�ktan sonra) ( help scripts references)
    {
        if (other.gameObject == hedef)
        {
            toplayici.YildizYokEt(hedef);
            myrigidbody2D.velocity = Vector2.zero; // uzay gemimize etki eden kuvveti s�f�ra �ekmemiz laz�m.
            GitVeTopla(); // toplanacak y�ld�zlar var ise tekrardan git topla
        }
    }

    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz; // �ncelikle hedefi istiyoruz.
        if(hedef !=null) // hedef var ise 
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x - transform.position.x, 
                hedef.transform.position.y - transform.position.y); // uzay gemisini hedefteki y�ld�z� g�nderiyoruz

            gidilecekYer.Normalize(); //vekt�rel 2 noktay� birle�tirmesi i�in normalini al�yoruz.
            myrigidbody2D.AddForce(gidilecekYer * hareketGucu, ForceMode2D.Impulse); // gidip toplayan metod haz�r.
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 position = transform.position;

        //float yatayInput = Input.GetAxis("Horizontal");
        //float dikeyInput = Input.GetAxis("Vertical");

        //if (yatayInput !=0)
        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime;
        //}

        //if (dikeyInput !=0)
        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}
        //transform.position = position;
    }
}


