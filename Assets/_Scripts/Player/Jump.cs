using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _jumpForce = 150.0f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _rigidbody.AddForce(0, _jumpForce, 0);
        }
    }
}
