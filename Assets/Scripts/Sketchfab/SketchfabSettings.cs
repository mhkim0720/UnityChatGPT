﻿using UnityEngine;

[CreateAssetMenu(fileName = "SketchfabSettings", menuName = "ChatGPT/SketchfabSettings", order = 1)]
public class SketchfabSettings : ScriptableObject
{
    public string searchAPIUrl;
    public string downloadAPIUrl;
    public string apiToken;
    public string downloadModelsZipPath;
}