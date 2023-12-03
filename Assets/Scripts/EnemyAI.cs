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

    void Update()
    {
        target = player.position;
        ai.destination = target;
        ai.speed = 1.5f;
        anim.speed = 0.2f;
    }
}
