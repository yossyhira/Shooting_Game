using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    private Vector3 pos;

    public int return_point;

    

    

    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pos.x + Mathf.PingPong(Time.time, return_point), pos.y, pos.z);
   

    }

   
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

    }
}
