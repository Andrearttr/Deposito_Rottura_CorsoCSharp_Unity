using Mono.Cecil.Cil;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class UITextUpdate : MonoBehaviour
{
    public float Timer = 0f;
    [SerializeField] private TextMeshProUGUI _timerTextObject;
    [SerializeField] private TextMeshProUGUI _defeatTextObject;
    [SerializeField] private TextMeshProUGUI _victoryTextObject;
    [SerializeField] private PlayerMovementRotate _playerMovement;

    void Awake()
    {
        _playerMovement = gameObject.GetComponent<PlayerMovementRotate>();
    }

    void Update()
    {
        if (!_playerMovement.HasWon)
        {
            Timer += Time.deltaTime;
            _timerTextObject.text = (math.round(Timer * 100) / 100).ToString();
        }
        
        if (_playerMovement.IsAlive)
        {
            _defeatTextObject.gameObject.SetActive(false);
        }
        else
        {
            _defeatTextObject.gameObject.SetActive(true);
        }

        if (_playerMovement.HasWon)
        {
            _victoryTextObject.gameObject.SetActive(true);
        }
    }
}
