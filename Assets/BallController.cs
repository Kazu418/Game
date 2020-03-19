using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private int Score;
    private string StringScore;
    private GameObject score;
    private int GameStart = 0;
    // Use this for initialization
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "GameOver";
        }
        StringScore = (Score).ToString();
        this.score.GetComponent<Text>().text = StringScore;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "LeftFripper" || collision.gameObject.name == "RightFripper")
        {
            GameStart = 1;
        }
        if (GameStart == 1)
        {
            if (collision.gameObject.name == "LargeCloud prefab")
            {
                Score += 20;

            }
            if (collision.gameObject.name == "SmallCloud prefab" || collision.gameObject.name == "SmallCloud prefab 1")
            {
                Score += 10;
                if (collision.gameObject.name == "LargeStar prefab" || collision.gameObject.name == "LargeStar prefab 1")
                {
                    Score += 30;
                }
                if (collision.gameObject.name == "small ster prefab" || collision.gameObject.name == "small ster prefab 1")
                {
                    Score += 100;
                }
            }

        }

    }
}
