using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CheckVariant : MonoBehaviour
{
    public ShaderVariantCollection variants;
    // Start is called before the first frame update
    void Start()
    {
        string [] keywords = new string [] {
            "DIRECTIONAL",
            "LIGHTPROBE_SH",
            "_ALPHAPREMULTIPLY_ON"
        };
        ShaderVariantCollection.ShaderVariant variant =
            new ShaderVariantCollection.ShaderVariant(
                Shader.Find("Standard"),
                PassType.ForwardBase,
                keywords);
        bool match = variants.Contains(variant);
        Debug.LogFormat(
            "Shader {0} pass {1} keywords {2} found {3}",
            variant.shader.name,
            variant.passType,
            string.Join(" ", variant.keywords),
            match);
    }
}
