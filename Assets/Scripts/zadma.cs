using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadma : MonoBehaviour
{

    public PlayerYeet ta7rika;
    public Transform Pos;
    public GameObject Win;
    public GameObject ScoreCount;
    //public Score score;

    void OnCollisionEnter(Collision zadma)
    {

        if (zadma.collider.tag == "Obstacle")
        {

            ta7rika.enabled = false;
            Win.SetActive(true);
            ScoreCount.SetActive(false);

        }
    }
    
}
