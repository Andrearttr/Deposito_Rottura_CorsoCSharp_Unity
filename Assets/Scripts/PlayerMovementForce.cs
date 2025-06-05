using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementForce : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private bool _isOnGround = false;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetDirection();
        JumpMechanic();
    }

    void FixedUpdate()
    {
        Move();
    }

    void GetDirection()
    {
        _direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _direction += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _direction += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _direction += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _direction += Vector3.right;
        }
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }

    private void Move()
    {
        //_rigidbody.MovePosition(_rigidbody.position + _direction * _speed * Time.fixedDeltaTime);
        //_rigidbody.linearVelocity += _direction * _speed * Time.fixedDeltaTime;
        _rigidbody.AddForce(_direction * _speed, ForceMode.Force);
    }

    private void JumpMechanic()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
        {
            Jump();
        }
    }

    void OnCollisionEnter(Collision other) //chiama la funzione quando la collisione inizia (senza IsTrigger)
    {

    }

    void OnCollisionExit(Collision other) //chiama la funzione quando la collisione finisce (senza IsTrigger)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = false;
        }
    }

    void OnCollisionStay(Collision other) //chiama la funzione durante la collisione (senza IsTrigger)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = true;
        }
    }

    void OnTriggerEnter(Collider other) //chiama la funzione quando la collisione inizia con IsTrigger
    {
        
    }

    void OnTriggerStay(Collider other) //chiama la funzione quando la collisione finisce con IsTrigger
    {
        
    }

    void OnTriggerExit(Collider other) //chiama la funzione quando la collisione finisce con IsTrigger
    {
        
    }
    
}
