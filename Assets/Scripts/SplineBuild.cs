using Dreamteck.Splines;
using UnityEngine;

[RequireComponent(typeof(SplineComputer))]

public class SplineBuild : MonoBehaviour
{
    [SerializeField] private SplineComputer spline { get; set; }
    [SerializeField] private ParseXML parser;
    private float PointsSize = 1;
    private Vector3 PointsNormal = new Vector3(0, 1, 0);

    private void Awake()
    {
        spline = this.GetComponent<SplineComputer>();

    }
    void Start()
    {
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
