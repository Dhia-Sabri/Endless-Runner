using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colide : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision Col)
    {
        Destroy(Col.gameObject);
    }
}
