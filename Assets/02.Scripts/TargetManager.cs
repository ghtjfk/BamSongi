using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TargetManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.CompareTag("target_10"))
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Plus_Score(10);
            Debug.Log("10Á¡ È¹µæ!");
        }

        if (this.gameObject.CompareTag("target_20"))
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Plus_Score(20);
            Debug.Log("20Á¡ È¹µæ!");
        }

        if (this.gameObject.CompareTag("target_50"))
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Plus_Score(50);
            Debug.Log("50Á¡ È¹µæ!");
        }
    }
}
