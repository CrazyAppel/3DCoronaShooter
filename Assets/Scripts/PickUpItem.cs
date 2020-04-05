using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public AudioClip slurpSound;
    void Start()
    {
       // slurpSound = GetComponent<AudioSource>();
    }
   void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(slurpSound, transform.position);
            Destroy(gameObject);
            
        }
    }
}
