using System;
using UnityEngine;

[Flags]
public enum FRUIT
{ 
    none = 0,
    apple = 1 << 0,
    banana = 1 << 1,
    orange = 1 << 2,
}

public enum RAINBOW
{ 
    빨, 주, 노, 초, 파, 남, 보
}

    
public class Sample01 : MonoBehaviour
{
    [SerializeField] public bool IsCanJump;
    [SerializeField] public FRUIT FruitBasket;
    [SerializeField] public int Money;
    [Range(1, 99)] [SerializeField] public float FieldView;
    [SerializeField] public RAINBOW Rainbow;
}
