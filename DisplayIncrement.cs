using UnityEngine;
using UnityEngine.UI;
using TMPro; // Don't forget this line
public class DisplayIncrement : MonoBehaviour
{
    public TMP_Text counterText;

    public void Start()
    {
        counterText.text = "Attempts: " + CreditsController.count.ToString();
    }
}