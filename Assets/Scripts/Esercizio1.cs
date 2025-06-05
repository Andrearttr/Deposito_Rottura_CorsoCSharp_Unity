using Unity.Mathematics;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public Vector3 Direzione;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _forwardSpeed;
    [SerializeField] private float _sideSpeed;
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Transform _spawnPoint;

    void Awake()
    {
        Debug.Log("Awake");
        _rigidbody = GetComponent<Rigidbody>();
    }

    void OnEnable() => Debug.Log("OnEnable");

    void Start() => Debug.Log("Start");

    void Update()
    {
        Debug.Log("Update");
        Debug.Log($"Global Position: {transform.position}");
        Debug.Log($"Local Position: {transform.localPosition}");
        MovimentoLaterale();
        MovimentoFrontale();
        GenerateCube();
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
        _rigidbody.MovePosition(_rigidbody.position + Direzione * _sideSpeed * Time.fixedDeltaTime);
    }

    void LateUpdate() => Debug.Log("LateUpdate");

    void OnDisable() => Debug.Log("OnDisable");

    void OnDestroy() => Debug.Log("OnDestroy");

    public void MovimentoLaterale()
    {
        Direzione = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            Direzione += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Direzione += Vector3.right;
        }
    }

    public void MovimentoFrontale()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * _forwardSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * _forwardSpeed * Time.fixedDeltaTime;
        }
    }

    public void GenerateCube()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_cubePrefab, _spawnPoint.position, quaternion.identity);
        }
    }
}
