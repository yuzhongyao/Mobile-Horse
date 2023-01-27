using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    GameObject g;
    public float jumpHeight = 1f;
    private float gravityValue = -9.81f;
    private Vector3 playerVelocity;
   void Start()
    {
        g = GameObject.Find("Player");
       
    }
    void FixedUpdate()
    {
        playerVelocity = g.GetComponent<Rigidbody>().velocity;
    }
   public void playerJump()
    {
        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
    }
    
}
