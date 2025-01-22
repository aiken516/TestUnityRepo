using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private Vector3 _position;

    void Start()
    {
        _position = _gameObject.transform.position;
    }

    private void OnDestroy()
    {
        GameObject go = Instantiate(_gameObject);
        go.transform.position = _position;
        go.SetActive(true);
    }
}
