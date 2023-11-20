using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform _path;
    private Transform[] _points;
    private float _speed = 3;

    private int _currentPoint;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for(int i = 0; i < _points.Length; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if(transform.position == target.position)
        {
            _currentPoint++;

            if(_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
