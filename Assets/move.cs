using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;

    private void Update()
    {
        float horizontallnput = Input.GetAxisRaw("Horizontal");
        Vector3 movement =
        new Vector3(horizontallnput, 0f, 0f) *moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        if (horizontallnput > 0) // 오른쪽으로 움직일 때
        {
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("run", true);
        }
        else if (horizontallnput < 0) // 왼쪽으로 이동할 때
        {
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }

    }
}
