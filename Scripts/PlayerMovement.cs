using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed;
    [SerializeField]
    public float runSpeed;
    [SerializeField]
    public float walkSpeed;


    private Vector3 moveDirection;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        float moveZ = Input.GetAxis("Vertical");

        moveDirection = new Vector3(0f, 0f, moveZ);
        moveDirection *= walkSpeed;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
