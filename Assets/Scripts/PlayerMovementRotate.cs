using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementRotate : MonoBehaviour
{
    [SerializeField] public float Speed = 5f;
    [SerializeField] public float RotationSpeed = 5f;
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private Vector3 _direction;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private bool _isOnGround = false;
    [SerializeField] private float _jumpForce = 5f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
        JumpMechanic();
        transform.Rotate(_rotation * RotationSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _direction * Speed * Time.fixedDeltaTime);
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = false;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isOnGround = true;
        }
    }

    private void Movement()
    {
        _direction = Vector3.zero;
        _rotation = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _direction += transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _direction -= transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(0, -1, 0);
            _rotation -= transform.up;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(0, 1, 0);
            _rotation += transform.up;
        }
    }

    private void JumpMechanic()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}
