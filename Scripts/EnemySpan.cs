using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpan : MonoBehaviour
{
    public GameObject enemy;
    float time = 1;
    int cnt = 0;

    private void Start()
    {
        time = Time.deltaTime;
    }

    void Update()
    {
        //Vector3 position = new Vector3(Random.Range(-10f, 10f), -0.5f, -12f);

       // if(Time.deltaTime >= time + 0.10f)
       // 
       if(cnt<2)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            time = Time.deltaTime;
            cnt++;
        }           
        //Debug.Log(Time.deltaTime + "       " + time);
        


       
    }
}
