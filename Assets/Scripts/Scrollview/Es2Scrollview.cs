using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Es2Scrollview : MonoBehaviour
{
    [SerializeField] private GameObject _scrollViewContent;
    [SerializeField] private GameObject _buttonPrefab;
    [SerializeField] private int _elementNum = 20;

    void Start()
    {
        for (int i = 0; i < _elementNum; i++)
        {
            GameObject buttonObject = GameObject.Instantiate(_buttonPrefab, _scrollViewContent.transform);
            UnityEngine.UI.Button button = buttonObject.GetComponent<UnityEngine.UI.Button>();
            button.GetComponentInChildren<TextMeshProUGUI>().text = $"{i + 1}";
            button.onClick.AddListener(() => Debug.Log($"Bottone {int.Parse(button.GetComponent<UnityEngine.UI.Button>().GetComponentInChildren<TextMeshProUGUI>().text)} premuto"));
        }
    }
}
