using UnityEngine;

public sealed class CubePrefab : PrefabAtributs
{
    [SerializeField] private float distanse = 5;
    public override float Distanse
    {
        get => distanse;
        set => distanse = value;
    }
}
