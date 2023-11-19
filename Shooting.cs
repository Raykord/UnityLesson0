using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletPoint;
    
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bul = Instantiate(bullet);
            bul.transform.position = bulletPoint.transform.position;
            bul.transform.rotation = transform.rotation;
        }
    }
}
