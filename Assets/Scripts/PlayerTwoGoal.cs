using UnityEngine;

public class PlayerTwoGoal : MonoBehaviour
{
    public AudioSource audio;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayerOneScored();
        audio.Play();
    }
}
