using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int yokEdilenAsteroid = 5;
        int oyuncuHp = 100;

        if (yokEdilenAsteroid >= 10  || oyuncuHp >=80 )
        {
            Debug.Log("�ok G�zel");
        }
        //if (yokEdilenAsteroid == 20)
        //{
        //    Debug.Log("Tebrikler oyunu kazand�n�z!");
        //}
        //else if (yokEdilenAsteroid ==25)
        //{
        //    Debug.Log("Tebirkler birinci oldunuz");
        //}
        //else
        //{
        //    Debug.Log("Malesef oyunu kaybettiniz");
        //} 

        //switch (yokEdilenAsteroid)
        //{
        //    case 1: 
        //        Debug.Log("G�zel ba�lang��");
        //        break;
        //    case 10:
        //        Debug.Log("Bu i�te �ok iyisin");
        //        break;
        //    default:
        //        Debug.Log("Maalesef oyunu kaybettiniz.");
        //        break;

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
