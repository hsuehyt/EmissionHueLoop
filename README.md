# EmissionHueLoop 🎨🌈  

A **Unity C# script** that dynamically changes the emission color of a material over time, cycling through the full color spectrum using HSV color space. This creates a smooth, animated glowing effect perfect for sci-fi elements, neon lights, or ambient effects in Unity.

## 🌟 Features
- 🎨 **Real-time Emission Color Animation**  
- 🔄 **Hue Looping with Custom Speed**  
- 🛠️ **Works on Any Material with Emission Enabled**  
- 🚀 **Lightweight & Easy to Use**  

## 📌 Installation
1. **Clone this repository**:
   ```sh
   git clone https://github.com/hsuehyt/EmissionHueLoop.git
   ```
2. **Open the project** in Unity, or copy `EmissionHueLoop.cs` into your own Unity project.

## 🛠️ Usage
1. **Attach the Script** to any GameObject.
2. **Assign the Material** you want to animate in the **Inspector** under `Target Material`.
3. **Enable Emission** on the material in Unity's **Shader Settings**.
4. Adjust **Hue Speed** to control how fast the colors change.

## 📜 Code Example
```csharp
using UnityEngine;

public class EmissionHueLoop : MonoBehaviour
{
    public Material targetMaterial; // Assign material here
    public float hueSpeed = 1.0f;   // Speed of hue change

    private float hue = 0;

    void Update()
    {
        if (targetMaterial == null) return;

        hue = Mathf.Repeat(hue + hueSpeed * Time.deltaTime, 1f);
        Color color = Color.HSVToRGB(hue, 1, 1);

        targetMaterial.SetColor("_EmissionColor", color);
        targetMaterial.EnableKeyword("_EMISSION");
    }
}
```
## 🔥 Use Cases  
- Sci-fi glowing materials ✨  
- Dynamic neon signs 🚥  
- Magic and spell effects 🔮  
- Cyberpunk-style environments 🌆  

## 🤝 Contributions  
Contributions are welcome! Feel free to **fork**, **create issues**, and submit **pull requests**.

## 📜 License  
This project is licensed under the **MIT License** – feel free to use and modify it as needed.