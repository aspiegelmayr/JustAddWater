// uScript Action Node
// (C) 2015 Detox Studios LLC

using UnityEngine;
using System.Collections;

[NodePath("Actions/Math/Vectors")]

[NodeCopyright("Copyright 2020 by Austin Yarger")]
[NodeToolTip("Adds two Vector3 variables together and returns the result.")]
[NodeAuthor("Austin Yarger", "umich.edu")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Look In Direction", "Provides a Vector3 p of the way between two vectors.")]
public class uScriptNodeLookInDirection : uScriptLogic
{
    public bool Out { get { return true; } }

    public void In(
      [FriendlyName("target", "The gameobject that will be pointing in a direction."), AutoLinkType(typeof(GameObject))]
      GameObject target,

      [FriendlyName("direction", "The direction to be pointed in."), AutoLinkType(typeof(Vector3))]
      Vector3 direction,

      [FriendlyName("ease_factor", "A number between 0.1 to 1.0 that controls how fast the gameobject will turn."), AutoLinkType(typeof(float))]
      float ease_factor
       )
    {
        Quaternion desired_rot = Quaternion.LookRotation(direction, Vector3.up);
        target.transform.rotation = Quaternion.Slerp(target.transform.rotation, desired_rot, ease_factor);
    }
}
