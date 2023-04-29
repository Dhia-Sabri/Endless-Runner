using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float currenttime;    

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime * 10;
        scoreText.text = currenttime.ToString("0");
    }
}