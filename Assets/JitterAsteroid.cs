using UnityEngine;
using System.Collections;

[System.Serializable]
public class JitterAsteroid : AsteroidMovement {
    public override void move(Transform t)
    {
        Vector3 amount;
        if (flip)
            amount = -1.0f*t.forward * 0.04f;
        else
            amount = t.forward * 0.04f;
        t.position += amount;
        Vector3 random = t.rotation.eulerAngles;
        random.x = UnityEngine.Random.Range(-0.03f, 0.03f);
        random.y = UnityEngine.Random.Range(-0.03f, 0.03f);
        random.z = UnityEngine.Random.Range(-0.03f, 0.03f);
        t.rotation = Quaternion.Euler(random);
    }
}
