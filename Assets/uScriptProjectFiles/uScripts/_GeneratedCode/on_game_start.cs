//uScript Generated Code - Build 1.1.3133
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class on_game_start : uScriptLogic
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
   System.String[] local_2_System_StringArray = new System.String[] {"Hello!","World!"};
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_5 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_PrintList logic_uScriptAct_PrintList_uScriptAct_PrintList_0 = new uScriptAct_PrintList( );
   System.String[] logic_uScriptAct_PrintList_Strings_0 = new System.String[] {};
   bool logic_uScriptAct_PrintList_Out_0 = true;
   
   //event nodes
   UnityEngine.SceneManagement.Scene event_UnityEngine_GameObject_Scene_1 = default(UnityEngine.SceneManagement.Scene);
   UnityEngine.SceneManagement.LoadSceneMode event_UnityEngine_GameObject_LoadSceneMode_1 = UnityEngine.SceneManagement.LoadSceneMode.Single;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_1 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_3 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_4 = (float) 0.100000001;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_4 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_4 = (float) 0;
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_5 || false == m_RegisteredForEvents )
      {
         owner_Connection_5 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_1 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_1 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_1 )
         {
            {
               uScript_Level component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Level>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_1.AddComponent<uScript_Level>();
               }
               if ( null != component )
               {
                  component.LevelWasLoaded += Instance_LevelWasLoaded_1;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_3 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_3 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_3 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_3.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_3.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_3;
                  component.OnLateUpdate += Instance_OnLateUpdate_3;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_3;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_1 )
      {
         {
            uScript_Level component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Level>();
            if ( null != component )
            {
               component.LevelWasLoaded -= Instance_LevelWasLoaded_1;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_3 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_3.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_3;
               component.OnLateUpdate -= Instance_OnLateUpdate_3;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_3;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_PrintList_uScriptAct_PrintList_0.SetParent(g);
      owner_Connection_5 = parentGameObject;
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
   
   void Instance_LevelWasLoaded_1(object o, uScript_Level.LevelWasLoadedEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_Scene_1 = e.Scene;
      event_UnityEngine_GameObject_LoadSceneMode_1 = e.LoadSceneMode;
      //relay event to nodes
      Relay_LevelWasLoaded_1( );
   }
   
   void Instance_OnUpdate_3(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_3( );
   }
   
   void Instance_OnLateUpdate_3(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_3( );
   }
   
   void Instance_OnFixedUpdate_3(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_3( );
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d3f0e9e3-8eef-4a30-ad22-cd16e37defee", "Print_String_List", Relay_In_0)) return; 
         {
            {
               System.Array properties;
               int index = 0;
               properties = local_2_System_StringArray;
               if ( logic_uScriptAct_PrintList_Strings_0.Length != index + properties.Length)
               {
                  System.Array.Resize(ref logic_uScriptAct_PrintList_Strings_0, index + properties.Length);
               }
               System.Array.Copy(properties, 0, logic_uScriptAct_PrintList_Strings_0, index, properties.Length);
               index += properties.Length;
               
            }
         }
         logic_uScriptAct_PrintList_uScriptAct_PrintList_0.In(logic_uScriptAct_PrintList_Strings_0);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript on_game_start.uscript at Print String List.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_LevelWasLoaded_1()
   {
      if (true == CheckDebugBreak("f7f18738-66a9-4c5b-abbd-e3bf05f3d5e8", "Level_Load", Relay_LevelWasLoaded_1)) return; 
      Relay_In_0();
   }
   
   void Relay_OnUpdate_3()
   {
      if (true == CheckDebugBreak("b7e57d04-ebe4-4d36-a3ae-f16a6d6198ab", "Global_Update", Relay_OnUpdate_3)) return; 
      Relay_In_0();
      Relay_Translate_4();
   }
   
   void Relay_OnLateUpdate_3()
   {
      if (true == CheckDebugBreak("b7e57d04-ebe4-4d36-a3ae-f16a6d6198ab", "Global_Update", Relay_OnLateUpdate_3)) return; 
   }
   
   void Relay_OnFixedUpdate_3()
   {
      if (true == CheckDebugBreak("b7e57d04-ebe4-4d36-a3ae-f16a6d6198ab", "Global_Update", Relay_OnFixedUpdate_3)) return; 
   }
   
   void Relay_Translate_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f9da3ca0-b0d7-4b74-bfd0-d7a77564bd7e", "UnityEngine_Transform", Relay_Translate_4)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_5.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_4, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_4, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_4);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript on_game_start.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "on_game_start.uscript:2", local_2_System_StringArray);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a8ec9ee5-cf83-4e66-be97-9bfcd929a241", local_2_System_StringArray);
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
