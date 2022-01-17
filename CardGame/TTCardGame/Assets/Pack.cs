using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Assets;
/// <summary>
/// A class to store the conents of the pack of cards
/// It will contain a List object with cards stored in it.
/// It will load the card descriptions to start with
/// </summary>
public class Pack : MonoBehaviour
{
    public Text messageText;
    TextReader tr;
    
    // Start is called before the first frame update
    void Start()
    {
        messageText.text = "Hello World";
        tr = new StreamReader("C:/Users/peter/source/repos/AnotherSimpleGame/CardGame/TTCardGame/Assets/GameDefinitions.txt");
        string s;
        Card nextCard;
        // = { "p1", "p2", "p3", "p4", "p5" };
        int[] dummyvalues;// = { 0, 1, 2, 3, 4 };
        s = tr.ReadLine();
        string parameterString = s.Substring(13);
        string[] dummynames = parameterString.Split('\t');
        while ((s= tr.ReadLine()) != null)
        {
            messageText.text += "\n" + s;
            string[] parts = s.Split('\t');
            //dummynames = parts;
            //foreach(string st in parts)
            //{
            //    messageText.text += "\n" + st;
            //}
            int cn = System.Int16.Parse(parts[0]);
            dummyvalues = new int[5];
            for(int i = 0; i < 5; i++)
            {
                dummyvalues[i] = System.Int16.Parse(parts[2 + i]);
            }
            nextCard = new Card(cn, parts[1], dummynames, dummyvalues);
            messageText.text += "\n" + nextCard.ImageNumber + " " + nextCard.CardName;
            messageText.text += " best property " + nextCard.BestParameterName()+ " has value "+ nextCard.BestScore();
        }
        tr.Close();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
