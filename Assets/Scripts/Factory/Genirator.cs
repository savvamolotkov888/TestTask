using Dreamteck.Splines;
using System.Collections;
using UnityEngine;

public class Genirator : MonoBehaviour
{
    [SerializeField] private CubeFactory cubeFactory;
    [SerializeField] private SphereFactory sphereFactory;
    [SerializeField] private CapsulFactory capsulFactory;
    [SerializeField] private ParseXML parser;
    [SerializeField] private SplineBuild splineObj;
    [SerializeField] private SplinePositioner splinePositioner;
    [SerializeField] private Transform distancePoint;
    [Header("Delay between objects Instantiate")]
    [SerializeField] private float delay = 1; //�������� ���������� �.� ����� ������ SetDistance �� ������ ��������
    private float timer = 0;

    void Start()
    {
        //��������� ������� �� ��������� ����������� ����� �������,
        //�������� ������� � �������
        StartCoroutine(GetDistancePointPossition(50, cubeFactory));
        StartCoroutine(GetDistancePointPossition(100, sphereFactory));
        StartCoroutine(GetDistancePointPossition(150, capsulFactory));

        //��������� ������� �� ��������� ����� ������� ��� ������
        cubeFactory.Instantiate(GetPointPossition(0));
        sphereFactory.Instantiate(GetPointPossition(10));
        capsulFactory.Instantiate(GetPointPossition(6));
    }
    private Vector3 GetPointPossition(in int pointIndex)
    {
        return parser.DotList[pointIndex];
    }
    private IEnumerator GetDistancePointPossition<T>(float length, T factory) where T : ICreator
    {
        timer += delay;
        yield return new WaitForSeconds(timer);
        splinePositioner.SetDistance(length);
        var dotVector = new Vector3(distancePoint.position.x, distancePoint.position.y, distancePoint.position.z);
        factory.Instantiate(dotVector);
    }
}
