using UnityEngine;
using UnityEngine.UI;

public class AlphaModifier : MonoBehaviour
{
    public Image imageToModify;
    public float newAlpha = 0.5f; // Set your desired alpha value here

    // This function will be called when the button is clicked
    public void ModifyAlpha()
    {
        if (imageToModify != null)
        {
            Color newColor = imageToModify.color;
            newColor.a = newAlpha; // Set the alpha channel to the new value
            imageToModify.color = newColor;
        }
    }
}
