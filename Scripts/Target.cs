using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Target : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector2(transform.localPosition.x, Random.Range(-4, 4));  
        speed = Random.Range(5, 9); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0); 
        if (transform.localPosition.x < -10) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
