using UnityEngine;

public class SnakeAI : MonoBehaviour
{
    public float reactionDistance = 5f; // Distance at which snake reacts to sound
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("lizzard").transform; // Assuming the lizard is tagged as "Player"
    }

    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget < reactionDistance)
        {
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            transform.rotation = Quaternion.LookRotation(directionToTarget);
        }
    }
}