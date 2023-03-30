using UnityEngine;

public class SpawnerGround : MonoBehaviour
{
    [SerializeField] GameObject[] _groundPrafabs;
    [SerializeField] GameObject _player;
    private int _prefabIndex;

    private void OnCollisionExit(Collision collision)
    {
        _prefabIndex = Random.Range(0, _groundPrafabs.Length);
        var ground = Instantiate(_groundPrafabs[_prefabIndex]);
        ground.transform.position = new Vector3(_player.transform.position.x + 5.5f, -2.85f, 0);
    }
}
