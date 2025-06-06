using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EsercizioToggle : MonoBehaviour
{
    [Header("Banana")]
    [SerializeField] private Toggle _bananaToggle;
    [SerializeField] private GameObject _banana;
    [SerializeField] private TextMeshProUGUI _bananaToggleText;
    [Header("InfoPanel")]
    [SerializeField] private Toggle _infoToggle;
    [SerializeField] private TextMeshProUGUI _infoToggleText;
    [SerializeField] private GameObject _infoPanel;
    [Header("Colori")]
    [SerializeField] private Toggle _redToggle;
    [SerializeField] private Toggle _greenToggle;
    [SerializeField] private Toggle _blueToggle;
    [SerializeField] private GameObject _redPanel;
    [SerializeField] private GameObject _greenPanel;
    [SerializeField] private GameObject _bluePanel;
    [SerializeField] private TextMeshProUGUI _colorText;

    void Start()
    {
        _bananaToggle.onValueChanged.AddListener(ToggleBanana);
        _bananaToggle.isOn = false;
        _infoToggle.onValueChanged.AddListener(ToggleInfoPanel);
        _infoToggle.isOn = false;
        _redToggle.onValueChanged.AddListener(ShowRed);
        _redToggle.isOn = false;
        _greenToggle.onValueChanged.AddListener(ShowGreen);
        _greenToggle.isOn = false;
        _blueToggle.onValueChanged.AddListener(ShowBlue);
        _blueToggle.isOn = false;
        _colorText.text = "";
    }

    void Update()
    {
        if (_bananaToggle.isOn)
        {
            _bananaToggleText.text = "Banana";
        }
        else
        {
            _bananaToggleText.text = "Off";
        }

        if (_infoToggle.isOn)
        {
            _infoToggleText.text = "It's a banana";
        }
        else
        {
            _infoToggleText.text = "Info";
        }
    }
    void ToggleBanana(bool value)
    {
        _banana.gameObject.SetActive(value);
    }

    void ToggleInfoPanel(bool value)
    {
        _infoPanel.gameObject.SetActive(value);
    }

    void ShowRed(bool value)
    {
        _redPanel.gameObject.SetActive(value);
    }
    void ShowGreen(bool value)
    {
        _greenPanel.gameObject.SetActive(value);
    }
    void ShowBlue(bool value)
    {
        _bluePanel.gameObject.SetActive(value);
    }
}
