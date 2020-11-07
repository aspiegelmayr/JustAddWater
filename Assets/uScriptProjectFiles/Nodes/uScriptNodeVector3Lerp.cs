// uScript Action Node
// (C) 2015 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2020 by Austin Yarger")]
[NodeToolTip("Adds two Vector3 variables together and returns the result.")]
[NodeAuthor("Austin Yarger", "umich.edu")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Lerp Vector3", "Provides a Vector3 p of the way between two vectors.")]
public class uScriptNodeVector3Lerp : uScriptLogic
{
    public bool Out { get { return true; } }

    public void In(
       [FriendlyName("A", "The first variable or variable list."), AutoLinkType(typeof(Vector3))]
      Vector3 A,

       [FriendlyName("B", "The second variable or variable list."), AutoLinkType(typeof(Vector3))]
      Vector3 B,

              [FriendlyName("progress", "A number from 0 to 1.0"), AutoLinkType(typeof(float))]
      float p,

       [FriendlyName("Result", "The Vector3 result of the operation.")]
      out Vector3 Result
       )
    {
        Result = Vector3.Lerp(A, B, p);
    }
}
