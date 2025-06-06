using TMPro;
using UnityEngine;

public class SelezioneDifficolta : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _dropdownDifficolta;
    [SerializeField] private int _difficolta = 1;
    [SerializeField] private TextMeshProUGUI _difficoltaText;

    void Start()
    {
        _dropdownDifficolta.onValueChanged.AddListener(CambiaDifficolta);
    }

    void Update()
    {
        switch (_difficolta)
        {
            case 0:
                _difficoltaText.text = "I nemici sono meno attenti e attaccano con minore frequenza.";
                break;
            case 1:
                _difficoltaText.text = "I nemici sono abbastanza attenti e attaccano normalemnte.";
                break;
            case 2:
                _difficoltaText.text = "I nemici ti notano all'istante e attaccano insistentemente.";
                break;
        }
    }

    void CambiaDifficolta(int difficolta)
    {
        _difficolta = difficolta;
    }
}
