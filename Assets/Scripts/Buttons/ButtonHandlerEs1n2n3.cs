using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandlerEs1n2n3 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _finestraConferma;
    private int _score = 0;

    void Update()
    {
        _scoreText.text = $"Score: {_score}";
    }
    public void PremiQui()
    {
        Debug.Log("Bottone premuto");
    }

    public void Auemnta()
    {
        _score++;
    }

    public void Riduci()
    {
        if (_score > 0)
        {
            _score--;
        }
    }

    public void FinestraApri()
    {
        _finestraConferma.gameObject.SetActive(true);
    }

    public void FinestraConferma()
    {
        Debug.Log("Confermato");
        _finestraConferma.gameObject.SetActive(false);
    }

    public void FinestraAnnulla()
    {
        _finestraConferma.gameObject.SetActive(false);
    }
}
