using UnityEngine;

/// <summary>
/// ť�� ȸ��
/// </summary>
public class CubeRotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;  

    // Update is called once per frame
    void Update()   
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
