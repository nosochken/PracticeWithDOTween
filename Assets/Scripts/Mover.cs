using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;

    private int _loopsAmount = -1;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.
            DOMove(_targetPosition, _duration).
            SetEase(Ease.Linear).
            SetLoops(_loopsAmount, LoopType.Yoyo);
    }
}