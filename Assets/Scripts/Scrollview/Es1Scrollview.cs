using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Es1Scrollview : MonoBehaviour
{
    [SerializeField] private GameObject _scrollViewContent;
    [SerializeField] private TextMeshProUGUI _textPrefab;
    [SerializeField] private int _elementNum = 10;

    void Start()
    {
        for (int i = 0; i < _elementNum; i++)
        {
            TextMeshProUGUI textMesh = GameObject.Instantiate(_textPrefab, _scrollViewContent.transform);
            textMesh.text = $"Testo {i+1}";
        }
    }
}
