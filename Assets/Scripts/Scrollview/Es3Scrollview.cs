using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Es3Scrollview : MonoBehaviour
{
    [SerializeField] private Scrollbar _verticalScrollbar;
    [SerializeField] private GameObject _scrollViewContent;
    [SerializeField] private GameObject _messagePrefab;
    [SerializeField] private TMP_InputField _nameInputField;
    [SerializeField] private TMP_InputField _messageInputField;
    [SerializeField] private UnityEngine.UI.Button _button;
    private string _name = "";
    private string _message = "";

    void Start()
    {
        _nameInputField.onEndEdit.AddListener(OnNameInputFieldEnd);
        _messageInputField.onEndEdit.AddListener(OnMessageInputFieldEnd);
        _button.onClick.AddListener(OnButtonClick);
    }

    public void OnNameInputFieldEnd(string text)
    {
        _name = text;
    }

    public void OnMessageInputFieldEnd(string text)
    {
        _message = text;
    }

    public void OnButtonClick()
    {
        if (_name != "" && _message != "")
        {
            TextMeshProUGUI message = GameObject.Instantiate(_messagePrefab, _scrollViewContent.transform).GetComponent<TextMeshProUGUI>();
            message.text = $"{_name}\n{_message}";
            _name = "";
            _message = "";
            _nameInputField.text = _name;
            _messageInputField.text = _message;
            _verticalScrollbar.value = 0;
        }
    }
}
