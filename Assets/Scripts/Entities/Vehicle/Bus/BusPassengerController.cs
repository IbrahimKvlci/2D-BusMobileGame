using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusPassengerController : MonoBehaviour,IBusPassenger
{
    [SerializeField] GameObject busStation;

    public void GetPassenger(GameObject passenger)
    {
        busStation.GetComponent<IStation>().CountOfPassenger--;
        print(passenger.name);
        busStation.GetComponent<IStation>().HumanSpawner.ActiveGameObjects.Remove(passenger);
        passenger.SetActive(false);
    }
}
