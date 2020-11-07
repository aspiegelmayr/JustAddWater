//uScript Generated Code - Build 1.1.3133
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class npc : uScriptLogic
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
   public System.Single Distance_between_NPC_and_Player = (float) 0;
   UnityEngine.Vector3 local_15_UnityEngine_Vector3 = new Vector3( (float)7, (float)7, (float)7 );
   UnityEngine.Vector3 local_16_UnityEngine_Vector3 = new Vector3( (float)5, (float)5, (float)5 );
   System.Single local_Detection_Range_System_Single = (float) 20;
   UnityEngine.Vector3 local_NPC_Position_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_Player_Position_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_Player_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_Player_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   UnityEngine.GameObject owner_Connection_11 = null;
   UnityEngine.GameObject owner_Connection_14 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetVector3Distance logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_0 = new uScriptAct_GetVector3Distance( );
   UnityEngine.Vector3 logic_uScriptAct_GetVector3Distance_A_0 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetVector3Distance_B_0 = new Vector3( );
   System.Single logic_uScriptAct_GetVector3Distance_Distance_0;
   bool logic_uScriptAct_GetVector3Distance_Out_0 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_2 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_2 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_2 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_2;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_2;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_2;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_2;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_2;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_2;
   bool logic_uScriptAct_GetPositionAndRotation_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_6 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_6 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_6 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_6;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_6;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_6;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_6;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_6;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_6;
   bool logic_uScriptAct_GetPositionAndRotation_Out_6 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_9 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_9 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_9 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_9 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_9 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_12 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_12 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_12 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_12 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_13 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_13 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_13 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_17 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_17 = "";
   System.Object[] logic_uScriptAct_Log_Target_17 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_17 = "";
   bool logic_uScriptAct_Log_Out_17 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_Player_UnityEngine_GameObject = GameObject.Find( "Player" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Update component = owner_Connection_1.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Update>();
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
      if ( null == owner_Connection_11 || false == m_RegisteredForEvents )
      {
         owner_Connection_11 = parentGameObject;
      }
      if ( null == owner_Connection_14 || false == m_RegisteredForEvents )
      {
         owner_Connection_14 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Update component = owner_Connection_1.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Update>();
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
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_1 )
      {
         {
            uScript_Update component = owner_Connection_1.GetComponent<uScript_Update>();
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
      
      logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_0.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_2.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_6.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_12.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_13.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_17.SetParent(g);
      owner_Connection_1 = parentGameObject;
      owner_Connection_11 = parentGameObject;
      owner_Connection_14 = parentGameObject;
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
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("323e65dd-fe32-466c-8883-d2fffe27ba5f", "Get_Vector3_Distance", Relay_In_0)) return; 
         {
            {
               logic_uScriptAct_GetVector3Distance_A_0 = local_NPC_Position_UnityEngine_Vector3;
               
            }
            {
               logic_uScriptAct_GetVector3Distance_B_0 = local_Player_Position_UnityEngine_Vector3;
               
            }
            {
            }
         }
         logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_0.In(logic_uScriptAct_GetVector3Distance_A_0, logic_uScriptAct_GetVector3Distance_B_0, out logic_uScriptAct_GetVector3Distance_Distance_0);
         Distance_between_NPC_and_Player = logic_uScriptAct_GetVector3Distance_Distance_0;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_0.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
            Relay_In_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript npc.uscript at Get Vector3 Distance.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("026dda0a-58d6-4c60-a89c-5f8e2a3d920c", "Get_Position_and_Rotation", Relay_In_2)) return; 
         {
            {
               logic_uScriptAct_GetPositionAndRotation_Target_2 = owner_Connection_1;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_2.In(logic_uScriptAct_GetPositionAndRotation_Target_2, logic_uScriptAct_GetPositionAndRotation_GetLocal_2, out logic_uScriptAct_GetPositionAndRotation_Position_2, out logic_uScriptAct_GetPositionAndRotation_Rotation_2, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_2, out logic_uScriptAct_GetPositionAndRotation_Forward_2, out logic_uScriptAct_GetPositionAndRotation_Up_2, out logic_uScriptAct_GetPositionAndRotation_Right_2);
         local_NPC_Position_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_2;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_2.Out;
         
         if ( test_0 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript npc.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_4()
   {
      if (true == CheckDebugBreak("d70de532-cca2-43ab-ab4b-fc7ab97bbe5b", "Global_Update", Relay_OnUpdate_4)) return; 
      Relay_In_2();
   }
   
   void Relay_OnLateUpdate_4()
   {
      if (true == CheckDebugBreak("d70de532-cca2-43ab-ab4b-fc7ab97bbe5b", "Global_Update", Relay_OnLateUpdate_4)) return; 
   }
   
   void Relay_OnFixedUpdate_4()
   {
      if (true == CheckDebugBreak("d70de532-cca2-43ab-ab4b-fc7ab97bbe5b", "Global_Update", Relay_OnFixedUpdate_4)) return; 
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ad18d21e-2ec6-4521-b7fa-b057bd058c2f", "Get_Position_and_Rotation", Relay_In_6)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_GetPositionAndRotation_Target_6 = local_Player_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_6.In(logic_uScriptAct_GetPositionAndRotation_Target_6, logic_uScriptAct_GetPositionAndRotation_GetLocal_6, out logic_uScriptAct_GetPositionAndRotation_Position_6, out logic_uScriptAct_GetPositionAndRotation_Rotation_6, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_6, out logic_uScriptAct_GetPositionAndRotation_Forward_6, out logic_uScriptAct_GetPositionAndRotation_Up_6, out logic_uScriptAct_GetPositionAndRotation_Right_6);
         local_Player_Position_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_6;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_6.Out;
         
         if ( test_0 == true )
         {
            Relay_In_0();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript npc.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a90f1c29-bc36-4263-8407-9d2394d7649f", "Compare_Float", Relay_In_9)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_9 = Distance_between_NPC_and_Player;
               
            }
            {
               logic_uScriptCon_CompareFloat_B_9 = local_Detection_Range_System_Single;
               
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.In(logic_uScriptCon_CompareFloat_A_9, logic_uScriptCon_CompareFloat_B_9);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.GreaterThan;
         bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_9.LessThanOrEqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_13();
         }
         if ( test_1 == true )
         {
            Relay_In_12();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript npc.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("cea9b1cc-437d-426f-876b-51120121903f", "Set_Scale", Relay_In_12)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_SetGameObjectScale_Target_12.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_12, index + 1);
               }
               logic_uScriptAct_SetGameObjectScale_Target_12[ index++ ] = owner_Connection_11;
               
            }
            {
               logic_uScriptAct_SetGameObjectScale_Scale_12 = local_15_UnityEngine_Vector3;
               
            }
         }
         logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_12.In(logic_uScriptAct_SetGameObjectScale_Target_12, logic_uScriptAct_SetGameObjectScale_Scale_12);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript npc.uscript at Set Scale.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ff5c7d49-b45f-4afa-9c97-2591d95e3f2b", "Set_Scale", Relay_In_13)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_SetGameObjectScale_Target_13.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_13, index + 1);
               }
               logic_uScriptAct_SetGameObjectScale_Target_13[ index++ ] = owner_Connection_14;
               
            }
            {
               logic_uScriptAct_SetGameObjectScale_Scale_13 = local_16_UnityEngine_Vector3;
               
            }
         }
         logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_13.In(logic_uScriptAct_SetGameObjectScale_Target_13, logic_uScriptAct_SetGameObjectScale_Scale_13);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript npc.uscript at Set Scale.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1d71241e-0a3d-400d-9ba4-54f2d0fa575b", "Log", Relay_In_17)) return; 
         {
            {
            }
            {
               int index = 0;
               if ( logic_uScriptAct_Log_Target_17.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Log_Target_17, index + 1);
               }
               logic_uScriptAct_Log_Target_17[ index++ ] = Distance_between_NPC_and_Player;
               
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_17.In(logic_uScriptAct_Log_Prefix_17, logic_uScriptAct_Log_Target_17, logic_uScriptAct_Log_Postfix_17);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript npc.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "npc.uscript:NPC Position", local_NPC_Position_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "fb3e0430-b8db-4cee-b8c3-8923ecf8989e", local_NPC_Position_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "npc.uscript:Player", local_Player_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3bef81d6-f7fa-41e6-a780-b9ef2f9e7003", local_Player_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "npc.uscript:Player Position", local_Player_Position_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9d50692e-fc28-4f1a-91c7-8d82db24292f", local_Player_Position_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "npc.uscript:Distance between NPC and Player", Distance_between_NPC_and_Player);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "2012b562-0e7e-4034-a021-591ddba7f76b", Distance_between_NPC_and_Player);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "npc.uscript:Detection Range", local_Detection_Range_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e8488f32-f453-4e46-9aa1-841bb81313a6", local_Detection_Range_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "npc.uscript:15", local_15_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e299f3d6-50b5-4110-8ad4-5593d0bc1db7", local_15_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "npc.uscript:16", local_16_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "75f977d3-b09d-4acb-848b-bb3d8efd88ba", local_16_UnityEngine_Vector3);
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
