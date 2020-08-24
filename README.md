# MissingShaderVariant
An example project showing a bug in `ShaderVariantCollection`

To reproduce:

1. Open and run the project in the editor.
2. Output is "Shader ... found False"
3. Check the `ShaderVariantCollection` contains the shader.
4. Delete the variant.
5. Re-add the variant.
6. Run the project.
7. Output is "Shader ... found True"
8. Close Unity
9. Re-open the project and run in the editor.
10. Output is "Shader ... found False"

