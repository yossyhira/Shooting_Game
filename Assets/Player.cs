using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tama;

    public int deceleration_rate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(tama, transform.position+Vector3.forward*2,Quaternion.identity);
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position = transform.position + Vector3.right/deceleration_rate;
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position = transform.position + Vector3.left/deceleration_rate;
        }

        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position = transform.position + Vector3.up/deceleration_rate;
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position = transform.position + Vector3.down/deceleration_rate;
        }

       
    }
}
