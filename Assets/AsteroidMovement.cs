using UnityEngine;
using System.Collections;

[System.Serializable]
public abstract class AsteroidMovement {
    public bool flip;
    public abstract void move(Transform t);
}
