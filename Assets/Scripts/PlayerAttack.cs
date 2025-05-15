using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackCooldown = 1f;
    private float nextAttackTime = 0f;
    private Animator animator;
    private int attackIndex = 1;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + attackCooldown;
        }

    }

    void Attack()
    {
        Debug.Log($"Attack {attackIndex}!");
        animator.SetInteger("AttackIndex", attackIndex);
        animator.SetTrigger("Attack");

        attackIndex = (attackIndex == 1) ? 2 : 1;
    }
}
