using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Basket : MonoBehaviour
{

    public Text scoreGT;
    private int score = 0;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

        if (score < 0)
        {
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
            score = 0;
            scoreGT.text = score.ToString();
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            score = int.Parse(scoreGT.text);
            score += 100;
        }
        if (collidedWith.tag == "Special")
        {
            Destroy(collidedWith);
            score = int.Parse(scoreGT.text);
            score -= 200;

        }
        scoreGT.text = score.ToString();
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
    }

}
