using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private FixedJoystick joystick;
    public float moveSpeed = 5f;
    public float jumpHeight = 1f;
    private float gravityValue = -9.81f;
    // public Joystick J;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(joystick.Horizontal * moveSpeed, rigidbody.velocity.y, joystick.Vertical * moveSpeed);
    }
    public void playerJump()
    {
        rigidbody.velocity += new Vector3(joystick.Horizontal * moveSpeed,Mathf.Sqrt(jumpHeight * -3.0f * gravityValue), joystick.Vertical * moveSpeed); 
    }
}
