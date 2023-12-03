using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Animator anim;
    public Transform player;
    void Start()
    {
        // StartCoroutine(JumpForward());
    }

    void Update()
    {
        ai.destination = player.position;
        ai.speed = 5.5f;
        anim.speed = 0.5f;
    }

    // IEnumerator JumpForward()
    // {
    //     yield return new WaitForSeconds(2f);
    //     GetComponent<Rigidbody>().AddForce((transform.forward + transform.up) * 7f, ForceMode.Impulse);
    // }
}
