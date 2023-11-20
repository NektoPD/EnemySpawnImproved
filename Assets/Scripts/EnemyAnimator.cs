using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyAnimator : MonoBehaviour
{
    private const string ConditionName = "Speed";

    private Animator _animator;
    private float _enemySpeed = 1;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat(ConditionName, _enemySpeed);
    }
}
