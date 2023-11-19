using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] Text HPText;
    int health = 0;
    // Start is called before the first frame update
    void Start()
    {
        ChangeHealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeHealth(int count)
    {
        health += count;
        HPText.text = health.ToString();
    }
}
