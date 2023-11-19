using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected int health;
    protected int damage;
    const float maxHealth = 100f;
    protected GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<HealthSystem>().gameObject;
        HealthEnemy(100);
    }

	public void HealthEnemy(int count)
	{
		health += count;
	}

    public virtual void Move()
    {

    }

	public virtual void Attack()
	{

	}

	// Update is called once per frame
	void Update()
    {
        Attack();
        Move();

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
