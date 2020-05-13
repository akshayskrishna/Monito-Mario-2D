using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask ground;
    Rigidbody2D rb;
    Animator anim;
    Vector2 force;
    bool facingright = true;
    AudioSource audiosource;
    public AudioClip clipJump;
    bool jumpPending = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -2 + Time.deltaTime, 2), rb.velocity.y);
       

        force = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            force.x = -20;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            force.x = 20;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 feet = new Vector2(transform.position.x, transform.position.y - 0.75f);
            Vector2 dimension = new Vector2(1.0f, 0.2f);

            bool grounded = Physics2D.OverlapBox(feet, dimension, 0, ground);

            if (grounded)
            {
                jumpPending = true;
            
                audiosource.clip = clipJump;
                audiosource.Play();

            }

            
    }

        if (force.x < 0)
        {

            anim.SetBool("isWalking", true);
            if (facingright) Flip();
        }

        else if (force.x > 0)
        {
            Flip();
            anim.SetBool("isWalking", true);
            if (!facingright) Flip();
        }

        else
        {
            anim.SetBool("isWalking", false);
        }
    }

    private void FixedUpdate()
    {
        if (jumpPending)
        {
            force.y = 450;
            jumpPending = false;
        }
        rb.AddForce(force);
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;

        facingright = !facingright;
    }

}
