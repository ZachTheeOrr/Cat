using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float speed;
    //[SerializeField] private float distanceBetween;
    [SerializeField] private float distanceBetweenPlayerAndEnemy;
    private float distance;
    private PlayerSpriteFlip spriteFlip;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spriteFlip = GetComponent<PlayerSpriteFlip>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        //Vector2 direction = player.transform.position - transform.position;
        float horizontalDirection = player.transform.position.x - transform.position.x;
        //direction.Normalize();
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance > distanceBetweenPlayerAndEnemy)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            spriteFlip.FlipSprite(horizontalDirection);
        }
    }
}
