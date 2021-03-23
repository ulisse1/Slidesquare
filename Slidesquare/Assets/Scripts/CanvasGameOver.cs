using UnityEngine;
using UnityEngine.UI;
public class CanvasEndGame : MonoBehaviour
{
    public Text displayEndText;
    public void displayGameOver()
    {
        displayEndText.gameObject.SetActive(false);
    }
}
