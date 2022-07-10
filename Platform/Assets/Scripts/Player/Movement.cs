using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public SpriteRenderer player;
    private Rigidbody2D rb;
    private Animator anim;
    private float speed = 5f;
    private float jumpForce = 7f;
    private BoxCollider2D boxCollider2D;

    public Transform groundCheck;
    public LayerMask groundLayerMask;
    private bool isGround;
    public float groundCheckRadius;
    // Start is called before the first frame update
    void Awake()
    {
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
        player.gameObject.GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //private States State
    //{
    //    get { return (States)anim.GetInteger("state"); }
    //    set { anim.SetInteger("state", (int)value); }

    //}
    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayerMask);
        //if (isGround) State = States.Animation_Idle;
        if (Input.GetButton("Horizontal"))
        {
            Move();
        }
        else if (Input.GetButtonUp("Horizontal"))
            anim.SetBool("isMove", false);
        
        if (Input.GetButtonDown("Jump") && isGround)
        {
            Jump();        
        } 
        if(transform.position.y < -4f)
        {
          GetComponent<Health>().TakeDamage(4);
        }
    }
    
    private void Move()
    {
        //if (isGround) State = States.Animation_Run;
            Vector3 dir = transform.right * Input.GetAxis("Horizontal");
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
            player.flipX = dir.x < 0.0f;
        anim.SetBool("isMove", true);
    }
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
    //private bool isGrounded() {
    //   RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, platformslayerMask);
    //    Debug.Log(raycastHit2d.collider);
    //    return raycastHit2d.collider != null;
        
    //}
}

public enum States
{
    Animation_Run,    //0
    Animation_Idle    //1

}

