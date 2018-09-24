using UnityEngine;
using UnityEngine.UI;

public class TrackScore : MonoBehaviour {

    private Text scoreText;
    private int previousScore;

    private void Start()
    {
        scoreText = gameObject.GetComponent<Text>();
        previousScore = GameState.score;
        scoreText.text = previousScore.ToString();
    }
    // Update is called once per frame
    void Update () {
		if(GameState.score != previousScore)
        {
            scoreText.text = GameState.score.ToString();
        }
	}
}
