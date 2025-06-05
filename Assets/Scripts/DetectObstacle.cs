using UnityEngine;

public class DetectObstacle : MonoBehaviour
{
    [SerializeField] private Transform _spawnpoint;


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            transform.position = _spawnpoint.position;
            transform.rotation = _spawnpoint.rotation;
        }
    }
}
