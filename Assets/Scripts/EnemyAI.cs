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
    }

    void Update()
    {
        ai.destination = player.position;
        ai.speed = 3.5f;
        anim.speed = 0.5f;
    }
}
