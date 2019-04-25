using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class RenderExperiment : MonoBehaviour
{
    public Material EffectMaterial;                             // material used to render the screen with

    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        if (EffectMaterial != null)
            Graphics.Blit(src, dst, EffectMaterial);                // (source, destination, material)
    }
}