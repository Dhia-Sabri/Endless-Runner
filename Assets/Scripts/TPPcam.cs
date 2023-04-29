using UnityEngine;

public class TPPcam : MonoBehaviour
{

    public Transform ilrajel;
    public Vector3 bo3d;

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = ilrajel.position + bo3d;

    }
}
