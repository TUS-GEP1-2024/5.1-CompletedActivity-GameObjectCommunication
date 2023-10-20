using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float speed;
    public float jumpForce = 70;
    public bool isGrounded;
    public AudioSource theAudioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftAndRight();
        Jump();
    }

    void MoveLeftAndRight()
    {
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            theRB.velocity = Vector2.right * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            theRB.velocity = Vector2.left * speed;
        }
        else
        {
            theRB.velocity = new Vector2(0, theRB.velocity.y);
        }
    }

    void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.Space) == true) && (isGrounded == true))
        {
            theRB.AddForce(Vector2.up * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GroundPlatform")
        {
            isGrounded = true;
        }

        if (collision.gameObject.tag == "Wall")
        {
            theAudioSource.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GroundPlatform")
        {
            isGrounded = false;
        }
    }
}
