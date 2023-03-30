using UnityEngine;

public class MoveGround : MonoBehaviour
{
    private float _speed = 2f;

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
