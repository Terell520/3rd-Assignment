using UnityEngine;

public class States : MonoBehaviour
{
    public enum PlayerState
    {
        Idle = 0,
        Running = 1,
        Attacking = 2,
        Skillattk = 3,
        Dead = 4
    }

    public PlayerState State = PlayerState.Idle;
}
