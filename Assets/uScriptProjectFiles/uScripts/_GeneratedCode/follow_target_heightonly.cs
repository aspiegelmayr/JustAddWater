//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("", "")]
public class follow_target_heightonly : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Single height_offset = (float) 0;
   UnityEngine.Vector3 local_11_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_37_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_39_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_61_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_62_System_Single = (float) 0;
   System.Single local_63_System_Single = (float) 0;
   System.Single local_desired_height_System_Single = (float) 0;
   System.Single local_desired_offset_x_System_Single = (float) 0;
   System.Single local_desired_offset_z_System_Single = (float) 0;
   UnityEngine.Vector3 local_desired_pos_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_desired_xz_pos_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_dist_from_target_System_Single = (float) 0;
   UnityEngine.Vector3 local_final_pos_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_owner_to_target_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_target_y_pos_System_Single = (float) 0;
   UnityEngine.Vector3 local_xz_offset_from_target_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   public System.Boolean shoul_look_at_target_during_cutscene = (bool) true;
   public System.Boolean should_follow_during_cutscene = (bool) false;
   public System.Boolean should_look_at_target = (bool) false;
   public System.Boolean should_look_in_direction_of_movement = (bool) false;
   public UnityEngine.GameObject target = default(UnityEngine.GameObject);
   UnityEngine.GameObject target_previous = null;
   public System.Single xz_distance = (float) 8;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_13 = null;
   UnityEngine.GameObject owner_Connection_22 = null;
   UnityEngine.GameObject owner_Connection_33 = null;
   UnityEngine.GameObject owner_Connection_50 = null;
   UnityEngine.GameObject owner_Connection_53 = null;
   UnityEngine.GameObject owner_Connection_150 = null;
   UnityEngine.GameObject owner_Connection_157 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_2 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_2 = true;
   bool logic_uScriptCon_CompareBool_False_2 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_4 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_4 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_4 = true;
   bool logic_uScriptCon_CompareBool_False_4 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_8 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_8 = true;
   bool logic_uScriptCon_CompareBool_False_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRigidbodyVelocity logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_9 = new uScriptAct_GetRigidbodyVelocity( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidbodyVelocity_Target_9 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_GetRigidbodyVelocity_Velocity_9;
   System.Single logic_uScriptAct_GetRigidbodyVelocity_Magnitude_9;
   bool logic_uScriptAct_GetRigidbodyVelocity_Out_9 = true;
   //pointer to script instanced logic node
   uScriptNodeLookInDirection logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_12 = new uScriptNodeLookInDirection( );
   UnityEngine.GameObject logic_uScriptNodeLookInDirection_target_12 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptNodeLookInDirection_direction_12 = new Vector3( );
   System.Single logic_uScriptNodeLookInDirection_ease_factor_12 = (float) 0.200000003;
   bool logic_uScriptNodeLookInDirection_Out_12 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_14 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_14 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_14 = true;
   bool logic_uScriptCon_CompareBool_False_14 = true;
   //pointer to script instanced logic node
   uScriptNodeIsDialogueRunning logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_16 = new uScriptNodeIsDialogueRunning( );
   bool logic_uScriptNodeIsDialogueRunning_True_16 = true;
   bool logic_uScriptNodeIsDialogueRunning_False_16 = true;
   //pointer to script instanced logic node
   uScriptAct_GetVector3Distance logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_19 = new uScriptAct_GetVector3Distance( );
   UnityEngine.Vector3 logic_uScriptAct_GetVector3Distance_A_19 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetVector3Distance_B_19 = new Vector3( );
   System.Single logic_uScriptAct_GetVector3Distance_Distance_19;
   bool logic_uScriptAct_GetVector3Distance_Out_19 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_25 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_25 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_25 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_25;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_25;
   bool logic_uScriptAct_AddFloat_v2_Out_25 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_29 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_29 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_29;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_29;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_29;
   bool logic_uScriptAct_GetComponentsVector3_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_31 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_31 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_31 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_31 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_31;
   bool logic_uScriptAct_SetComponentsVector3_Out_31 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractVector3 logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_32 = new uScriptAct_SubtractVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SubtractVector3_A_32 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SubtractVector3_B_32 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SubtractVector3_Result_32;
   bool logic_uScriptAct_SubtractVector3_Out_32 = true;
   //pointer to script instanced logic node
   uScriptAct_NormalizeVector3 logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_38 = new uScriptAct_NormalizeVector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_Target_38 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_NormalizedVector_38;
   bool logic_uScriptAct_NormalizeVector3_Out_38 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_40 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_40 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_40 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_40;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_40 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_42 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_42 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_42;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_42;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_42;
   bool logic_uScriptAct_GetComponentsVector3_Out_42 = true;
   //pointer to script instanced logic node
   uScriptNodeVector3Lerp logic_uScriptNodeVector3Lerp_uScriptNodeVector3Lerp_46 = new uScriptNodeVector3Lerp( );
   UnityEngine.Vector3 logic_uScriptNodeVector3Lerp_A_46 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptNodeVector3Lerp_B_46 = new Vector3( );
   System.Single logic_uScriptNodeVector3Lerp_p_46 = (float) 0.100000001;
   UnityEngine.Vector3 logic_uScriptNodeVector3Lerp_Result_46;
   bool logic_uScriptNodeVector3Lerp_Out_46 = true;
   //pointer to script instanced logic node
   uScriptNodeIsDialogueRunning logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_47 = new uScriptNodeIsDialogueRunning( );
   bool logic_uScriptNodeIsDialogueRunning_True_47 = true;
   bool logic_uScriptNodeIsDialogueRunning_False_47 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_52 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_52 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_52 = new Vector3( );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_52 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_52 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_52 = true;
   //pointer to script instanced logic node
   uScriptAct_AddVector3_v2 logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_57 = new uScriptAct_AddVector3_v2( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_A_57 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_B_57 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_Result_57;
   bool logic_uScriptAct_AddVector3_v2_Out_57 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_60 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_60 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_60;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_60;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_60;
   bool logic_uScriptAct_GetComponentsVector3_Out_60 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_64 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_64 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_64 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_64 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_64;
   bool logic_uScriptAct_SetComponentsVector3_Out_64 = true;
   //pointer to script instanced logic node
   uScriptNodeLookInDirection logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_142 = new uScriptNodeLookInDirection( );
   UnityEngine.GameObject logic_uScriptNodeLookInDirection_target_142 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptNodeLookInDirection_direction_142 = new Vector3( );
   System.Single logic_uScriptNodeLookInDirection_ease_factor_142 = (float) 0.200000003;
   bool logic_uScriptNodeLookInDirection_Out_142 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractVector3 logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_143 = new uScriptAct_SubtractVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SubtractVector3_A_143 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SubtractVector3_B_143 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SubtractVector3_Result_143;
   bool logic_uScriptAct_SubtractVector3_Out_143 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_3 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_7 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_18 = default(UnityEngine.GameObject);
   
   //property nodes
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_21 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_23 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_27 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_34 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_35 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_51 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_59 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_145 = new Vector3( );
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_148 = new Vector3( );
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_21_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_21_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_21;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_23_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_22 != null)
      {
         component = owner_Connection_22.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_23_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_22 != null)
      {
         component = owner_Connection_22.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_23;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_27_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_27_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_27;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_34_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_33 != null)
      {
         component = owner_Connection_33.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_34_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_33 != null)
      {
         component = owner_Connection_33.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_34;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_35_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_35_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_35;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_51_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_50 != null)
      {
         component = owner_Connection_50.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_51_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_50 != null)
      {
         component = owner_Connection_50.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_51;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_59_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_59_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_59;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_145_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_145_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (target != null)
      {
         component = target.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_145;
      }
   }
   
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_148_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_150 != null)
      {
         component = owner_Connection_150.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.position;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_position_Detox_ScriptEditor_Parameter_position_148_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_150 != null)
      {
         component = owner_Connection_150.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_148;
      }
   }
   
   
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
      if ( null == owner_Connection_13 || false == m_RegisteredForEvents )
      {
         owner_Connection_13 = parentGameObject;
      }
      if ( null == owner_Connection_22 || false == m_RegisteredForEvents )
      {
         owner_Connection_22 = parentGameObject;
      }
      if ( null == owner_Connection_33 || false == m_RegisteredForEvents )
      {
         owner_Connection_33 = parentGameObject;
      }
      if ( null == owner_Connection_50 || false == m_RegisteredForEvents )
      {
         owner_Connection_50 = parentGameObject;
      }
      if ( null == owner_Connection_53 || false == m_RegisteredForEvents )
      {
         owner_Connection_53 = parentGameObject;
      }
      if ( null == owner_Connection_150 || false == m_RegisteredForEvents )
      {
         owner_Connection_150 = parentGameObject;
      }
      if ( null == owner_Connection_157 || false == m_RegisteredForEvents )
      {
         owner_Connection_157 = parentGameObject;
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
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_0;
                  component.OnLateUpdate += Instance_OnLateUpdate_0;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_0;
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
      if ( null == event_UnityEngine_GameObject_Instance_7 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_7 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_7 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_7.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_7.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_7;
                  component.OnLateUpdate += Instance_OnLateUpdate_7;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_7;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_18 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_18 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_18 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_18.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_18.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_18;
                  component.OnLateUpdate += Instance_OnLateUpdate_18;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_18;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
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
      if ( null != event_UnityEngine_GameObject_Instance_7 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_7.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_7;
               component.OnLateUpdate -= Instance_OnLateUpdate_7;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_7;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_18 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_18.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_18;
               component.OnLateUpdate -= Instance_OnLateUpdate_18;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_18;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_4.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8.SetParent(g);
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_9.SetParent(g);
      logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_12.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_14.SetParent(g);
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_16.SetParent(g);
      logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_19.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_25.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_29.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_31.SetParent(g);
      logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_32.SetParent(g);
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_38.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_40.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_42.SetParent(g);
      logic_uScriptNodeVector3Lerp_uScriptNodeVector3Lerp_46.SetParent(g);
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_47.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_52.SetParent(g);
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_57.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_60.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_64.SetParent(g);
      logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_142.SetParent(g);
      logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_143.SetParent(g);
      owner_Connection_13 = parentGameObject;
      owner_Connection_22 = parentGameObject;
      owner_Connection_33 = parentGameObject;
      owner_Connection_50 = parentGameObject;
      owner_Connection_53 = parentGameObject;
      owner_Connection_150 = parentGameObject;
      owner_Connection_157 = parentGameObject;
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
   
   void Instance_OnUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_0( );
   }
   
   void Instance_OnLateUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_0( );
   }
   
   void Instance_OnFixedUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_0( );
   }
   
   void Instance_OnUpdate_3(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_3( );
   }
   
   void Instance_OnLateUpdate_3(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_3( );
   }
   
   void Instance_OnFixedUpdate_3(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_3( );
   }
   
   void Instance_OnUpdate_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_7( );
   }
   
   void Instance_OnLateUpdate_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_7( );
   }
   
   void Instance_OnFixedUpdate_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_7( );
   }
   
   void Instance_OnUpdate_18(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_18( );
   }
   
   void Instance_OnLateUpdate_18(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_18( );
   }
   
   void Instance_OnFixedUpdate_18(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_18( );
   }
   
   void Relay_OnUpdate_0()
   {
   }
   
   void Relay_OnLateUpdate_0()
   {
      Relay_In_2();
   }
   
   void Relay_OnFixedUpdate_0()
   {
   }
   
   void Relay_In_2()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_2 = should_follow_during_cutscene;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.In(logic_uScriptCon_CompareBool_Bool_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.True;
      bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.False;
      
      if ( test_0 == true )
      {
         Relay_In_46();
      }
      if ( test_1 == true )
      {
         Relay_In_47();
      }
   }
   
   void Relay_OnUpdate_3()
   {
   }
   
   void Relay_OnLateUpdate_3()
   {
      Relay_In_4();
   }
   
   void Relay_OnFixedUpdate_3()
   {
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_4 = should_look_at_target;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_4.In(logic_uScriptCon_CompareBool_Bool_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_4.True;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_OnUpdate_7()
   {
   }
   
   void Relay_OnLateUpdate_7()
   {
      Relay_In_8();
   }
   
   void Relay_OnFixedUpdate_7()
   {
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_8 = should_look_in_direction_of_movement;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8.In(logic_uScriptCon_CompareBool_Bool_8);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8.True;
      
      if ( test_0 == true )
      {
         Relay_In_9();
      }
   }
   
   void Relay_In_9()
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
            logic_uScriptAct_GetRigidbodyVelocity_Target_9 = target;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_9.In(logic_uScriptAct_GetRigidbodyVelocity_Target_9, out logic_uScriptAct_GetRigidbodyVelocity_Velocity_9, out logic_uScriptAct_GetRigidbodyVelocity_Magnitude_9);
      local_11_UnityEngine_Vector3 = logic_uScriptAct_GetRigidbodyVelocity_Velocity_9;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_9.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
      }
   }
   
   void Relay_In_12()
   {
      {
         {
            logic_uScriptNodeLookInDirection_target_12 = owner_Connection_13;
            
         }
         {
            logic_uScriptNodeLookInDirection_direction_12 = local_11_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_12.In(logic_uScriptNodeLookInDirection_target_12, logic_uScriptNodeLookInDirection_direction_12, logic_uScriptNodeLookInDirection_ease_factor_12);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_14()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_14 = shoul_look_at_target_during_cutscene;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_14.In(logic_uScriptCon_CompareBool_Bool_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_14.True;
      
      if ( test_0 == true )
      {
         Relay_In_143();
      }
   }
   
   void Relay_In_16()
   {
      {
      }
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_16.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_16.True;
      bool test_1 = logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_16.False;
      
      if ( test_0 == true )
      {
         Relay_In_14();
      }
      if ( test_1 == true )
      {
         Relay_In_143();
      }
   }
   
   void Relay_OnUpdate_18()
   {
      Relay_In_19();
   }
   
   void Relay_OnLateUpdate_18()
   {
   }
   
   void Relay_OnFixedUpdate_18()
   {
   }
   
   void Relay_In_19()
   {
      {
         {
            logic_uScriptAct_GetVector3Distance_A_19 = property_position_Detox_ScriptEditor_Parameter_position_21_Get_Refresh( );
         }
         {
            logic_uScriptAct_GetVector3Distance_B_19 = property_position_Detox_ScriptEditor_Parameter_position_23_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_19.In(logic_uScriptAct_GetVector3Distance_A_19, logic_uScriptAct_GetVector3Distance_B_19, out logic_uScriptAct_GetVector3Distance_Distance_19);
      local_dist_from_target_System_Single = logic_uScriptAct_GetVector3Distance_Distance_19;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetVector3Distance_uScriptAct_GetVector3Distance_19.Out;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
   }
   
   void Relay_In_25()
   {
      {
         {
            logic_uScriptAct_AddFloat_v2_A_25 = local_target_y_pos_System_Single;
            
         }
         {
            logic_uScriptAct_AddFloat_v2_B_25 = height_offset;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_25.In(logic_uScriptAct_AddFloat_v2_A_25, logic_uScriptAct_AddFloat_v2_B_25, out logic_uScriptAct_AddFloat_v2_FloatResult_25, out logic_uScriptAct_AddFloat_v2_IntResult_25);
      local_desired_height_System_Single = logic_uScriptAct_AddFloat_v2_FloatResult_25;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_25.Out;
      
      if ( test_0 == true )
      {
         Relay_In_32();
      }
   }
   
   void Relay_In_29()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_29 = property_position_Detox_ScriptEditor_Parameter_position_27_Get_Refresh( );
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_29.In(logic_uScriptAct_GetComponentsVector3_InputVector3_29, out logic_uScriptAct_GetComponentsVector3_X_29, out logic_uScriptAct_GetComponentsVector3_Y_29, out logic_uScriptAct_GetComponentsVector3_Z_29);
      local_target_y_pos_System_Single = logic_uScriptAct_GetComponentsVector3_Y_29;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_29.Out;
      
      if ( test_0 == true )
      {
         Relay_In_25();
      }
   }
   
   void Relay_In_31()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector3_X_31 = local_desired_offset_x_System_Single;
            
         }
         {
         }
         {
            logic_uScriptAct_SetComponentsVector3_Z_31 = local_desired_offset_z_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_31.In(logic_uScriptAct_SetComponentsVector3_X_31, logic_uScriptAct_SetComponentsVector3_Y_31, logic_uScriptAct_SetComponentsVector3_Z_31, out logic_uScriptAct_SetComponentsVector3_OutputVector3_31);
      local_xz_offset_from_target_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_31;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_31.Out;
      
      if ( test_0 == true )
      {
         Relay_In_57();
      }
   }
   
   void Relay_In_32()
   {
      {
         {
            logic_uScriptAct_SubtractVector3_A_32 = property_position_Detox_ScriptEditor_Parameter_position_34_Get_Refresh( );
         }
         {
            logic_uScriptAct_SubtractVector3_B_32 = property_position_Detox_ScriptEditor_Parameter_position_35_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_32.In(logic_uScriptAct_SubtractVector3_A_32, logic_uScriptAct_SubtractVector3_B_32, out logic_uScriptAct_SubtractVector3_Result_32);
      local_37_UnityEngine_Vector3 = logic_uScriptAct_SubtractVector3_Result_32;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_32.Out;
      
      if ( test_0 == true )
      {
         Relay_In_38();
      }
   }
   
   void Relay_In_38()
   {
      {
         {
            logic_uScriptAct_NormalizeVector3_Target_38 = local_37_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_38.In(logic_uScriptAct_NormalizeVector3_Target_38, out logic_uScriptAct_NormalizeVector3_NormalizedVector_38);
      local_39_UnityEngine_Vector3 = logic_uScriptAct_NormalizeVector3_NormalizedVector_38;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_38.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_In_40()
   {
      {
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_40 = local_39_UnityEngine_Vector3;
            
         }
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_40 = xz_distance;
            
         }
         {
         }
      }
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_40.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_40, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_40, out logic_uScriptAct_MultiplyVector3WithFloat_Result_40);
      local_desired_xz_pos_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_40;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_40.Out;
      
      if ( test_0 == true )
      {
         Relay_In_42();
      }
   }
   
   void Relay_In_42()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_42 = local_desired_xz_pos_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_42.In(logic_uScriptAct_GetComponentsVector3_InputVector3_42, out logic_uScriptAct_GetComponentsVector3_X_42, out logic_uScriptAct_GetComponentsVector3_Y_42, out logic_uScriptAct_GetComponentsVector3_Z_42);
      local_desired_offset_x_System_Single = logic_uScriptAct_GetComponentsVector3_X_42;
      local_desired_offset_z_System_Single = logic_uScriptAct_GetComponentsVector3_Z_42;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_42.Out;
      
      if ( test_0 == true )
      {
         Relay_In_31();
      }
   }
   
   void Relay_In_46()
   {
      {
         {
            logic_uScriptNodeVector3Lerp_A_46 = property_position_Detox_ScriptEditor_Parameter_position_51_Get_Refresh( );
         }
         {
            logic_uScriptNodeVector3Lerp_B_46 = local_desired_pos_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptNodeVector3Lerp_uScriptNodeVector3Lerp_46.In(logic_uScriptNodeVector3Lerp_A_46, logic_uScriptNodeVector3Lerp_B_46, logic_uScriptNodeVector3Lerp_p_46, out logic_uScriptNodeVector3Lerp_Result_46);
      local_final_pos_UnityEngine_Vector3 = logic_uScriptNodeVector3Lerp_Result_46;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeVector3Lerp_uScriptNodeVector3Lerp_46.Out;
      
      if ( test_0 == true )
      {
         Relay_In_52();
      }
   }
   
   void Relay_In_47()
   {
      {
      }
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_47.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_47.False;
      
      if ( test_0 == true )
      {
         Relay_In_46();
      }
   }
   
   void Relay_In_52()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectPosition_Target_52.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_52, index + 1);
            }
            logic_uScriptAct_SetGameObjectPosition_Target_52[ index++ ] = owner_Connection_53;
            
         }
         {
            logic_uScriptAct_SetGameObjectPosition_Position_52 = local_final_pos_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_52.In(logic_uScriptAct_SetGameObjectPosition_Target_52, logic_uScriptAct_SetGameObjectPosition_Position_52, logic_uScriptAct_SetGameObjectPosition_AsOffset_52, logic_uScriptAct_SetGameObjectPosition_AsLocal_52);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_57()
   {
      {
         {
            logic_uScriptAct_AddVector3_v2_A_57 = local_xz_offset_from_target_UnityEngine_Vector3;
            
         }
         {
            logic_uScriptAct_AddVector3_v2_B_57 = property_position_Detox_ScriptEditor_Parameter_position_59_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_57.In(logic_uScriptAct_AddVector3_v2_A_57, logic_uScriptAct_AddVector3_v2_B_57, out logic_uScriptAct_AddVector3_v2_Result_57);
      local_61_UnityEngine_Vector3 = logic_uScriptAct_AddVector3_v2_Result_57;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_57.Out;
      
      if ( test_0 == true )
      {
         Relay_In_60();
      }
   }
   
   void Relay_In_60()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_60 = local_61_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_60.In(logic_uScriptAct_GetComponentsVector3_InputVector3_60, out logic_uScriptAct_GetComponentsVector3_X_60, out logic_uScriptAct_GetComponentsVector3_Y_60, out logic_uScriptAct_GetComponentsVector3_Z_60);
      local_62_System_Single = logic_uScriptAct_GetComponentsVector3_X_60;
      local_63_System_Single = logic_uScriptAct_GetComponentsVector3_Z_60;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_60.Out;
      
      if ( test_0 == true )
      {
         Relay_In_64();
      }
   }
   
   void Relay_In_64()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector3_X_64 = local_62_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector3_Y_64 = local_desired_height_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector3_Z_64 = local_63_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_64.In(logic_uScriptAct_SetComponentsVector3_X_64, logic_uScriptAct_SetComponentsVector3_Y_64, logic_uScriptAct_SetComponentsVector3_Z_64, out logic_uScriptAct_SetComponentsVector3_OutputVector3_64);
      local_desired_pos_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_64;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_142()
   {
      {
         {
            logic_uScriptNodeLookInDirection_target_142 = owner_Connection_157;
            
         }
         {
            logic_uScriptNodeLookInDirection_direction_142 = local_owner_to_target_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptNodeLookInDirection_uScriptNodeLookInDirection_142.In(logic_uScriptNodeLookInDirection_target_142, logic_uScriptNodeLookInDirection_direction_142, logic_uScriptNodeLookInDirection_ease_factor_142);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_143()
   {
      {
         {
            logic_uScriptAct_SubtractVector3_A_143 = property_position_Detox_ScriptEditor_Parameter_position_145_Get_Refresh( );
         }
         {
            logic_uScriptAct_SubtractVector3_B_143 = property_position_Detox_ScriptEditor_Parameter_position_148_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_143.In(logic_uScriptAct_SubtractVector3_A_143, logic_uScriptAct_SubtractVector3_B_143, out logic_uScriptAct_SubtractVector3_Result_143);
      local_owner_to_target_UnityEngine_Vector3 = logic_uScriptAct_SubtractVector3_Result_143;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SubtractVector3_uScriptAct_SubtractVector3_143.Out;
      
      if ( test_0 == true )
      {
         Relay_In_142();
      }
   }
   
}
