using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private int randomNumber;
    private int lastNumber;
    public GameObject[] Blocks;
    public float delay = 1f;
    private float TimeToSpawn = 3f;
    
    // Start is called before the first frame update
    void Update()
    {

        if (Time.time >= TimeToSpawn)
        {
            Spawn();
            TimeToSpawn = Time.time + delay;
        } 

    }    
    void NewRandomNumber()
    {
        randomNumber = Random.Range(0, Blocks.Length);
        lastNumber = randomNumber;
        if (randomNumber == lastNumber)
        {
            randomNumber = Random.Range(0, Blocks.Length);
        }        
    }

    void Spawn()
    {

        NewRandomNumber();

        var test = Instantiate(Blocks[randomNumber], transform.position, Quaternion.identity);

        test.transform.parent = gameObject.transform;

    }
}