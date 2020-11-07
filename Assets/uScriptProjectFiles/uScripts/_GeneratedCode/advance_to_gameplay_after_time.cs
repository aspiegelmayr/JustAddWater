//uScript Generated Code - Build 1.1.3133
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class advance_to_gameplay_after_time : uScriptLogic
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
   System.String local_7_System_String = "gameplay";
   System.Int32 local_timer_System_Int32 = (int) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_3 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_3 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_3;
   bool logic_uScriptAct_SetInt_Out_3 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_5 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_5 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_5 = (int) 300;
   bool logic_uScriptCon_CompareInt_GreaterThan_5 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_5 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_5 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_5 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_5 = true;
   bool logic_uScriptCon_CompareInt_LessThan_5 = true;
   //pointer to script instanced logic node
   uScriptAct_LoadLevel logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_6 = new uScriptAct_LoadLevel( );
   System.String logic_uScriptAct_LoadLevel_name_6 = "";
   System.Boolean logic_uScriptAct_LoadLevel_destroyOtherObjects_6 = (bool) true;
   System.Boolean logic_uScriptAct_LoadLevel_blockUntilLoaded_6 = (bool) true;
   bool logic_uScriptAct_LoadLevel_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_8 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_B_8 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_8;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_8;
   bool logic_uScriptAct_AddInt_v2_Out_8 = true;
   
   //event nodes
   UnityEngine.SceneManagement.Scene event_UnityEngine_GameObject_Scene_0 = default(UnityEngine.SceneManagement.Scene);
   UnityEngine.SceneManagement.LoadSceneMode event_UnityEngine_GameObject_LoadSceneMode_0 = UnityEngine.SceneManagement.LoadSceneMode.Single;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_4 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Level component = owner_Connection_1.GetComponent<uScript_Level>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Level>();
               }
               if ( null != component )
               {
                  component.LevelWasLoaded += Instance_LevelWasLoaded_0;
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
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Level component = owner_Connection_1.GetComponent<uScript_Level>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Level>();
               }
               if ( null != component )
               {
                  component.LevelWasLoaded += Instance_LevelWasLoaded_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_4 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_4 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_4 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_4.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_4;
                  component.OnLateUpdate += Instance_OnLateUpdate_4;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_4;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_1 )
      {
         {
            uScript_Level component = owner_Connection_1.GetComponent<uScript_Level>();
            if ( null != component )
            {
               component.LevelWasLoaded -= Instance_LevelWasLoaded_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_4 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_4;
               component.OnLateUpdate -= Instance_OnLateUpdate_4;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_4;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetInt_uScriptAct_SetInt_3.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_5.SetParent(g);
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_6.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8.SetParent(g);
      owner_Connection_1 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_6.Loaded += uScriptAct_LoadLevel_Loaded_6;
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
      
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_6.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_6.Loaded -= uScriptAct_LoadLevel_Loaded_6;
   }
   
   void Instance_LevelWasLoaded_0(object o, uScript_Level.LevelWasLoadedEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_Scene_0 = e.Scene;
      event_UnityEngine_GameObject_LoadSceneMode_0 = e.LoadSceneMode;
      //relay event to nodes
      Relay_LevelWasLoaded_0( );
   }
   
   void Instance_OnUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_4( );
   }
   
   void Instance_OnLateUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_4( );
   }
   
   void Instance_OnFixedUpdate_4(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_4( );
   }
   
   void uScriptAct_LoadLevel_Loaded_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Loaded_6( );
   }
   
   void Relay_LevelWasLoaded_0()
   {
      if (true == CheckDebugBreak("a241fc93-d030-4383-83a0-8d9cc4aa6098", "Level_Load", Relay_LevelWasLoaded_0)) return; 
      Relay_In_3();
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("32d00bbb-e389-4426-accd-60a8c86e5b9e", "Set_Int", Relay_In_3)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_3.In(logic_uScriptAct_SetInt_Value_3, out logic_uScriptAct_SetInt_Target_3);
         local_timer_System_Int32 = logic_uScriptAct_SetInt_Target_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript advance_to_gameplay_after_time.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_4()
   {
      if (true == CheckDebugBreak("2c846a44-99fb-4bb0-85c3-a5eccbba3407", "Global_Update", Relay_OnUpdate_4)) return; 
      Relay_In_8();
   }
   
   void Relay_OnLateUpdate_4()
   {
      if (true == CheckDebugBreak("2c846a44-99fb-4bb0-85c3-a5eccbba3407", "Global_Update", Relay_OnLateUpdate_4)) return; 
   }
   
   void Relay_OnFixedUpdate_4()
   {
      if (true == CheckDebugBreak("2c846a44-99fb-4bb0-85c3-a5eccbba3407", "Global_Update", Relay_OnFixedUpdate_4)) return; 
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b9d28a2f-28a0-4698-ae2b-050f8aef0ca6", "Compare_Int", Relay_In_5)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_5 = local_timer_System_Int32;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_5.In(logic_uScriptCon_CompareInt_A_5, logic_uScriptCon_CompareInt_B_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_5.EqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript advance_to_gameplay_after_time.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Loaded_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("81064a0c-20ee-4276-8959-e391e165adc4", "Load_Level", Relay_Loaded_6)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript advance_to_gameplay_after_time.uscript at Load Level.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("81064a0c-20ee-4276-8959-e391e165adc4", "Load_Level", Relay_In_6)) return; 
         {
            {
               logic_uScriptAct_LoadLevel_name_6 = local_7_System_String;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_6.In(logic_uScriptAct_LoadLevel_name_6, logic_uScriptAct_LoadLevel_destroyOtherObjects_6, logic_uScriptAct_LoadLevel_blockUntilLoaded_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript advance_to_gameplay_after_time.uscript at Load Level.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f6117f0b-c597-48d3-85ec-4103c84a2ed3", "Add_Int", Relay_In_8)) return; 
         {
            {
               logic_uScriptAct_AddInt_v2_A_8 = local_timer_System_Int32;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8.In(logic_uScriptAct_AddInt_v2_A_8, logic_uScriptAct_AddInt_v2_B_8, out logic_uScriptAct_AddInt_v2_IntResult_8, out logic_uScriptAct_AddInt_v2_FloatResult_8);
         local_timer_System_Int32 = logic_uScriptAct_AddInt_v2_IntResult_8;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript advance_to_gameplay_after_time.uscript at Add Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "advance_to_gameplay_after_time.uscript:timer", local_timer_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a5cdc0f9-fe9b-4637-b099-4d5a8c2af2ad", local_timer_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "advance_to_gameplay_after_time.uscript:7", local_7_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "58f818ed-aec9-444f-8ea3-080f599a7611", local_7_System_String);
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
