using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{

    public float lifeTime;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    void onTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
