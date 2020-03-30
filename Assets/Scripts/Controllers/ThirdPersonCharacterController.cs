using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed;
    public ParticleSystem jetpackThrust1;


    // Update is called once per frame
    void Update()
    {
        PlayerMovement();   
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {

            transform.Translate(0, (Speed * 2) * Time.deltaTime, 0);

            
            transform.Translate(new Vector3(-hor, 0f, -ver) * (Speed * 2) * Time.deltaTime, Space.Self);
            jetpackThrust1.Emit(2);
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
        else { 
        Vector3 playerMovement = new Vector3(-hor, 0f, -ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        //jetpackThrust1.Stop();
        }

    }
}
