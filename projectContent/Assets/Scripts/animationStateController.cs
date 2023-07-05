using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
        if (!isWalking && forwardPressed)
        {
            Debug.Log("Im walking !");
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !forwardPressed)
        {
            Debug.Log("I stop walking !");
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Im jumping");
            animator.SetTrigger("jump"); 
        }
         
    }
}
