using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed = 10f;

    private void Start()
    {
        targetPoint = 0;
    }

    private void Update()
    { 
        if (Vector3.Distance(transform.position, patrolPoints[targetPoint].position)<= 0.1)
        {
            increaseTargetInt();
        }
        transform.position = Vector3.Lerp(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
    }

    void increaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }
}
