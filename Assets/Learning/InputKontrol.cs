using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    List<GameObject> asteroidList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           // Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);


            for(int i =0; i < 20; i++)
            {
                asteroidList.Add(Instantiate(asteroidPrefab, position, Quaternion.identity));
            }

        }

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Pressed left click");
        //}


        

        if (Input.GetMouseButton(1))
        {
            Debug.Log(asteroidList.Count); // asteroidList i�erisindeki eleman say�m�z� g�steriyor.
            
            foreach (GameObject asteroid in asteroidList) // asteroidList miz i�erisinde asteroid alias � ile beraber hepsini dola��p yok ediyoru. T�r� gameObject)
            {
                Destroy(asteroid);
            }

            asteroidList.Clear(); //her t�klad���m�zda elemanlar olu�uyor ve bir sonraki t�klamam�za �nceki listteki say� ekleniyor, gereksiz eleman fazlal��� olmamas� i�in yap�yoruz.

        }


       
        //    for (int i = 0; i < asteroidList.Count; i++)
        //    {
        //        Destroy(asteroidList[i]);
        //    }
        //}

        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("Pressed middle click");
        //}


    }
}
