using Unity.Mathematics;
using UnityEngine;

public class GeneratoreProiettili : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;
    private GameObject projectileInstance;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            projectileInstance = Instantiate(_projectilePrefab, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}
