// uScript Action Node
// (C) 2015 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2020 by Austin Yarger")]
[NodeToolTip("Gets magnitude of a vector3.")]
[NodeAuthor("Austin Yarger", "umich.edu")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Vector3 Magnitude", "Gets magnitude of a vector3.")]
public class uScriptNodeVector3Magnitude : uScriptLogic
{
    public bool Out { get { return true; } }

    public void In(
       [FriendlyName("input", "The first variable or variable list."), AutoLinkType(typeof(Vector3))]
      Vector3 input,

       [FriendlyName("Result", "The float result of the operation.")]
      out float Result
       )
    {
        Result = input.magnitude;
    }
}
