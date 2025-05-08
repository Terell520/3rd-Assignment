using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;

    public Transform Anna;

    public LayerMask whosanna, ground;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public bool walkPointRange;
}
