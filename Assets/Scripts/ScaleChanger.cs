using DG.Tweening;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;

    private int _loopsAmount = -1;

    private void Start()
    {
        ChangeScale();
    }

    private void ChangeScale()
    {
        transform.
            DOScale(_targetScale, _duration).
            SetLoops(_loopsAmount, LoopType.Yoyo).
            SetEase(Ease.Linear);
    }
}