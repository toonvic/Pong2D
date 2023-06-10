using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("PlayerOne")]
    public GameObject PlayerOnePaddle;
    public GameObject PlayerOneGoal;

    [Header("PlayerTwo")]
    public GameObject PlayerTwoPaddle;
    public GameObject PlayerTwoGoal;

    [Header("ScoreUI")]
    public GameObject PlayerOneScoreText;
    public GameObject PlayerTwoScoreText;

    [Header("PauseMenu")]
    public GameObject PauseMenu;

    private int PlayerOneScore;
    private int PlayerTwoScore;

    public void PlayerOneScored()
    {
        PlayerOneScore++;
        PlayerOneScoreText.GetComponent<TextMeshProUGUI>().text = PlayerOneScore.ToString();
        ResetPosition();
    }

    public void PlayerTwoScored()
    {
        PlayerTwoScore++;
        PlayerTwoScoreText.GetComponent<TextMeshProUGUI>().text = PlayerTwoScore.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        Ball.GetComponent<Ball>().Reset();
        PlayerOnePaddle.GetComponent<PlayerOne>().Reset();
        PlayerTwoPaddle.GetComponent<PlayerTwo>().Reset();
    }
}
