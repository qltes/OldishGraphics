using BepInEx;
using UnityEngine;

[BepInPlugin("com.qltesinc.OldishGraphics", "Texture Mod", "1.0.0")]
public class OldishGraphics : BaseUnityPlugin
{
    void Awake()
    {
        QualitySettings.masterTextureLimit = 1;
        UnityEngine.Debug.Log("Graphics Changed");
    }
}
