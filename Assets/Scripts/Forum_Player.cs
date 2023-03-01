using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forum_Player : MonoBehaviour
{

    public float speedMultiplier = 2.0f;
    public string obstacleTag = "SpeedRamp";
    public float moveSpeed = 5.0f;
    public float turnSpeed = 50.0f;

    Rigidbody rb;
    public float jumpMultiplier = 1.5f;
    public string jumpPadTag = "JumpPad";
    public float jumpStrength = 3.0f;
    public bool isOnGround = true;

    public Material newMaterial_blue;
    public Material newMaterial_green;
    public Material newMaterial_orange;
    public Material newMaterial_pink;
    public Material newMaterial_red;
    public Material newMaterial_yellow;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // get the RIGIDBODY

    }

    void Update()
    {

        float w_Input = Input.GetAxis("Vertical") * moveSpeed; //WS or UP/Down
        w_Input *= Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * turnSpeed;// AD or L/Right
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, w_Input);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKeyDown("space") && isOnGround)
        {
            rb.velocity = new Vector3(0, jumpStrength, 0);
            isOnGround = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            rb.transform.position = new Vector3(0, 1, 0);
            rb.transform.forward = Vector3.forward;
            moveSpeed = 7.0f;
            jumpStrength = 5.0f;
            GetComponent<Renderer>().material = newMaterial_blue;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(obstacleTag) && moveSpeed < 14)
        {
            // Increase the speed of the object
            moveSpeed *= speedMultiplier;
        }

        if (collision.gameObject.CompareTag(jumpPadTag) && jumpStrength < 7.5)
        {
            // Increase the jump of the object
            jumpStrength *= jumpMultiplier;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Blue"))
        {
            GetComponent<Renderer>().material = newMaterial_blue;
        }

        if (collision.gameObject.CompareTag("Green"))
        {
            GetComponent<Renderer>().material = newMaterial_green;
        }

        if (collision.gameObject.CompareTag("Orange"))
        {
            GetComponent<Renderer>().material = newMaterial_orange;
        }

        if (collision.gameObject.CompareTag("Pink"))
        {
            GetComponent<Renderer>().material = newMaterial_pink;
        }

        if (collision.gameObject.CompareTag("Red"))
        {
            GetComponent<Renderer>().material = newMaterial_red;
        }

        if (collision.gameObject.CompareTag("Yellow"))
        {
            GetComponent<Renderer>().material = newMaterial_yellow;
        }
    }

}