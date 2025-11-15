using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour
{
    Rigidbody2D myrigidbody2D;
    Animator myAnimator;
    float timer = 0;
    bool isGround = false;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myrigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timer = 0;

        }
        if (Input.GetMouseButton(0))
        {
            timer += Time.deltaTime;

        }
        if (Input.GetMouseButtonUp(0) && isGround == true)
        {
            myrigidbody2D.AddForce(new Vector2(1, 1) * timer * 2000);
            myAnimator.SetTrigger("jump");

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
            isGround = true;
        if (collision.collider.tag == "Edge")
            print("Over!");
    }
  
}
