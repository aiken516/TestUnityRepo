using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _spawnDelay;

    private float _spawnTime;

    void Update()
    {
        _spawnTime += Time.deltaTime;
        if (_spawnTime > _spawnDelay)
        {
            _spawnTime = 0f;
            GameObject go = Instantiate(_gameObject, transform.position, transform.localRotation);
        }
    }
}
