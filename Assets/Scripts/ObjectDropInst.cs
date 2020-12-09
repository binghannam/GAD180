using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropInst : MonoBehaviour
{
    public GameObject droppedObj;
    public Transform topScreen;
    public int dropCount;



    void Start()
    {
        StartCoroutine(DropSpawnTimer());

    }


    IEnumerator DropSpawnTimer()
    {
        Vector3 Pos;
        while (dropCount < 100)
        {

        Pos.x = Random.Range(-8.6f, 8.6f);
        Pos.y = 3.6f;
        Pos.z = 0;

        Instantiate(droppedObj, Pos , topScreen.rotation);

        yield return new WaitForSeconds(5);

            dropCount += 1;
        }

       
    }

   


}



