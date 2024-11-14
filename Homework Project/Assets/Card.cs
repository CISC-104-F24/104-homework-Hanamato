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
    public string cardName; 
    public string currentText;
    


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

    /*public void ChangeText(string newText)
    {
        currentText = newText;
        bottomRank.text = newText;
        topRank.text = newText;
    }*/
    public void newText()
    {
        cardName = "Don't have one.";
    }    
    }
