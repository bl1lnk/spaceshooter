using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {   
        GameObject gameObject = GameObject.FindWithTag("Player");
        //transform.position positin of the gameoobject that holds this script
        ///gameobject.transform.position will gameobject that is our player 
        //vector3 v3 = (gameobject.transform.position - transform.position).normalized;
        //vector2 v2 = new vector2(v3.x, v3.y);
        if(gameObject != null)
        {
            Vector2 playerPos = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPos * speed;
        }
        
    }

    
}
