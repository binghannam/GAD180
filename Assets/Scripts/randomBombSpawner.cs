using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBombSpawner : MonoBehaviour
{

    public GameObject theBomb;
    public int xPos;
    public int yPos;
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
            xPos = Random.Range(-10, 10);
            yPos = Random.Range(-3, 9);
            Instantiate(theBomb, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
            bombCount += 1;
        }
    }


}
