using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour, IStation
{

    [SerializeField] HumanSpawner humanSpawner;
    [SerializeField] float timeToGetPassenger;
    [SerializeField] int countOfPassenger;

    GameObject bus;
    ISensor sensor;

    

    float timer = 0;

    public int CountOfPassenger
    {
        get { return countOfPassenger; }
        set { countOfPassenger = value; }
    }


    public HumanSpawner HumanSpawner
    {
        get
        {
            return humanSpawner;
        }
        set { humanSpawner = value;}
    }

    private void Update()
    {

        if(sensor != null)
        {
            if (sensor.IsSensed())
            {
                bus.GetComponent<BusController>().CanMove = false;
                if (countOfPassenger > 0)
                {
                    timer += Time.deltaTime;
                    if (timer > timeToGetPassenger)
                    {
                        if (humanSpawner.ActiveGameObjects.Count > 0)
                        {
                            bus.GetComponent<IBusPassenger>().GetPassenger(humanSpawner.ActiveGameObjects[0]);
                        }
                        timer = 0;
                    }
                }
                else
                {
                    bus.GetComponent<BusController>().CanMove = true;
                }
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bus"))
        {
            bus = collision.gameObject;
            sensor=collision.gameObject.GetComponentInChildren<ISensor>();
        }
    }




}
