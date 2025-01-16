using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _targetRotation;
    [SerializeField] private float _duration;

    private int _loopsAmount = -1;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.
            DORotate(_targetRotation, _duration, RotateMode.LocalAxisAdd).
            SetEase(Ease.Linear).
            SetLoops(_loopsAmount, LoopType.Incremental);
    }
}