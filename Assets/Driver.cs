using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200;
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float slowSpeed = 5;
    [SerializeField] float boostSpeed = 20;


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if( other.tag == "Boost"){
            moveSpeed = boostSpeed;
        }
    }
}
