using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed;
    public ParticleSystem jetpackThrust1;

    Animator anim;
    //int jumpHash = Animator.StringToHash("isJump");
    int runStateHash = Animator.StringToHash("Base Layer.Walk");


    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
        PlayerMovement();   
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        anim.SetFloat("RunSpeed", ver);

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isJump", true);
            transform.Translate(0, (Speed * 2) * Time.deltaTime, 0);
            transform.Translate(new Vector3(hor, 0f, ver) * (Speed * 2) * Time.deltaTime, Space.Self);
            jetpackThrust1.Emit(2);
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        }

        

        else { 

            Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);

            //jetpackThrust1.Stop();
        }

    }

    void OnCollisionEnter(Collision col)
    {
            anim.SetBool("isJump", false);
    }
}
