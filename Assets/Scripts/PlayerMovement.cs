using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float Speed = 5f;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private bool _isOnGround = false;
    [SerializeField] private float _jumpForce = 5f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
    }

    void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _direction * Speed * Time.fixedDeltaTime);
    }

    private void Movement()
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

    private void JumpMechanic()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
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
}
