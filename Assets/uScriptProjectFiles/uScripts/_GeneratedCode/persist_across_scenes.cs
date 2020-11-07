//uScript Generated Code - Build 1.1.3133
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class persist_across_scenes : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   UnityEngine.GameObject owner_Connection_3 = null;
   
   //logic nodes
   
   //event nodes
   
   //property nodes
   
   //method nodes
   UnityEngine.Object method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_target_0 = default(UnityEngine.Object);
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
      }
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
         if ( null != owner_Connection_3 )
         {
            {
               uScript_Update component = owner_Connection_3.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_3.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_2;
                  component.OnLateUpdate += Instance_OnLateUpdate_2;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_2;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_3 )
         {
            {
               uScript_Update component = owner_Connection_3.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_3.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_2;
                  component.OnLateUpdate += Instance_OnLateUpdate_2;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_2;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_3 )
      {
         {
            uScript_Update component = owner_Connection_3.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_2;
               component.OnLateUpdate -= Instance_OnLateUpdate_2;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_2;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      owner_Connection_1 = parentGameObject;
      owner_Connection_3 = parentGameObject;
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_2(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_2( );
   }
   
   void Instance_OnLateUpdate_2(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_2( );
   }
   
   void Instance_OnFixedUpdate_2(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_2( );
   }
   
   void Relay_DontDestroyOnLoad_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("31955767-09b6-4567-a454-faadea20834a", "UnityEngine_Object", Relay_DontDestroyOnLoad_0)) return; 
         {
            {
            }
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_target_0 = owner_Connection_1;
               
            }
         }
         UnityEngine.Object.DontDestroyOnLoad(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_target_0);
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript persist_across_scenes.uscript at UnityEngine.Object.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_2()
   {
      if (true == CheckDebugBreak("c7b4b718-afb7-458b-a5e6-3b3534bfe6ba", "Global_Update", Relay_OnUpdate_2)) return; 
      Relay_DontDestroyOnLoad_0();
   }
   
   void Relay_OnLateUpdate_2()
   {
      if (true == CheckDebugBreak("c7b4b718-afb7-458b-a5e6-3b3534bfe6ba", "Global_Update", Relay_OnLateUpdate_2)) return; 
   }
   
   void Relay_OnFixedUpdate_2()
   {
      if (true == CheckDebugBreak("c7b4b718-afb7-458b-a5e6-3b3534bfe6ba", "Global_Update", Relay_OnFixedUpdate_2)) return; 
   }
   
   private void UpdateEditorValues( )
   {
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
