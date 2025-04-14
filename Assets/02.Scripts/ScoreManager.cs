using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score_Text;
    public int score;
    
    public void Plus_Score(int score)
    {
        this.score += score;
        score_Text.text = "Score: " + this.score.ToString();
    } 
}
