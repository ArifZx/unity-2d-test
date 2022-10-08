using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  Rigidbody2D rb;
  LayerMask walkableMask;
  bool isGrounded = false;
  [SerializeField]
  float jumpForce = 1f;
  [SerializeField]
  Transform footCollider;

  private void Awake()
  {
    rb = gameObject.GetComponent<Rigidbody2D>(); // rigidbody2D || null
    walkableMask = LayerMask.GetMask("Ground", "Player");
    Debug.Log(walkableMask.value);
    Debug.Log(2);
  }


  private void Update()
  {
    if (rb == null || footCollider == null) return;

    bool isJump = Input.GetButtonDown("Jump");
    float horizontal = Input.GetAxis("Horizontal");

    //isGrounded = rb.IsTouchingLayers(walkableMask.value);

    if (horizontal != 0f)
    {
      rb.AddForce(new Vector2(horizontal, 0));
    }


    Collider2D[] groundCol = Physics2D.OverlapCircleAll(footCollider.position, 0.28f, walkableMask);

    isGrounded = false;
    foreach (Collider2D col in groundCol)
    {
      isGrounded = col != null && col.CompareTag("Walkable");
      if (isGrounded) break;
    }

    if (isJump && isGrounded)
    {
      rb.AddForce(new Vector2(0, jumpForce));
    }
  }
}
