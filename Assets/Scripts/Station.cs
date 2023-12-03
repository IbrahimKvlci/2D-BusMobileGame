using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour, IStation
{
    [SerializeField] float timeToGetPassenger;

    BusController busController;
    ISensor sensor;

    float timer = 0;
    bool isBusInside = false;

    public void GetPassenger(GameObject passenger)
    {
        HumanPooling.Instance.GameObjectPool.Remove(passenger);
        HumanPooling.Instance.ActiveGameObjects.Remove(passenger);
        Destroy(passenger);
    }

    private void Update()
    {
        if (isBusInside)
        {
            if (sensor.IsSensed())
            {
                busController.CanMove = false;
                if (HumanPooling.Instance.GameObjectPool.Count > 0)
                {
                    timer += Time.deltaTime;
                    if (timer > timeToGetPassenger)
                    {
                        if (HumanPooling.Instance.ActiveGameObjects.Count > 0)
                        {
                            GetPassenger(HumanPooling.Instance.ActiveGameObjects[0]);

                        }
                        timer = 0;
                    }
                    print("c");
                }
                else
                {
                    busController.CanMove = true;
                }
                print("b");
            }
            
        }
        print(isBusInside);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bus"))
        {
            busController = collision.GetComponent<BusController>();
            sensor = collision.gameObject.GetComponentInChildren<ISensor>();
            isBusInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isBusInside = false;
    }

}
