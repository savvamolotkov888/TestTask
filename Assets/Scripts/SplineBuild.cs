using Dreamteck.Splines;
using UnityEngine;

[RequireComponent(typeof(SplineComputer))]
[RequireComponent(typeof(SplinePositioner))]

public class SplineBuild : MonoBehaviour
{
    public SplineComputer spline { get; private set; }
    [SerializeField] private ParseXML parser;
    private float PointsSize = 1;
    private Vector3 PointsNormal = new Vector3(0, 1, 0);

    private void Awake()
    {
        spline = this.GetComponent<SplineComputer>();
        Build(spline, ref parser);
    }
  

    private void Build(SplineComputer spline, ref ParseXML dotObj)
    {
        for (var i = 0; i < dotObj.DotList.Count; i++)
        {
            spline.SetPointPosition(i, parser.DotList[i]);//����� �������
            spline.SetPointSize(i, PointsSize);// ����� ������ �����
            spline.SetPointNormal(i, PointsNormal);//����� �������
        }
    }
}
