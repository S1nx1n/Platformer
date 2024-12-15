using UnityEngine;
using UnityEngine.UI; 

public class PlayerCoinCollector : MonoBehaviour
{
    public int totalCoins = 0;
    public Text coinText; 

    
    public void AddCoins(int amount)
    {
        totalCoins += amount; 
        UpdateCoinText(); 
    }

    
    void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + totalCoins.ToString(); 
        }
    }
}