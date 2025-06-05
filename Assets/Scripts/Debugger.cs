using UnityEngine;

public class Debugger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"questo è un log");
        Debug.LogWarning($"Questo è un warning");
        Debug.LogError($"Questo è un error");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
