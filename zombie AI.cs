using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float attackRange = 1.5f; // The range at which the zombie will attack
    public float moveSpeed = 2f; // The speed at which the zombies will move

    void Update()
    {
        // Get the distance between the zombie and the player
        float distance = Vector3.Distance(player.position, transform.position);

        // If the distance is less than or equal to the attack range
        if (distance <= attackRange)
        {
            // Attack the player
            Attack();
        }
        else
        {
            // Move towards the player
            MoveTowardsPlayer();
        }
    }

    void Attack()
    {
        // Code for the zombie attacking the player
    }

    void MoveTowardsPlayer()
    {
        // Move towards the player
        transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
}
