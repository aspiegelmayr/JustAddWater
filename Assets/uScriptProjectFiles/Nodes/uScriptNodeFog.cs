// uScript Action Node
// (C) 2015 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Fog")]

[NodeCopyright("Copyright 2020 by Austin Yarger")]
[NodeToolTip("Adds two Vector3 variables together and returns the result.")]
[NodeAuthor("Austin Yarger", "umich.edu")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Fog", "Provides a Vector3 p of the way between two vectors.")]
public class uScriptNodeFog : uScriptLogic
{
    public bool Out { get { return true; } }

    public void In(
       [FriendlyName("fog_enabled", "Should fog be visible?"), AutoLinkType(typeof(bool))]
      bool fog_enabled,

       [FriendlyName("fog_density", "The density of the fog."), AutoLinkType(typeof(float))]
      float fog_density,

              [FriendlyName("fog_color", "The color of the fog"), AutoLinkType(typeof(Color))]
      Color fog_color
       )
    {
        RenderSettings.fog = fog_enabled;
        RenderSettings.fogDensity = fog_density;
        RenderSettings.fogColor = fog_color;
    }
}
