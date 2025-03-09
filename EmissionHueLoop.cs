using UnityEngine;

public class EmissionHueLoop : MonoBehaviour
{
    public Material targetMaterial; // Assign any material here
    public float hueSpeed = 1.0f;   // Speed of hue change

    private float hue = 0;

    void Update()
    {
        if (targetMaterial == null)
        {
            Debug.LogWarning("Target material is not assigned!");
            return;
        }

        // Increment hue over time
        hue += hueSpeed * Time.deltaTime;
        hue = Mathf.Repeat(hue, 1f); // Keep hue between 0 and 1

        // Convert hue to RGB (Saturation and Value remain 1 for full color)
        Color color = Color.HSVToRGB(hue, 1, 1);

        // Apply the color to the material's Emission property
        targetMaterial.SetColor("_EmissionColor", color);

        // Ensure emission is enabled in the material
        targetMaterial.EnableKeyword("_EMISSION");
    }
}
