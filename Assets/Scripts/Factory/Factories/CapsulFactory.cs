using UnityEngine;

public class CapsulFactory : MonoBehaviour, ICreator
{
    [SerializeField] private CapsulPrefab capsulPrefab;

    public void Instantiate(Vector3 splinePointPosition)
    {
        var instantiatePoint = GetPosition.CalculatePosition(splinePointPosition, capsulPrefab.Distanse);
        Instantiate(capsulPrefab, instantiatePoint, Quaternion.identity);
    }
}