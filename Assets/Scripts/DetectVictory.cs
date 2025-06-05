using UnityEngine;

public class DetectVictory : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EndGoal"))
        {
            var playermovement = gameObject.GetComponent<PlayerMovementRotate>();
            playermovement.HasWon = true;
        }
    }
}
