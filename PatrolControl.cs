using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolControl : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;

    void Update(){
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
