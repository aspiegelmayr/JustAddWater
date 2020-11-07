// uScript Action Node
// (C) 2015 Detox Studios LLC

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[NodePath("Actions/Scene")]
[NodeCopyright("Copyright 2020 by Austin Yarger")]
[NodeToolTip("Get the name of the current scene.")]
[NodeAuthor("Austin Yarger", "umich.edu")]
[NodeHelp("http://docs.uscript.net/#3-Working_With_uScript/3.4-Nodes.htm")]

[FriendlyName("Get Current Scene Name", "Get the name of the current scene.")]
public class uScriptNodeGetCurrentSceneName : uScriptLogic
{
    public bool Out { get { return true; } }

    public void In(
       [FriendlyName("Result", "The current scene name.")]
      out string Result
       )
    {
        Result = SceneManager.GetActiveScene().name;
    }
}
