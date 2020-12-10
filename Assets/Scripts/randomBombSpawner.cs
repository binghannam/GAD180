using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBombSpawner : MonoBehaviour
{

    public GameObject theBomb;
    private float xPos;
    public float yPos;

    public int bombCount;
    void Start()
    {

        StartCoroutine(BombDrop());
    }
    IEnumerator BombDrop()
    {
        while (bombCount < 30)
        {
            xPos = Random.Range(-8, 8f);            
            Instantiate(theBomb, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            bombCount += 1;
        }
    }


}
