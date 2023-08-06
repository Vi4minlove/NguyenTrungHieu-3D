using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnim;
    public Rigidbody playerRig;
    public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
    public bool walking = false;
    public Transform playerTrans;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRig.velocity = transform.forward * w_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRig.velocity = -transform.forward * wb_speed * Time.deltaTime;
        }
    }
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetTrigger("RifleRun");
            playerAnim.ResetTrigger("RifleIdle");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.ResetTrigger("RifleRun");
            playerAnim.SetTrigger("RifleIdle");
            walking = false;
        }

        //if(walking == true)
        //{
        //    inf
        //}
    }
}
