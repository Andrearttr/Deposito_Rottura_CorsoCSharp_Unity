using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class GestoreUI : MonoBehaviour
{
    [Header("Volume")]
    [SerializeField] public int _volume = 0;
    [SerializeField] private TextMeshProUGUI _volumeText;
    [SerializeField] private Slider _volumeSlider;
    [Header("Brightness")]
    [SerializeField] public float _brightness = 1;
    [SerializeField] private TextMeshProUGUI _brightnessText;
    [SerializeField] private Slider _brightnessSlider;
    [SerializeField] private Light _directionalLight;
    [Header("Cube Scale")]
    [SerializeField] private GameObject _cube;
    [SerializeField] private TextMeshProUGUI _scaleXText;
    [SerializeField] private TextMeshProUGUI _scaleYText;
    [SerializeField] private TextMeshProUGUI _scaleZText;
    [SerializeField] private Slider _scaleXSlider;
    [SerializeField] private Slider _scaleYSlider;
    [SerializeField] private Slider _scaleZSlider;
    [SerializeField] private float _scaleX = 1;
    [SerializeField] private float _scaleY = 1;
    [SerializeField] private float _scaleZ = 1;
    [SerializeField] private GameObject _scaleMenu;
    [SerializeField] private Button _scaleButton;
    [SerializeField] private Button _resetButton;

    void Start()
    {
        _volumeSlider.onValueChanged.AddListener(GestioneVolume);
        _brightnessSlider.onValueChanged.AddListener(GestioneBrightness);
        _scaleXSlider.onValueChanged.AddListener(GestioneScaleX);
        _scaleYSlider.onValueChanged.AddListener(GestioneScaleY);
        _scaleZSlider.onValueChanged.AddListener(GestioneScaleZ);
        _scaleButton.onClick.AddListener(ShowScaleMenu);
        _resetButton.onClick.AddListener(ResetScale);
        _scaleMenu.gameObject.SetActive(false);
    }
    void Update()
    {
        _brightnessSlider.value = _directionalLight.intensity;
        _scaleXSlider.value = _cube.transform.localScale.x;
        _scaleYSlider.value = _cube.transform.localScale.y;
        _scaleZSlider.value = _cube.transform.localScale.z;
    }
    void GestioneVolume(float volume)
    {
        _volume = (int)volume;
        _volumeText.text = $"Volume: {_volume}";
    }

    void GestioneBrightness(float brightness)
    {
        _brightness = brightness;
        _directionalLight.intensity = _brightness;
        _brightnessText.text = $"Brightness: {math.round(_brightness * 100) / 100}";
    }

    void GestioneScaleX(float scaleX)
    {
        _scaleX = scaleX;
        _scaleXText.text = $"Scale X: {math.round(_scaleX * 100) / 100}";
        _cube.transform.localScale = new Vector3(_scaleX, _scaleY, _scaleZ);
    }
    void GestioneScaleY(float scaleY)
    {
        _scaleY = scaleY;
        _scaleYText.text = $"Scale Y: {math.round(_scaleY * 100) / 100}";
        _cube.transform.localScale = new Vector3(_scaleX, _scaleY, _scaleZ);
    }
    void GestioneScaleZ(float scaleZ)
    {
        _scaleZ = scaleZ;
        _scaleZText.text = $"Scale Z: {math.round(_scaleZ * 100) / 100}";
        _cube.transform.localScale = new Vector3(_scaleX, _scaleY, _scaleZ);
    }

    void ShowScaleMenu()
    {
        if (_scaleMenu.gameObject.activeSelf)
        {
            _scaleMenu.gameObject.SetActive(false);
        }
        else
        {
            _scaleMenu.gameObject.SetActive(true);
        }
    }

    void ResetScale()
    {
        _scaleXSlider.value = 1;
        _scaleYSlider.value = 1;
        _scaleZSlider.value = 1;
    }
}
