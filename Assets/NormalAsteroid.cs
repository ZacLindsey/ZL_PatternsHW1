using UnityEngine;
using System.Collections;

[System.Serializable]
public class NormalAsteroid : AsteroidMovement {
    public override void move(Transform t)
    {
        Vector3 amount;
        if (flip)
            amount = -1.0f * t.forward * 0.04f;
        else
            amount = t.forward * 0.04f;
        t.position += amount;
    }
}
