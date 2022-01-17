using System.Collections;
using UnityEngine;

namespace Assets
{
    public class Card
    {
        //Fields
        int imageNumber;
        string cardName;
        string[] parameterNames;
        int[] parameterValues;
        int bestScoreParameter;
        //Properties
        /// <summary>
        /// The Card Constructor will be sent the card attributes
        /// </summary>
        /// <param name="imageN">The image Number</param>
        /// <param name="cardN">The card Name </param>
        /// <param name="propertyNs">The list of property Names</param>
        /// <param name="propertyV">the list of property values</param>
        public Card(int imageN,string cardN, string[] propertyNs, int[] propertyV)
        {
            imageNumber = imageN;
            cardName = cardN;
            parameterNames = propertyNs;
            parameterValues = propertyV;
        }
        public string CardName
        {
            get { return cardName; }
        }
        public int ImageNumber
        {
            get { return imageNumber; }
        }
        public int PropertyValue(int i)
        {
            return parameterValues[i];
        }
        public string PropertyName(int i)
        {
            return parameterNames[i];
        }
        public int BestScore()
        {
            int v = -1;
            bestScoreParameter = -1;
            for(int i = 0; i < parameterValues.Length; i++)
            {
                if(parameterValues[i] > v)
                {
                    v = i;
                    bestScoreParameter = i;
                }

            }
            return v;
        }
        public string BestParameterName()
        {
            int i = BestScore();
            return parameterNames[bestScoreParameter];
        }
    }
}