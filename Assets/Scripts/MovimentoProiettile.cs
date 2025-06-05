using UnityEngine;

public class MovimentoProiettile : MonoBehaviour
{
    [SerializeField] private float _projectileSpeed = 50f; 
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * _projectileSpeed, ForceMode.Impulse);
        Destroy(gameObject, 5);
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
