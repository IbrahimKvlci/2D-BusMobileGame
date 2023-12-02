using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station :MonoBehaviour, IStation
{
    [SerializeField] float timeToGetPassenger;

    float timer=0;
    bool isBusInside=false;

    public void GetPassenger(GameObject passenger)
    {
        HumanPooling.Instance.GameObjectPool.Remove(passenger);
        HumanPooling.Instance.ActiveGameObjects.Remove(passenger);
        Destroy(passenger);
        Debug.Log("Got Passenger");
    }

    private void Update()
    {
        if (isBusInside)
        {
            if (HumanPooling.Instance.GameObjectPool.Count > 0)
            {
                timer += Time.deltaTime;
                if (timer > timeToGetPassenger)
                {
                    if (HumanPooling.Instance.ActiveGameObjects.Count > 0)
                    {
                        Debug.Log("Beginig");
                        GetPassenger(HumanPooling.Instance.ActiveGameObjects[0]);

                        Debug.Log("End of loop");
                    }
                    timer = 0;
                    print("Check!");
                }
                print(timer);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        print("Bus");
        if (collision.CompareTag("bus"))
        {
            isBusInside=true;
            
            
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isBusInside=false;
    }

}
