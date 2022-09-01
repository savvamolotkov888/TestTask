using UnityEngine;

public class CubeFactory : MonoBehaviour , ICreator
{
    [SerializeField] private CubePrefab cubePrefab ;

    public void Instantiate(Vector3 splinePointPosition)
    {
        var instantiatePoint = GetPosition.CalculatePosition(splinePointPosition, cubePrefab.Distanse);
        Instantiate(cubePrefab,instantiatePoint, Quaternion.identity);
    }
}
