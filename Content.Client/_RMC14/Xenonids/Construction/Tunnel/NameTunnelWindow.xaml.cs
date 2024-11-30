using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Client._RMC14.Xenonids.Construction.Tunnel;
[GenerateTypedNameReferences]
public sealed partial class NameTunnelWindow : DefaultWindow
{
    public NameTunnelWindow()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);

        Title = Loc.GetString("xeno-ui-name-tunnel-title");
        SubmitButton.Text = Loc.GetString("xeno-ui-name-tunnel-submit-text");
    }
}