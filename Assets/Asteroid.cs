using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

    public AsteroidMovement typeOfAsteroid;
	void FixedUpdate()
    {
        typeOfAsteroid.move(transform);
    }
}
