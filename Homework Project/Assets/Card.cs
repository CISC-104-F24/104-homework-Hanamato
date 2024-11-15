using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour

{
    public Color startingcolor;
    public Color nextColor = new Color (0.6357f, 0.34f,0.7f);
    public bool colorChanged = false;
    public Button button;
    public GameObject card; 
    public TextMeshProUGUI topRank; 
    public TextMeshProUGUI bottomRank;
    public TextMeshProUGUI cardName; 
    public string currentText;
    public float rank = 1f; 
    public Image square; 
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        Debug.Log("Boom new color!");
        startingcolor = nextColor;
        if (!colorChanged)
        {
            colorChanged = true;
            GetComponent<MeshRenderer>().material.color = nextColor;
        }
        else if (colorChanged)
        {
            colorChanged = false;
            GetComponent<MeshRenderer>().material.color = startingcolor;
        }
    }

    public void ChangeText(string newText)
    {
        
        currentText = newText;
        //bottomRank.text = newText;
        //topRank.text = ;
        cardName.text = ("I'm Batman");
        Debug.Log("changed");
    }
    public void AddRank(string newText)
    {
        rank += 1;
        topRank.text = "Rank: " + rank;
        bottomRank.text = "Rank: " + rank;
        Debug.Log("Higher Rank");
        
    }
    public void SubtractRank(string newText)
    {
        rank -= 1;
        bottomRank.text = "Rank: " + rank;
        topRank.text = "Rank " + rank;
        Debug.Log("Lower Rank");
    }

    /*public void RandomizeColor()
    {
        float randomRed = Random.Range(0.0f,1.0f);
        float randomBlue = Random.Range(0.0f,1.0f);

        Color randomColor = new Color(randomRed, randomBlue);
        GetComponent<MeshRenderer>().material.color = randomColor;
    }*/

    }
