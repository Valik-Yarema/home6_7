using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpSpeed = 10.0f;
    public float gravity = 20.0f;
    public float rotationSpeed = 90;
    public AudioClip aud1;

    
 
    private Vector3 move = Vector3.zero;
    private AudioSource asource1;


    private CharacterController control;
    void Start()
    {
        control = gameObject.GetComponent<CharacterController>();
        asource1 = GetComponent<AudioSource>();
       

    }
    void Update()
    {   
        if (control.isGrounded)
        {
            move = new Vector3(0.0f, 0.0f, Input.GetAxis("Vertical"));
            move = transform.TransformDirection(move);
            move = move * speed;
            if (Input.GetButton("Jump"))
            {
                move.y = jumpSpeed;
                GetComponent<AudioSource>().PlayOneShot(aud1);
            }
        }
        else
        {
            move.y = move.y - (gravity * Time.deltaTime);


        }
     
        control.Move(move * Time.deltaTime);
        Vector3 rotateCoords = new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
        control.transform.Rotate(rotateCoords);
    }


  

}
   