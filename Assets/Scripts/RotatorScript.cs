using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    public float xAngle=1, yAngle=2, zAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
