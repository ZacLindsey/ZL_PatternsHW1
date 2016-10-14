using UnityEngine;
using System.Collections;

//Zac Lindsey
//10/13/2016
//CSC323 - Dr. Mood

public class Factory : MonoBehaviour {

    public bool flipped;
    public GameObject tomake;
	// Use this for initialization
	void Start () {
        InvokeRepeating("makeAsteroids", 0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void makeAsteroids () {
        Vector3 randomPosition = new Vector3();
        randomPosition.x = UnityEngine.Random.Range(-3.0f, 3.0f);
        randomPosition.y = UnityEngine.Random.Range(-3.0f, 3.0f);
        if (!flipped)
            randomPosition.z = -3.0f;
        else
            randomPosition.z = 3.0f;
        GameObject asteroidObject = Instantiate(tomake, randomPosition, Quaternion.identity) as GameObject;
        Asteroid asteroidBehavior = asteroidObject.GetComponent<Asteroid>();

        
        int randomChoiceOfType = UnityEngine.Random.Range(0, 3);
        Debug.Log(randomChoiceOfType);
        switch (randomChoiceOfType)
        {
            case 0:
                asteroidBehavior.typeOfAsteroid = new NormalAsteroid();
                break;
            case 1:
                asteroidBehavior.typeOfAsteroid = new JitterAsteroid();
                break;
            case 2:
                asteroidBehavior.typeOfAsteroid = new AngleAsteroid();
                break;
            default:
                asteroidBehavior.typeOfAsteroid = new NormalAsteroid();
                break;
        }
        if (flipped)
        {
            asteroidBehavior.typeOfAsteroid.flip = true;
        }

    }
}
