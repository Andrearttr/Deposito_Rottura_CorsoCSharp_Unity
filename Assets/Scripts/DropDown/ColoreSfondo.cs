using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColoreSfondo : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _sfondoDropdown;
    [SerializeField] private Image _panel;
    [SerializeField] private Color _color = new Color(0.7f, 0.2f, 0.2f);

    void Start()
    {
        _sfondoDropdown.onValueChanged.AddListener(CambiaColore);
    }

    void Update()
    {
        _panel.color = _color;
    }

    void CambiaColore(int valore)
    {
        switch (valore)
        {
            case 0:
                _color = new Color(0.7f, 0.2f, 0.2f);
                break;
            case 1:
                _color = new Color(0.2f, 0.7f, 0.2f);
                break;
            case 2:
                _color = new Color(0.2f, 0.2f, 0.7f);
                break;
        }
    }
}
