using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float playerSpeed = 10.0f;
    private float jumpForce = 5.0f;

    private bool isGrounded;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f);

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-playerSpeed * Time.deltaTime,0,0);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime,0,0);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
}
