using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public GameObject Hero;
    private Animator anim;
    private Rigidbody2D rb;

    public float speed;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if(direction.x == 0 && direction.y == 0)
        {
            anim.SetBool("isGoing", false);
        }
        else 
        {
            anim.SetBool("isGoing", true);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
