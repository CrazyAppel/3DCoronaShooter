using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionZone : MonoBehaviour
{
    
    SphereCollider myColliderInfectionZone;
    public float infectionRadiusSpeed = 0.075f;
    // Start is called before the first frame update
    void Start()
    {
        myColliderInfectionZone = transform.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        myColliderInfectionZone.radius += infectionRadiusSpeed*Time.deltaTime;
    }
}
