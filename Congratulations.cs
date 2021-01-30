using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congratulations : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public float distance;
    private bool movingRight = true;
    public Transform groundDetection;

    public static bool completed = false;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }

    void Update(){

        completed = true;
        
        if(isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.up, distance);
        if(groundInfo.collider == false){
            if(movingRight == true){
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }else{
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
