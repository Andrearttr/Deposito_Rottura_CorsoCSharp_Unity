using UnityEngine;

public class DetectEndGoal : MonoBehaviour
{
    [SerializeField] private Transform _victoryPoint;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EndGoal"))
        {
            transform.position = _victoryPoint.position;
            transform.rotation = _victoryPoint.rotation;
        }
    }
}
