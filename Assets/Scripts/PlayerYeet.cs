using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYeet : MonoBehaviour
{
    public Rigidbody rb;
    //public BoxCollider bx;    
    public float tangiza = 5f;
    public float Movespeed = 5;
    public bool Small;
    public TrailRenderer trail;

    private void Start()
    {
        transform.position = new Vector3(0, 1.6f, 5.5f);
        

    }

    private void Update()
    { 
      float  DirectX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(DirectX *  Movespeed, rb.velocity.y);        

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < 1.75 && transform.localScale.y != 0.5f)
        {

            rb.AddForce(0, tangiza, 0, ForceMode.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            //bx.size = new Vector3(1, 0.5f, 1); 
            //bx.center = new Vector3(0, -0.25f, 0);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            trail.widthMultiplier = 0.5f;
            rb.AddForce(0, -7.5f, 0, ForceMode.Impulse);

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            //bx.size = new Vector3(1, 1f, 1); 
            //bx.center = new Vector3(0, 0f, 0);
            transform.localScale = new Vector3(1, 1, 1);
            trail.widthMultiplier = 1f;

        }


    }

    public void Resize() 
    {
        if(Small)
        {
            transform.localScale = new Vector3(1, 1, 1);
            Small = false;
        }
        else
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            rb.AddForce(0, -7.5f, 0, ForceMode.Impulse);
            Small = true;
        }
    }

}
