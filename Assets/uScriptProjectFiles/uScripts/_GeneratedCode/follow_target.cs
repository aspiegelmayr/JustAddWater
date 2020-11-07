//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("", "")]
public class follow_target : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.Vector3 camera_offset = new Vector3( (float)0, (float)4, (float)-5 );
   UnityEngine.Vector3 local_23_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_5_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_8_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   public System.Boolean shoul_look_at_target_during_cutscene = (bool) true;
   public System.Boolean should_follow_during_cutscene = (bool) false;
   public System.Boolean should_look_at_target = (bool) false;
   public System.Boolean should_look_in_direction_of_movement = (bool) false;
   public UnityEngine.GameObject target = default(UnityEngine.GameObject);
   UnityEngine.GameObject target_previous = null;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   UnityEngine.GameObject owner_Connection_16 = null;
   UnityEngine.GameObject owner_Connection_25 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_0 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_0 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_0 = new Vector3( );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_0 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_0 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_0 = true;
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
   uScriptAct_AddVector3_v2 logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6 = new uScriptAct_AddVector3_v2( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_A_6 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_B_6 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_Result_6;
   bool logic_uScriptAct_AddVector3_v2_Out_6 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_10 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_10 = true;
   bool logic_uScriptCon_CompareBool_False_10 = true;
   //pointer to script instanced logic node
   uScriptNodeIsDialogueRunning logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_11 = new uScriptNodeIsDialogueRunning( );
   bool logic_uScriptNodeIsDialogueRunning_True_11 = true;
   bool logic_uScriptNodeIsDialogueRunning_False_11 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_13 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_13 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_13 = true;
   bool logic_uScriptCon_CompareBool_False_13 = true;
   //pointer to script instanced logic node
   uScriptAct_LookAt_v2 logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15 = new uScriptAct_LookAt_v2( );
   UnityEngine.GameObject[] logic_uScriptAct_LookAt_v2_Target_15 = new UnityEngine.GameObject[] {};
   System.Object logic_uScriptAct_LookAt_v2_Focus_15 = "";
   System.Single logic_uScriptAct_LookAt_v2_time_15 = (float) 1;
   uScriptAct_LookAt_v2.LockAxis logic_uScriptAct_LookAt_v2_lockAxis_15 = uScriptAct_LookAt_v2.LockAxis.None;
   System.Single logic_uScriptAct_LookAt_v2_DegreesPerSecond_15 = (float) 0;
   System.Boolean logic_uScriptAct_LookAt_v2_UseDegreesPerSecond_15 = (bool) true;
   System.Boolean logic_uScriptAct_LookAt_v2_LockAxisIsLocal_15 = (bool) false;
   bool logic_uScriptAct_LookAt_v2_Out_15 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_20 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_20 = true;
   bool logic_uScriptCon_CompareBool_False_20 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRigidbodyVelocity logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_21 = new uScriptAct_GetRigidbodyVelocity( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidbodyVelocity_Target_21 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_GetRigidbodyVelocity_Velocity_21;
   System.Single logic_uScriptAct_GetRigidbodyVelocity_Magnitude_21;
   bool logic_uScriptAct_GetRigidbodyVelocity_Out_21 = true;
   //pointer to script instanced logic node
   uScriptNodeLookInDirection logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_24 = new uScriptNodeLookInDirection( );
   UnityEngine.GameObject logic_uScriptNodeLookInDirection_target_24 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptNodeLookInDirection_direction_24 = new Vector3( );
   System.Single logic_uScriptNodeLookInDirection_ease_factor_24 = (float) 0.200000003;
   bool logic_uScriptNodeLookInDirection_Out_24 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_26 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_26 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_26 = true;
   bool logic_uScriptCon_CompareBool_False_26 = true;
   //pointer to script instanced logic node
   uScriptNodeIsDialogueRunning logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_28 = new uScriptNodeIsDialogueRunning( );
   bool logic_uScriptNodeIsDialogueRunning_True_28 = true;
   bool logic_uScriptNodeIsDialogueRunning_False_28 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_4 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_12 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_19 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( target_previous != target || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         target_previous = target;
         
         //setup new listeners
      }
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
      }
      if ( null == owner_Connection_16 || false == m_RegisteredForEvents )
      {
         owner_Connection_16 = parentGameObject;
      }
      if ( null == owner_Connection_25 || false == m_RegisteredForEvents )
      {
         owner_Connection_25 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( target_previous != target || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         target_previous = target;
         
         //setup new listeners
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
      if ( null == event_UnityEngine_GameObject_Instance_12 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_12 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_12 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_12.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_12.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_12;
                  component.OnLateUpdate += Instance_OnLateUpdate_12;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_12;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_19 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_19 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_19 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_19.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_19.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_19;
                  component.OnLateUpdate += Instance_OnLateUpdate_19;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_19;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
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
      if ( null != event_UnityEngine_GameObject_Instance_12 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_12.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_12;
               component.OnLateUpdate -= Instance_OnLateUpdate_12;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_12;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_19 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_19.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_19;
               component.OnLateUpdate -= Instance_OnLateUpdate_19;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_19;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_0.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_2.SetParent(g);
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.SetParent(g);
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_11.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_13.SetParent(g);
      logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20.SetParent(g);
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_21.SetParent(g);
      logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_24.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_26.SetParent(g);
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_28.SetParent(g);
      owner_Connection_1 = parentGameObject;
      owner_Connection_16 = parentGameObject;
      owner_Connection_25 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15.Finished += uScriptAct_LookAt_v2_Finished_15;
      logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15.NotFinished += uScriptAct_LookAt_v2_NotFinished_15;
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
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15.Finished -= uScriptAct_LookAt_v2_Finished_15;
      logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15.NotFinished -= uScriptAct_LookAt_v2_NotFinished_15;
   }
   
   void Instance_OnUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_4( );
   }
   
   void Instance_OnLateUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_4( );
   }
   
   void Instance_OnFixedUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_4( );
   }
   
   void Instance_OnUpdate_12(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_12( );
   }
   
   void Instance_OnLateUpdate_12(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_12( );
   }
   
   void Instance_OnFixedUpdate_12(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_12( );
   }
   
   void Instance_OnUpdate_19(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_19( );
   }
   
   void Instance_OnLateUpdate_19(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_19( );
   }
   
   void Instance_OnFixedUpdate_19(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_19( );
   }
   
   void uScriptAct_LookAt_v2_Finished_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_15( );
   }
   
   void uScriptAct_LookAt_v2_NotFinished_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_NotFinished_15( );
   }
   
   void Relay_In_0()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectPosition_Target_0.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_0, index + 1);
            }
            logic_uScriptAct_SetGameObjectPosition_Target_0[ index++ ] = owner_Connection_1;
            
         }
         {
            logic_uScriptAct_SetGameObjectPosition_Position_0 = local_8_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_0.In(logic_uScriptAct_SetGameObjectPosition_Target_0, logic_uScriptAct_SetGameObjectPosition_Position_0, logic_uScriptAct_SetGameObjectPosition_AsOffset_0, logic_uScriptAct_SetGameObjectPosition_AsLocal_0);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_2()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( target_previous != target || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  target_previous = target;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetPositionAndRotation_Target_2 = target;
            
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
      local_5_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_2;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_OnUpdate_4()
   {
   }
   
   void Relay_OnLateUpdate_4()
   {
      Relay_In_2();
   }
   
   void Relay_OnFixedUpdate_4()
   {
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptAct_AddVector3_v2_A_6 = local_5_UnityEngine_Vector3;
            
         }
         {
            logic_uScriptAct_AddVector3_v2_B_6 = camera_offset;
            
         }
         {
         }
      }
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6.In(logic_uScriptAct_AddVector3_v2_A_6, logic_uScriptAct_AddVector3_v2_B_6, out logic_uScriptAct_AddVector3_v2_Result_6);
      local_8_UnityEngine_Vector3 = logic_uScriptAct_AddVector3_v2_Result_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_In_10()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_10 = should_follow_during_cutscene;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.In(logic_uScriptCon_CompareBool_Bool_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.True;
      bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.False;
      
      if ( test_0 == true )
      {
         Relay_In_0();
      }
      if ( test_1 == true )
      {
         Relay_In_11();
      }
   }
   
   void Relay_In_11()
   {
      {
      }
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_11.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_11.False;
      
      if ( test_0 == true )
      {
         Relay_In_0();
      }
   }
   
   void Relay_OnUpdate_12()
   {
   }
   
   void Relay_OnLateUpdate_12()
   {
      Relay_In_13();
   }
   
   void Relay_OnFixedUpdate_12()
   {
   }
   
   void Relay_In_13()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_13 = should_look_at_target;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_13.In(logic_uScriptCon_CompareBool_Bool_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_13.True;
      
      if ( test_0 == true )
      {
         Relay_In_28();
      }
   }
   
   void Relay_Finished_15()
   {
   }
   
   void Relay_NotFinished_15()
   {
   }
   
   void Relay_In_15()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_LookAt_v2_Target_15.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_LookAt_v2_Target_15, index + 1);
            }
            logic_uScriptAct_LookAt_v2_Target_15[ index++ ] = owner_Connection_16;
            
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( target_previous != target || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  target_previous = target;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_LookAt_v2_Focus_15 = target;
            
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
      logic_uScriptAct_LookAt_v2_uScriptAct_LookAt_v2_15.In(logic_uScriptAct_LookAt_v2_Target_15, logic_uScriptAct_LookAt_v2_Focus_15, logic_uScriptAct_LookAt_v2_time_15, logic_uScriptAct_LookAt_v2_lockAxis_15, logic_uScriptAct_LookAt_v2_DegreesPerSecond_15, logic_uScriptAct_LookAt_v2_UseDegreesPerSecond_15, logic_uScriptAct_LookAt_v2_LockAxisIsLocal_15);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnUpdate_19()
   {
   }
   
   void Relay_OnLateUpdate_19()
   {
      Relay_In_20();
   }
   
   void Relay_OnFixedUpdate_19()
   {
   }
   
   void Relay_In_20()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_20 = should_look_in_direction_of_movement;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20.In(logic_uScriptCon_CompareBool_Bool_20);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20.True;
      
      if ( test_0 == true )
      {
         Relay_In_21();
      }
   }
   
   void Relay_In_21()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( target_previous != target || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  target_previous = target;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetRigidbodyVelocity_Target_21 = target;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_21.In(logic_uScriptAct_GetRigidbodyVelocity_Target_21, out logic_uScriptAct_GetRigidbodyVelocity_Velocity_21, out logic_uScriptAct_GetRigidbodyVelocity_Magnitude_21);
      local_23_UnityEngine_Vector3 = logic_uScriptAct_GetRigidbodyVelocity_Velocity_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_24();
      }
   }
   
   void Relay_In_24()
   {
      {
         {
            logic_uScriptNodeLookInDirection_target_24 = owner_Connection_25;
            
         }
         {
            logic_uScriptNodeLookInDirection_direction_24 = local_23_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_24.In(logic_uScriptNodeLookInDirection_target_24, logic_uScriptNodeLookInDirection_direction_24, logic_uScriptNodeLookInDirection_ease_factor_24);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_26()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_26 = shoul_look_at_target_during_cutscene;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_26.In(logic_uScriptCon_CompareBool_Bool_26);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_26.True;
      
      if ( test_0 == true )
      {
         Relay_In_15();
      }
   }
   
   void Relay_In_28()
   {
      {
      }
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_28.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_28.True;
      bool test_1 = logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_28.False;
      
      if ( test_0 == true )
      {
         Relay_In_26();
      }
      if ( test_1 == true )
      {
         Relay_In_15();
      }
   }
   
}
