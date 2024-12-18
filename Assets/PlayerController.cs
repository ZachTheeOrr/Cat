using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;
    public Animator animator;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        bool isRunning = Mathf.Abs(h) > 0 || Mathf.Abs(v) > 0;
        animator.SetBool("isRunning", isRunning);

        if (isRunning)
        {
            // Calculate movement vector
            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;

            // Move the player
            rb.MovePosition(rb.transform.position + tempVect);
        }
    }
}
