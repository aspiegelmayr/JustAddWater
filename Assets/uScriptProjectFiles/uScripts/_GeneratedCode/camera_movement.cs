//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("", "")]
public class camera_movement : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.Vector3 camera_offset = new Vector3( (float)0, (float)4, (float)-5 );
   public UnityEngine.GameObject follow_target = default(UnityEngine.GameObject);
   UnityEngine.GameObject follow_target_previous = null;
   UnityEngine.Vector3 local_5_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_8_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   public System.Boolean should_follow_during_cutscene = (bool) false;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
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
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_4 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( follow_target_previous != follow_target || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         follow_target_previous = follow_target;
         
         //setup new listeners
      }
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( follow_target_previous != follow_target || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         follow_target_previous = follow_target;
         
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
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_0.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_2.SetParent(g);
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_6.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.SetParent(g);
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_11.SetParent(g);
      owner_Connection_1 = parentGameObject;
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
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
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
               if ( follow_target_previous != follow_target || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  follow_target_previous = follow_target;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetPositionAndRotation_Target_2 = follow_target;
            
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
      Relay_In_2();
   }
   
   void Relay_OnLateUpdate_4()
   {
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
   
}
