using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    [SerializeField] private string _messaggioAwake;

    void Awake()                                        //chiamato quando lo script è instanziato
    {
        Debug.Log($"Awake: {_messaggioAwake}"); 
    }                 
    void OnEnable() => Debug.Log("OnEnable");           //chiamato ogni volta che l'oggetto è abilitato
    void Start() => Debug.Log("Start");                 //chiamato prima del primo frame, dopo OnEnable
    void Update() => Debug.Log("Update");               //chiamato a ogni frame
    void FixedUpdate() => Debug.Log("FixedUpdate");     //chiamato a intervalli fissi
    void LateUpdate() => Debug.Log("LateUpdate");       //chiamato dopo ogni update
    void OnDisable() => Debug.Log("OnDisable");         //chiamato ogni volta che l'oggetto è disabilitato
    void OnDestroy() => Debug.Log("OnDestroy");         //chiamato quando l'oggetto è distrutto
}
