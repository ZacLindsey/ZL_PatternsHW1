using UnityEngine;
using System.Collections;

public class AddObservors : MonoBehaviour {

    public PlanetGravity planetSubject;

    //Upon entering the gravitational field, the asteroid subscribes to the planet subject
	void OnTriggerEnter(Collider other)
    {
        planetSubject.observors.Add(other.gameObject);
        Debug.Log("ADDED");
    }
    
    //Upon exiting, the asteroid unsubscribes
    void OnTriggerExit(Collider other)
    {
        planetSubject.observors.Remove(other.gameObject);
    }
}
