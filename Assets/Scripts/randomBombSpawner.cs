using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBombSpawner : MonoBehaviour
{

    public GameObject theBomb;
    public int xPos;
    public int zPos;
    public int bombCount;

    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(BombDrop());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator BombDrop()
    {

        while (bombCount < 30)
        {
            xPos = Random.Range(-7, 7);
            
            Instantiate(theBomb, new Vector3(xPos, 4, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
            bombCount += 1;
        }
    }


}
