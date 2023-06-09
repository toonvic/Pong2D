using UnityEngine;

public class PlayerOne : Player
{
    public Vector3 StartPosition;

    void Start() =>
        StartPosition = transform.position;

    void Update() =>
        MovePlatform("Vertical2");

    public void Reset() =>
        transform.position = StartPosition;
}
