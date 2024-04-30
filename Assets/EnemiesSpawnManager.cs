using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject silinder;
    private float posx;
    private float posy;
    private float posz;
    private Vector3 randompos;

    private int count = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(count<=10){
        posx = Random.Range(-80,60);
        posy = Random.Range(-2,12);
        posz = Random.Range(11,30);
        randompos=new Vector3(posx,posy,posz);

        Instantiate(silinder,randompos,Quaternion.identity);

        count++;

        }


    }
}
