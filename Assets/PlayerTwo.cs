using UnityEngine;

public class PlayerTwo : Player
{
    public Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }

    void Update() =>
        MovePlatform("Vertical");

    public void Reset() =>
        transform.position = StartPosition;
}
