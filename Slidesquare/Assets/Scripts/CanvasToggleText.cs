using UnityEngine;
using UnityEngine.UI;
public class CanvasToggleText : MonoBehaviour
{
    public void ToggleEndGameText()
    {
        foreach (var x in GetComponentsInChildren<Text>())
        {
            x.gameObject.SetActive(true);
        }
    }
  
}
