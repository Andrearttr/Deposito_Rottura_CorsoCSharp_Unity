using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Es1InputField : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    void Start()
    {
        _inputField.onEndEdit.AddListener(DisplayName);
    }

    public void DisplayName(string text)
    {
        _textMeshPro.text = text;
    }
}
