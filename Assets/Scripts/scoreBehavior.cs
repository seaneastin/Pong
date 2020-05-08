using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * this class stores the scorees for the game and updates the text on screen with the score
 */
public class scoreBehavior : MonoBehaviour
{
    public int leftscore = 0;
    public int rightscore = 0;
    [SerializeField]
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = leftscore + " : " + rightscore;
    }
}
