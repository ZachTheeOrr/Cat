using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;
    private PlayerSpriteFlip spriteFlip;
    private GameObject player;
    [SerializeField] private float distance;
    [SerializeField] private float speed;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        agent.speed = speed;
        agent.stoppingDistance = distance;

        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;

        spriteFlip = GetComponent<PlayerSpriteFlip>();
    }

    void Update()
    {
        agent.SetDestination(target.position);
        float horizontalDirection = player.transform.position.x - transform.position.x;
        spriteFlip.FlipSprite(horizontalDirection);
    }
}
