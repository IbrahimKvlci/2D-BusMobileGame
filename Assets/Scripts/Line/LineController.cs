using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer _lr;
    private List<Vector3> _points;

    private void Awake()
    {
        _lr = GetComponent<LineRenderer>();
    }

    public void SetUpLine(List<Vector3> points)
    {
        _lr.positionCount = points.Count;
        this._points = points;
        _lr.SetPositions(_points.ToArray());
    }
}
