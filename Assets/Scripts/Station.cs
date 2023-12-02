using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station :MonoBehaviour, IStation
{
    [SerializeField] float timeToGetPassenger;

    float timer=0;

    public void GetPassenger(GameObject passenger)
    {
        HumanPooling.Instance.gameObjectPool.Remove(passenger);
        HumanPooling.Instance.activeGameObjects.Remove(passenger);
        Destroy(passenger);
        Debug.Log("Got Passenger");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Bus>()!=null && HumanPooling.Instance.gameObjectPool.Count>0)
        {
            timer += Time.deltaTime;
            if(timer > timeToGetPassenger)
            {
                if (HumanPooling.Instance.activeGameObjects.Count > 0)
                {
                    GetPassenger(HumanPooling.Instance.activeGameObjects[0]);
                    Debug.Log("End of loop");
                }
                timer= 0;
            }
            
        }
    }
}
