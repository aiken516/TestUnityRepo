using UnityEngine;

/// <summary>
/// 유니티 어트리뷰트
/// </summary>
public class ScriptExemple : MonoBehaviour
{
    [Range(1, 99)] public int Level;
    [Range(1, 99)] public int Volume;

    [Header("이름")] public string Name;
    [TextArea] public string Talk1;
    [TextArea(1, 10)] public string Talk2;
    [Tooltip("DEAD")] public bool IsDead = true;

    [ContextMenu("asd")]
    public void HelloEveryone()
    {
        Debug.Log("HELL-O");
    }
}
