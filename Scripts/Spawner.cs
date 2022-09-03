using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Target target; //ссылка на наш скрипт с целью для того, чтобы спавн понимал, что именно создавать

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 5f, 1f); //просим повторять через 5 секунд каждую секунду
    }

    // Update is called once per frame
    private void Spawn()
    {
        Instantiate(target); //спавним мишень
    }
}
