using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionZone : MonoBehaviour
{
    GameObject Player;
    SphereCollider myColliderInfectionZone;
    public float infectionRadiusSpeed = 0.075f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Chinawoman");
        myColliderInfectionZone = transform.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
       
        myColliderInfectionZone.radius += infectionRadiusSpeed*Time.deltaTime;
        if (Vector3.Distance(myColliderInfectionZone.transform.position, Player.transform.position)< myColliderInfectionZone.radius)
        {
            Debug.Log("Test123");
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Chinawoman")
        {
            Debug.Log("INSIDE");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Chinawoman")
        {
            Debug.Log("Outside");
        }
    }
}
