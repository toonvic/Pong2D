using UnityEngine;

public abstract class Player : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    public float Speed = 10f;

    public void MovePlatform(string axis) =>
        transform.Translate(0f, Input.GetAxis(axis) * Speed * Time.deltaTime, 0f);
}
