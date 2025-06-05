using Unity.Mathematics;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Color _color;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject cubeInstance = Instantiate(_cubePrefab, _spawnPoint.position, quaternion.identity);
            cubeInstance.GetComponent<MeshRenderer>().material.color = _color;
        }
    }
}
