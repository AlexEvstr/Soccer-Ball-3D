using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _jumpForce = 150.0f;
    public bool _isGround;

    private void Start()
    {
        _isGround = false;
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && _isGround)
        {
            _rigidbody.AddForce(0, _jumpForce, 0);
            _isGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGround = true;
        }
    }
}
