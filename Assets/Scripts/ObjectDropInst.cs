using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropInst : MonoBehaviour
{
    public GameObject droppedObj;
    public Transform Spawner;
    private int dropCount;

    void Start()
    {
        StartCoroutine(DropSpawnTimer());
    }

    IEnumerator DropSpawnTimer()
    {
        Vector3 Pos;
        while (dropCount < 100)
        {
            Pos.x = Random.Range(-8, 8);
            Pos.y = 20.4f;
            Pos.z = 0;
            Instantiate(droppedObj, Pos , Spawner.rotation);
            yield return new WaitForSeconds(2f);
            dropCount += 1;
        }      
    }
}



