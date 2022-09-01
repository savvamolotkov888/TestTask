using UnityEngine;

public sealed class SpherePrefab : PrefabAtributs
{
    [SerializeField] private float distanse = 10;
    public override float Distanse
    {
        get => distanse;
        set => distanse = value;
    }
}
