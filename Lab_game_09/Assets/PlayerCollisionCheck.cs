using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject, 0.5f);
        }
    }

}
