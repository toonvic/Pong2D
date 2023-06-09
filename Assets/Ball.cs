using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed;
    public Vector3 StartPosition;

    public AudioSource audio;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.Play();
    }

    void Start()
    {
        StartPosition = transform.position;
        Launch();
    }

    public void Launch()
    {
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed * speedX, Speed * speedY);
    }

    public void Reset()
    {
        transform.position = StartPosition;
        Launch();
    }
}
