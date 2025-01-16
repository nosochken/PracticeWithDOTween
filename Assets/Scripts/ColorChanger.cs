using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;

    private int _loopsAmount = -1;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();

        ChangeColor();
    }

    private void ChangeColor()
    {
        _renderer.material.
            DOColor(_targetColor, _duration).
            SetEase(Ease.Linear).
            SetLoops(_loopsAmount, LoopType.Yoyo);
    }
}