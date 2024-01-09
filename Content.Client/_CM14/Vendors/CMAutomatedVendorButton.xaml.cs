﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CM14.Vendors;

[GenerateTypedNameReferences]
public sealed partial class CMAutomatedVendorButton : Button
{
    public event Action? OnDrawModeChanged;

    public CMAutomatedVendorButton()
    {
        RobustXamlLoader.Load(this);
    }

    protected override void DrawModeChanged()
    {
        OnDrawModeChanged?.Invoke();
    }
}
