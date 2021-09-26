using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    public int RedScore;
    public int BlueScore;
    public Text RedText;
    public Text BlueText;


    // Start is called before the first frame update
    void Start()
    {
        RedScore = 0;
        BlueScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RedText.text = RedScore.ToString();
        BlueText.text = BlueScore.ToString();
    }
}
