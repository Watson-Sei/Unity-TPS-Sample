using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerScript : MonoBehaviour
{
    CharacterController con;
    Animator anim;

    float normalSpeed = 3f;
    float sprintSpeed = 5f;
    float jump = 8f;
    float gravity = 10f;

    Vector3 moveDirection = Vector3.zero;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        con = GetComponent & lt; CharacterController & gt; ();
        anim = GetComponent & lt; Animator & gt; ();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
