using UnityEngine;
using System.Collections;

public class rotate_45  : MonoBehaviour
{
    public float speed = 10f;
    
    
    void Update ()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime * 2);
    }
}