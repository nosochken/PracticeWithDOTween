using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Text _text;
    private Sequence _sequence;
    private int _loopsAmount = -1;

    private void Start()
    {
        _text = GetComponent<Text>();
        _sequence = DOTween.Sequence();

        ChangeText();
    }

    private void ChangeText()
    {
        _sequence.Append(_text.DOText("old text", _duration));
        _sequence.Append(_text.DOText("new text", _duration));
        _sequence.Append(_text.DOText(" became old again", _duration).SetRelative());
        _sequence.Append(_text.DOText("none of this matters", _duration, true, ScrambleMode.All));

        _sequence.SetLoops(_loopsAmount, LoopType.Restart);
    }
}