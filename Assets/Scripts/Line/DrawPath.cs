using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour
{
    [SerializeField] LineController _lineController;
    [SerializeField] GameObject _parentOfPath;

    List<Vector3> _points = new List<Vector3>();

    GameObject _pathGameObject;
    

    Vector2 _mousePosition;
    
    bool _firstClick, _canDraw;

    private void Start()
    {
        _firstClick = false;
        _canDraw = true;
        
    }

    private void Update()
    {
        _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && !_firstClick)
        {
            RaycastHit2D hit = Physics2D.Raycast(_mousePosition, Vector2.zero);

            if (hit.collider!=null)
            {
                if(hit.transform.gameObject == gameObject)
                {
                    ResetPath();
                    CreatePath();
                    _firstClick = true;
                    _canDraw = true;
                }
                
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (_canDraw && _firstClick && Vector3.Distance(_mousePosition, _pathGameObject.transform.position) > 0.2f)
            {
                CreatePath();
                _lineController.SetUpLine(_points);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            
            if (_firstClick)
            {
                _canDraw = false;
                _firstClick = false;
            }
        }

    }

    void CreatePath()
    {
        _pathGameObject = new GameObject();
        _pathGameObject.transform.parent = _parentOfPath.transform;
        _pathGameObject.transform.position = _mousePosition;
        _points.Add(_pathGameObject.transform.position);
        _lineController.SetUpLine(_points);
    }

    void ResetPath()
    {
        _points.Clear();
        for (int i = 0; i < _parentOfPath.transform.childCount; i++)
        {
            Destroy(_parentOfPath.transform.GetChild(i).gameObject);
        }
    }
}
