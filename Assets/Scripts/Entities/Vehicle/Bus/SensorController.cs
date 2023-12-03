using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorController : MonoBehaviour, ISensor
{
    [SerializeField] Transform[] _sensors;

    [SerializeField] LayerMask _layerMask;

    [SerializeField] float _distance;

    public bool IsSensed()
    {
        RaycastHit2D hit0 = Physics2D.Raycast(_sensors[0].transform.position, _sensors[0].transform.right, _distance, _layerMask);
        RaycastHit2D hit1 = Physics2D.Raycast(_sensors[1].transform.position, _sensors[1].transform.right, _distance, _layerMask);
        RaycastHit2D hit2 = Physics2D.Raycast(_sensors[2].transform.position, _sensors[2].transform.right, _distance, _layerMask);
        RaycastHit2D hit3 = Physics2D.Raycast(_sensors[3].transform.position, _sensors[3].transform.right, _distance, _layerMask);



        if ((hit0.collider && hit1.collider != null)&&(hit2.collider&&hit3.collider!=null))
        {
            return true;
        }
        return false;
    }

}
