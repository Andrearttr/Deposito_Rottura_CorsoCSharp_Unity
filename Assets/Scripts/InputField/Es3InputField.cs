using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Es3InputField : MonoBehaviour
{
    [SerializeField] private TMP_InputField _InputFieldName;
    [SerializeField] private TMP_InputField _InputFieldEmail;
    [SerializeField] private TMP_InputField _InputFieldMessage;
    [SerializeField] private Button _button;
    [SerializeField] private TextMeshProUGUI _confirmText;
    private string _nameText = "";
    private string _emailText = "";
    private string _messageText = "";
    private ColorBlock _invaidColorBlock = new ColorBlock();

    void Start()
    {
        _InputFieldName.onEndEdit.AddListener(SaveName);
        _InputFieldEmail.onEndEdit.AddListener(SaveEmail);
        _InputFieldMessage.onEndEdit.AddListener(SaveMessage);
        _button.onClick.AddListener(CheckFields);
        _invaidColorBlock = ColorBlock.defaultColorBlock;
        _invaidColorBlock.normalColor = new Color(1, 0.5f, 0.5f);
    }

    public void SaveName(string text)
    {
        _nameText = text;
        _InputFieldName.colors = ColorBlock.defaultColorBlock;
    }
    public void SaveEmail(string text)
    {
        _emailText = text;
        _InputFieldEmail.colors = ColorBlock.defaultColorBlock;
    }
    public void SaveMessage(string text)
    {
        _messageText = text;
        _InputFieldMessage.colors = ColorBlock.defaultColorBlock;
    }

    public void CheckFields()
    {
        _InputFieldName.colors = ColorBlock.defaultColorBlock;
        _InputFieldEmail.colors = ColorBlock.defaultColorBlock;
        _InputFieldMessage.colors = ColorBlock.defaultColorBlock;

        if (_nameText != "" && _emailText != "" && _messageText != "")
        {
            _confirmText.text = "Inviato";
        }
        else
        {
            _confirmText.text = "";
            if (_nameText == "")
            {
                _InputFieldName.colors = _invaidColorBlock;
            }
            if (_emailText == "")
            {
                _InputFieldEmail.colors = _invaidColorBlock;
            }
            if (_messageText == "")
            {
                _InputFieldMessage.colors = _invaidColorBlock;
            }
        }
    }

}
