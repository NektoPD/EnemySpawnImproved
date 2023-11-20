using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform _target;
    private float _moveSpeed = 3;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _moveSpeed * Time.deltaTime);
    }
}
