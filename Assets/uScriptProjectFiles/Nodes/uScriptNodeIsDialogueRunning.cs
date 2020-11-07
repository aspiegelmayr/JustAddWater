// uScript Condition Node
// (C) 2010 Detox Studios LLC

using UnityEngine;
using System.Collections;
using Yarn.Unity;

[NodePath("Conditions/Dialogue")]

[NodeCopyright("Copyright 2020 by Austin Yarger")]
[NodeToolTip("Checks if dialogue is currently running.")]
[NodeAuthor("Austin Yarger", "umich.edu")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Is Dialogue Running", "Checks if dialogue is currently running.")]
public class uScriptNodeIsDialogueRunning : uScriptLogic
{
    private bool m_CompareValue = false;

    bool dialogue_running;

    public bool True { get { return dialogue_running; } }
    public bool False { get { return !dialogue_running; } }

    public void In(
       )
    {
        dialogue_running = DialogueRunner.GetIsDialogueRunning();
    }
}
