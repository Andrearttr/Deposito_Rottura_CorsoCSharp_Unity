using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelezionePersonaggio : MonoBehaviour
{
    [SerializeField] private List<string> personaggi = new List<string>() { "Guerriero", "Mago", "Ladro" };
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Dropdown _dropdownPersonaggi;
    [SerializeField] private Sprite _guerriero;
    [SerializeField] private Sprite _mago;
    [SerializeField] private Sprite _ladro;

    private Sprite _selectedSprite;

    void Start()
    {
        _dropdownPersonaggi.ClearOptions();
        _dropdownPersonaggi.AddOptions(personaggi);
        _dropdownPersonaggi.onValueChanged.AddListener(CambiaPersonaggio);
        _dropdownPersonaggi.value = 0;
        _selectedSprite = _guerriero;
    }

    void Update()
    {
        _image.sprite = _selectedSprite;
    }

    void CambiaPersonaggio(int value)
    {
        switch (value)
        {
            case 0:
                _selectedSprite = _guerriero;
                break;
            case 1:
                _selectedSprite = _mago;
                break;
            case 2:
                _selectedSprite = _ladro;
                break;
        }
    }
}
