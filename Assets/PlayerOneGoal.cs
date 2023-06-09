using UnityEngine;

public class PlayerOneGoal : MonoBehaviour
{
    public AudioSource audio;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayerTwoScored();
        audio.Play();
    }
}
