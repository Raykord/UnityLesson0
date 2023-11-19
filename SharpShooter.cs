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

    

    // Update is called once per frame
    public override void Attack()
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

    }

    
}
