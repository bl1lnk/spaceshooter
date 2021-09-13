using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstersController : MonoBehaviour
{
    public GameObject monster;
    public float interval = 3;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

    private void SpawnMonster()
    {
        float MyRan = Random.value;

        if(MyRan < 0.2)
        {
            GameObject g = Instantiate(monster, transform.position, Quaternion.identity);

        }

    }

}
