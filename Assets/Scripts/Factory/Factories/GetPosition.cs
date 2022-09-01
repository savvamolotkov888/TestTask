using UnityEngine;

public static class GetPosition
{
    public static Vector3 CalculatePosition(Vector3 splinePointPossition, float prefabDistanse)
    {
        var result = new Vector3(splinePointPossition.x + prefabDistanse, splinePointPossition.y, splinePointPossition.z);
        return result;
    }
}
