using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private Rigidbody rigidBody;
    
    private Vector3 moveDirection = Vector3.zero;
    private float horizontalMovement;
    private float verticalMovement;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // FixedUpdate() is used for PHYSICS CALCULATION
    void FixedUpdate()
    {
        CalculateMovement();
    }

    void CalculateMovement() {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(horizontalMovement, 0.0f, verticalMovement);

        rigidBody.AddForce(moveDirection * speed);
    }

}
