using UnityEngine;

public sealed class CapsulPrefab : PrefabAtributs
{
    [SerializeField] private float distanse = 15;
    public override float Distanse
    {
        get => distanse;
        set => distanse = value;
    }
}
