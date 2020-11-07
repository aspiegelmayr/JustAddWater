// uScript Action Node
// (C) 2015 Detox Studios LLC

using UnityEngine;
using System.Collections;
using Yarn.Unity;

[NodePath("Actions/Dialogue")]

[NodeCopyright("Copyright 2020 by Austin Yarger")]
[NodeToolTip("Launch dialogue at a particular Yarn node if we aren't already running dialogue.")]
[NodeAuthor("Austin Yarger", "umich.edu")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Start Dialogue", "Launch dialogue at a particular Yarn node if we aren't already running dialogue.")]
public class uScriptNodeStartDialogue : uScriptLogic
{
    public bool Out { get { return true; } }

    public void In(
       [FriendlyName("yarn_node_name", "The name of the node we wish to start dialogue with."), AutoLinkType(typeof(string))]
      string yarn_node_name

       )
    {
        DialogueRunner.StartDialogue(yarn_node_name);
    }
}
