using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float movementSpeed = 1, jumpForce = 1;
    public LayerMask castLayer;

    private Rigidbody2D rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rbody.velocity.y);

        bool isGrounded = CheckForGround();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        //El codigo del salto va aqui
        rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);
        //rbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private bool CheckForGround()
    {
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, 1, Vector2.down, 0.6f, castLayer);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Floor"))
            {
                return true;
            }
        }

        return false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector2.down * 0.6f);
    }
}