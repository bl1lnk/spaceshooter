using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayerWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            //destroy player
            Destroy(gameObject);
            //destroy enemy as he is the one that collides with in this case
            Destroy(collision.gameObject);
        }
    }

    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
