using UnityEngine;

/// <summary>
/// �ð��� ������ Destory
/// </summary>
public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private float _delayTime = 1f;

    private float _time;
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > _delayTime)
        { 
            Destroy(gameObject);
        }
    }
}
