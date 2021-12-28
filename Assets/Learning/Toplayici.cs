using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{

    [SerializeField]
    GameObject yildizPrefab;

    List<GameObject> yildizlar = new List<GameObject>();

    /// <summary>
    /// Hedefteki y�ld�z� s�yler
    /// </summary>
    public GameObject HedefYildiz
    {
        get
        {
            if (yildizlar.Count > 0) // y�ld�zlar listemizde toplanacak y�ld�z var m�
            {
                return yildizlar[0];
            }
            else
            {
                return null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z; // z eksenini kameraya g�re ayarl�yoruz.
            Vector3 oyunDunyasiPosizyon = Camera.main.ScreenToWorldPoint(position); // piksellere gelen de�erleri oyun d�nyas�na �eviriyoruz.
            yildizlar.Add(Instantiate(yildizPrefab, oyunDunyasiPosizyon, Quaternion.identity)); // art�k y�ld�z instantiate olur olmaz yildizlar list in i�ine eklenicek 
        }
    }

    /// <summary>
    /// Parametre olarak g�nderilen y�ld�z� yok eder.
    /// </summary>
    /// <param name="yokEdilecekYildiz"></param>
    public void YildizYokEt(GameObject yokEdilecekYildiz)
    {
        yildizlar.Remove(yokEdilecekYildiz); // �nce listin i�erisinden ��kart�yoruz.
        Destroy(yokEdilecekYildiz); // oyun ekran�ndan yok ediyoruz.
    }
}
