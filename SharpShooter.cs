using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpShooter : Enemy
{
    
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletPoint;
    
    float area = 100;
    float timer = 0;
    float cooldown = 1;

    // Start is called before the first frame update
    void Start()
    {
        HealthEnemy(100);
        player = FindObjectOfType<HealthSystem>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < area)
        {
            transform.LookAt(player.transform.position);
            timer += Time.deltaTime;
            if (timer > cooldown)
            {
                timer = 0;
                GameObject bul = Instantiate(bullet);
                bul.transform.position = bulletPoint.transform.position;
                bul.transform.rotation = transform.rotation;
            }
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HealthEnemy(int count)
    {
        health += count;
    }
}
