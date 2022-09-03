using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class knife : MonoBehaviour
{
    private bool isFlying; 

    private float startX; 

    private int score; //#

    public Text text; //#
    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x; 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString(); //#
        if (Input.GetMouseButtonDown(0)) isFlying = true; 

        if(isFlying) 
        {
            transform.Translate(Time.deltaTime * 13, 0, 0);  
        }
        else 
        {
            transform.position = new Vector3(startX, Mathf.Sin(Time.time * 3) * 4f); 
        }

        if (transform.position.x > 12) 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 

    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if (!isFlying) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
        }
        else 
        {
            Destroy(collision.gameObject); 

            isFlying = false; 
            score++;
        }
    }
}

