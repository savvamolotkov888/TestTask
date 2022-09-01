using UnityEngine;

public class SphereFactory :  MonoBehaviour, ICreator
{
    [SerializeField] private SpherePrefab spherePrefab;

    public void Instantiate(Vector3 splinePointPosition)
    {
        var instantiatePoint = GetPosition.CalculatePosition(splinePointPosition, spherePrefab.Distanse);
        Instantiate(spherePrefab, instantiatePoint, Quaternion.identity);
    }
}