using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public int speed = 5;
    Rigidbody enemyRb;
    float zDestroy = 10;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(Vector3.forward * speed);
        if(transform.position.z > zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
