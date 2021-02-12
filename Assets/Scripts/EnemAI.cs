using UnityEngine;
using UnityEngine.AI;

public class EnemAI : MonoBehaviour
{
    public enum EnemyState
    {
        Patroling,
        Attacking,
        Death
    }

    public EnemyState currentState;

    private void Start()
    {
        currentState = EnemyState.Patroling;
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Patroling:
                break;
            case EnemyState.Attacking:
                break;
            case EnemyState.Death:
                break;
        }
    }
}
