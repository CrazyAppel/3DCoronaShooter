using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaScript : MonoBehaviour
{
    public float xScale=2, yScale=2, zScale=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = transform.localScale + new Vector3(Mathf.Pow(xScale,2), Mathf.Pow(yScale, 2), Mathf.Pow(zScale, 2)) *Time.deltaTime;
    }
}
