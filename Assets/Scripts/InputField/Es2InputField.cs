using System.Data.Common;
using TMPro;
using UnityEngine;

public class Es2InputField : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private int _higherThan = 100;

    void Start()
    {
        _inputField.onEndEdit.AddListener(IsHigher);
    }

    public void IsHigher(string text)
    {
        if (long.Parse(text) > _higherThan)
        {
            _text.text = $"Maggiore di {_higherThan}";
        }
        else
        {
            _text.text = $"Minore di {_higherThan}";
        }
    }
}
