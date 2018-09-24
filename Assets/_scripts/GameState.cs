using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gamestate defines the state of the game at a current moment.
 * 
 * Fields:
 *      _bulletColor: The currently selected color from the user
 */
public class GameState : MonoBehaviour {

    private static GameState gamestate;
    private List<Color> _colors;
    private Color _bulletColor;
    private int _score = 0;
    private int _numTargets = 0;

    public static GameState instance
    {
        get
        {
            if (!gamestate)
            {
                gamestate = FindObjectOfType(typeof(GameState)) as GameState;
                if (!gamestate)
                {
                    Debug.LogError("There needs to be one active GameState script on a component in your scene.");
                }
                else
                {   
                    gamestate.Init();
                }
            }
            return gamestate;
        }
    }

    private void Init()
    {
        // These are the colours that the entire game reads from
        _colors = new List<Color>();
        _colors.Add(new Color(1, 0, 0, 1));             //Red
        _colors.Add(new Color(0, 0, 1, 1));             //Blue
        _colors.Add(new Color(0, 1, 0, 1));             //Green
        _colors.Add(new Color(1, 0.92f, 0.016f, 1));    //Yellow
        _colors.Add(new Color(1, 0, 1, 1));             //Purple
        _bulletColor = _colors[0];
    }

    public static Color bulletColor
    {
        get
        {
            return instance._bulletColor;
        }
        set
        {
            instance._bulletColor = value;
        }
    }

    public static List<Color> colors
    {
        get
        {
            return instance._colors;
        }
    }

    public static int score
    {
        get
        {
            return instance._score;
        }
        set
        {
            instance._score = value;
        }
    }

    public static int numTargets
    {
        get
        {
            return instance._numTargets;
        }
        set
        {
            instance._numTargets = value;
        }
    }
}
