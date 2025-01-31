﻿using System;
using StardewModdingAPI;

public interface GenericModConfigMenuAPI
{
    void RegisterModConfig(IManifest mod, Action revertToDefault, Action saveToFile);

    void SetDefaultIngameOptinValue(IManifest mod, bool optedIn);

    void RegisterSimpleOption(IManifest mod, string optionName, string optionDesc, Func<bool> optionGet,
        Action<bool> optionSet);

    void RegisterSimpleOption(IManifest mod, string optionName, string optionDesc, Func<int> optionGet,
        Action<int> optionSet);

    void RegisterSimpleOption(IManifest mod, string optionName, string optionDesc, Func<float> optionGet,
        Action<float> optionSet);

    void RegisterClampedOption(IManifest mod, string optionName, string optionDesc, Func<float> optionGet,
        Action<float> optionSet, float min, float max, float interval);
}