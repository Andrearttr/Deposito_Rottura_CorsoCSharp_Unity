using Unity.VisualScripting;
using UnityEngine;

public class DoubleSpeedPortal : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.gameObject.GetComponent<PlayerMovement>();
            playerMovement.Speed *= 2;
        }
    }
}
