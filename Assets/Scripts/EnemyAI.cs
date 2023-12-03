using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Animator anim;
    public Transform player;
    Vector3 target;
    void Start()
    {
        StartCoroutine(JumpForward());
    }

    void Update()
    {
        target = player.position;
        ai.destination = target;
        ai.speed = 5.5f;
        anim.speed = 5.5f;
    }

    IEnumerator JumpForward()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<Rigidbody>().AddForce((transform.forward + transform.up) * 7f, ForceMode.Impulse);
    }
}
