using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionZone : MonoBehaviour
{
    GameObject Player;
    SphereCollider myColliderInfectionZone;
    //Vector3 particleRotation = new Vector3(0, 0, 90);
    public float infectionRadiusSpeed = 0.075f;
    public AudioClip infectionSound;
    public ParticleSystem zone;
    // Start is called before the first frame update
    void Start()
    {
        
        Player = GameObject.Find("Chinawoman");
        myColliderInfectionZone = transform.GetComponent<SphereCollider>();
        Instantiate(zone, myColliderInfectionZone.transform.position, Quaternion.identity );
    }

    // Update is called once per frame
    void Update()
    {
        
        //var x = zone.shape;
        //x.radius += infectionRadiusSpeed;
        myColliderInfectionZone.radius += infectionRadiusSpeed*Time.deltaTime;
        zone.Emit(10);
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
            AudioSource.PlayClipAtPoint(infectionSound, transform.position);
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
