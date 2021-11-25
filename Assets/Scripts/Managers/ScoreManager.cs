using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance = null;
    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreManager>();
            }
            return _instance;
        }
    }

    public int score;

    private Text text;

    private void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
    }

    private void Update ()
    {
        text.text = "Score: " + score;
    }
}
