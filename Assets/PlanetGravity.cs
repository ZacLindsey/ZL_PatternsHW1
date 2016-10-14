using UnityEngine;
using System.Collections;

public class PlanetGravity : MonoBehaviour {

    public ArrayList observors = new ArrayList();

    void FixedUpdate()
    {
        foreach(Object o in observors)
        {
            if (o)
            {
                //Cast into a GameObject
                GameObject ob = (GameObject)o;

                //Modify the GameObject's position (gravity)
                Vector3 diff = ob.transform.position - transform.position;
                diff.Normalize();
                ob.transform.position -= diff * .02f;
            }
        }
    }

    //This represents the planet collider, which causes asteroids to disappear
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
