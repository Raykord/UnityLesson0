using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10f;
    float lifeTime;
    float maxLifeTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void Update()
	{
		lifeTime += Time.deltaTime;
		if (lifeTime > maxLifeTime)
		{
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        speed += 1;
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
        {
            FindAnyObjectByType<Enemy>().HealthEnemy(-20);
            Destroy(gameObject);
        }
		if (other.tag == "Player")
		{
			FindAnyObjectByType<HealthSystem>().ChangeHealth(-20);
			Destroy(gameObject);
		}
		Destroy(gameObject);
	}
}
