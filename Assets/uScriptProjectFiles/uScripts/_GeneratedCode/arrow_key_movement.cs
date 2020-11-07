//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class arrow_key_movement : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject camera_gameobject = default(UnityEngine.GameObject);
   UnityEngine.GameObject camera_gameobject_previous = null;
   public System.Single jump_power = (float) 10;
   UnityEngine.KeyCode local_12_UnityEngine_KeyCode = UnityEngine.KeyCode.UpArrow;
   UnityEngine.KeyCode local_2_UnityEngine_KeyCode = UnityEngine.KeyCode.RightArrow;
   UnityEngine.KeyCode local_21_UnityEngine_KeyCode = UnityEngine.KeyCode.DownArrow;
   System.Single local_214_System_Single = (float) 0;
   System.Single local_216_System_Single = (float) 0;
   System.Single local_237_System_Single = (float) 0;
   System.Single local_239_System_Single = (float) 0;
   UnityEngine.KeyCode local_26_UnityEngine_KeyCode = UnityEngine.KeyCode.Space;
   UnityEngine.Vector3 local_30_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_31_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_35_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_41_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_48_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_53_System_Single = (float) 0;
   System.Single local_54_System_Single = (float) 0;
   UnityEngine.Vector3 local_57_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_66_System_Single = (float) 0;
   System.Single local_68_System_Single = (float) 0;
   UnityEngine.KeyCode local_7_UnityEngine_KeyCode = UnityEngine.KeyCode.LeftArrow;
   UnityEngine.Vector3 local_79_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_86_System_Single = (float) 0;
   System.Single local_87_System_Single = (float) 0;
   System.Single local_91_System_Single = (float) 0;
   System.Single local_94_System_Single = (float) 0;
   System.Single local_95_System_Single = (float) 0;
   UnityEngine.Vector3 local_camera_forward_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_camera_right_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_current_velocity_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_current_y_vel_System_Single = (float) 0;
   UnityEngine.Vector3 local_final_vel_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_final_xz_velocity_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_point_below_player_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_xz_velocity_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   public System.Single max_velocity = (float) 7;
   public System.Single speed = (float) 8;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_3 = null;
   UnityEngine.GameObject owner_Connection_5 = null;
   UnityEngine.GameObject owner_Connection_6 = null;
   UnityEngine.GameObject owner_Connection_15 = null;
   UnityEngine.GameObject owner_Connection_18 = null;
   UnityEngine.GameObject owner_Connection_24 = null;
   UnityEngine.GameObject owner_Connection_27 = null;
   UnityEngine.GameObject owner_Connection_33 = null;
   UnityEngine.GameObject owner_Connection_37 = null;
   UnityEngine.GameObject owner_Connection_42 = null;
   UnityEngine.GameObject owner_Connection_45 = null;
   UnityEngine.GameObject owner_Connection_47 = null;
   UnityEngine.GameObject owner_Connection_51 = null;
   UnityEngine.GameObject owner_Connection_60 = null;
   UnityEngine.GameObject owner_Connection_74 = null;
   UnityEngine.GameObject owner_Connection_84 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_1 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_1 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_4 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_4 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_4 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_4 = true;
   //pointer to script instanced logic node
   uScriptAct_AddForce logic_uScriptAct_AddForce_uScriptAct_AddForce_8 = new uScriptAct_AddForce( );
   UnityEngine.GameObject logic_uScriptAct_AddForce_Target_8 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_AddForce_Force_8 = new Vector3( );
   System.Single logic_uScriptAct_AddForce_Scale_8 = (float) 0;
   System.Boolean logic_uScriptAct_AddForce_UseForceMode_8 = (bool) false;
   UnityEngine.ForceMode logic_uScriptAct_AddForce_ForceModeType_8 = UnityEngine.ForceMode.Force;
   bool logic_uScriptAct_AddForce_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_13 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_13 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_13 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_13 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_13 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_17 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_17 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_22 = UnityEngine.KeyCode.None;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_22 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_22 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_22 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRigidbodyVelocity logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_28 = new uScriptAct_SetRigidbodyVelocity( );
   UnityEngine.GameObject[] logic_uScriptAct_SetRigidbodyVelocity_Target_28 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetRigidbodyVelocity_Velocity_28 = new Vector3( );
   bool logic_uScriptAct_SetRigidbodyVelocity_Out_28 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_29 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_29 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_29 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_29;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_32 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_32 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_32 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_32;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_32 = true;
   //pointer to script instanced logic node
   uScriptAct_AddForce logic_uScriptAct_AddForce_uScriptAct_AddForce_34 = new uScriptAct_AddForce( );
   UnityEngine.GameObject logic_uScriptAct_AddForce_Target_34 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_AddForce_Force_34 = new Vector3( );
   System.Single logic_uScriptAct_AddForce_Scale_34 = (float) 0;
   System.Boolean logic_uScriptAct_AddForce_UseForceMode_34 = (bool) false;
   UnityEngine.ForceMode logic_uScriptAct_AddForce_ForceModeType_34 = UnityEngine.ForceMode.Force;
   bool logic_uScriptAct_AddForce_Out_34 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_36 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_36 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_36 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_36;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_36 = true;
   //pointer to script instanced logic node
   uScriptAct_AddForce logic_uScriptAct_AddForce_uScriptAct_AddForce_38 = new uScriptAct_AddForce( );
   UnityEngine.GameObject logic_uScriptAct_AddForce_Target_38 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_AddForce_Force_38 = new Vector3( );
   System.Single logic_uScriptAct_AddForce_Scale_38 = (float) 0;
   System.Boolean logic_uScriptAct_AddForce_UseForceMode_38 = (bool) false;
   UnityEngine.ForceMode logic_uScriptAct_AddForce_ForceModeType_38 = UnityEngine.ForceMode.Force;
   bool logic_uScriptAct_AddForce_Out_38 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_39 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_39 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_39 = (float) 8;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_39;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_39 = true;
   //pointer to script instanced logic node
   uScriptAct_AddForce logic_uScriptAct_AddForce_uScriptAct_AddForce_40 = new uScriptAct_AddForce( );
   UnityEngine.GameObject logic_uScriptAct_AddForce_Target_40 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_AddForce_Force_40 = new Vector3( );
   System.Single logic_uScriptAct_AddForce_Scale_40 = (float) 0;
   System.Boolean logic_uScriptAct_AddForce_UseForceMode_40 = (bool) false;
   UnityEngine.ForceMode logic_uScriptAct_AddForce_ForceModeType_40 = UnityEngine.ForceMode.Force;
   bool logic_uScriptAct_AddForce_Out_40 = true;
   //pointer to script instanced logic node
   uScriptNodeIsDialogueRunning logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_44 = new uScriptNodeIsDialogueRunning( );
   bool logic_uScriptNodeIsDialogueRunning_True_44 = true;
   bool logic_uScriptNodeIsDialogueRunning_False_44 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRigidbodyVelocity logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_46 = new uScriptAct_SetRigidbodyVelocity( );
   UnityEngine.GameObject[] logic_uScriptAct_SetRigidbodyVelocity_Target_46 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetRigidbodyVelocity_Velocity_46 = new Vector3( );
   bool logic_uScriptAct_SetRigidbodyVelocity_Out_46 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_49 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_49 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_49;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_49;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_49;
   bool logic_uScriptAct_GetComponentsVector3_Out_49 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRigidbodyVelocity logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_50 = new uScriptAct_GetRigidbodyVelocity( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidbodyVelocity_Target_50 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_GetRigidbodyVelocity_Velocity_50;
   System.Single logic_uScriptAct_GetRigidbodyVelocity_Magnitude_50;
   bool logic_uScriptAct_GetRigidbodyVelocity_Out_50 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_55 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_55 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_55 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_55 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_55;
   bool logic_uScriptAct_SetComponentsVector3_Out_55 = true;
   //pointer to script instanced logic node
   uScriptAct_Raycast logic_uScriptAct_Raycast_uScriptAct_Raycast_58 = new uScriptAct_Raycast( );
   System.Object logic_uScriptAct_Raycast_Start_58 = "";
   System.Object logic_uScriptAct_Raycast_End_58 = "";
   UnityEngine.LayerMask logic_uScriptAct_Raycast_layerMask_58 = 1;
   System.Boolean logic_uScriptAct_Raycast_include_58 = (bool) true;
   System.Boolean logic_uScriptAct_Raycast_showRay_58 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_Raycast_HitObject_58;
   System.Single logic_uScriptAct_Raycast_HitDistance_58;
   UnityEngine.Vector3 logic_uScriptAct_Raycast_HitLocation_58;
   UnityEngine.Vector3 logic_uScriptAct_Raycast_HitNormal_58;
   bool logic_uScriptAct_Raycast_NotObstructed_58 = true;
   bool logic_uScriptAct_Raycast_Obstructed_58 = true;
   //pointer to script instanced logic node
   uScriptAct_AddVector3_v2 logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_62 = new uScriptAct_AddVector3_v2( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_A_62 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_B_62 = new Vector3( (float)0, (float)-1, (float)0 );
   UnityEngine.Vector3 logic_uScriptAct_AddVector3_v2_Result_62;
   bool logic_uScriptAct_AddVector3_v2_Out_62 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_65 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_65 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_65 = (float) -1;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_65;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_65;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_65 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_69 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_69 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_69 = (float) -1;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_69;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_69;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_69 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRigidbodyVelocity logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_73 = new uScriptAct_GetRigidbodyVelocity( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidbodyVelocity_Target_73 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_GetRigidbodyVelocity_Velocity_73;
   System.Single logic_uScriptAct_GetRigidbodyVelocity_Magnitude_73;
   bool logic_uScriptAct_GetRigidbodyVelocity_Out_73 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_76 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_76 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_76 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_76 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_76 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_76 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_76 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_76 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_76 = true;
   //pointer to script instanced logic node
   uScriptAct_NormalizeVector3 logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_78 = new uScriptAct_NormalizeVector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_Target_78 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_NormalizedVector_78;
   bool logic_uScriptAct_NormalizeVector3_Out_78 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyVector3WithFloat logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_81 = new uScriptAct_MultiplyVector3WithFloat( );
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_81 = new Vector3( );
   System.Single logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_81 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_MultiplyVector3WithFloat_Result_81;
   bool logic_uScriptAct_MultiplyVector3WithFloat_Out_81 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRigidbodyVelocity logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_83 = new uScriptAct_SetRigidbodyVelocity( );
   UnityEngine.GameObject[] logic_uScriptAct_SetRigidbodyVelocity_Target_83 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetRigidbodyVelocity_Velocity_83 = new Vector3( );
   bool logic_uScriptAct_SetRigidbodyVelocity_Out_83 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_85 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_85 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_85;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_85;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_85;
   bool logic_uScriptAct_GetComponentsVector3_Out_85 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_88 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_88 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_88 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_88 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_88;
   bool logic_uScriptAct_SetComponentsVector3_Out_88 = true;
   //pointer to script instanced logic node
   uScriptNodeVector3Magnitude logic_uScriptNodeVector3Magnitude_uScriptNodeVector3Magnitude_90 = new uScriptNodeVector3Magnitude( );
   UnityEngine.Vector3 logic_uScriptNodeVector3Magnitude_input_90 = new Vector3( );
   System.Single logic_uScriptNodeVector3Magnitude_Result_90;
   bool logic_uScriptNodeVector3Magnitude_Out_90 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_93 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_93 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_93;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_93;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_93;
   bool logic_uScriptAct_GetComponentsVector3_Out_93 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_96 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_96 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_96 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_96 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_96;
   bool logic_uScriptAct_SetComponentsVector3_Out_96 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_210 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_210 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_210;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_210;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_210;
   bool logic_uScriptAct_GetComponentsVector3_Out_210 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_218 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_218 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_218 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_218 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_218;
   bool logic_uScriptAct_SetComponentsVector3_Out_218 = true;
   //pointer to script instanced logic node
   uScriptAct_NormalizeVector3 logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_224 = new uScriptAct_NormalizeVector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_Target_224 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_NormalizedVector_224;
   bool logic_uScriptAct_NormalizeVector3_Out_224 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_229 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_229 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_229;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_229;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_229;
   bool logic_uScriptAct_GetComponentsVector3_Out_229 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_241 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_241 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_241 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_241 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_241;
   bool logic_uScriptAct_SetComponentsVector3_Out_241 = true;
   //pointer to script instanced logic node
   uScriptAct_NormalizeVector3 logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_248 = new uScriptAct_NormalizeVector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_Target_248 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_NormalizeVector3_NormalizedVector_248;
   bool logic_uScriptAct_NormalizeVector3_Out_248 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_72 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_209 = default(UnityEngine.GameObject);
   
   //property nodes
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_59 = new Vector3( );
   UnityEngine.Vector3 property_right_Detox_ScriptEditor_Parameter_right_212 = new Vector3( );
   UnityEngine.Vector3 property_forward_Detox_ScriptEditor_Parameter_forward_230 = new Vector3( );
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   UnityEngine.Vector3 property_position_Detox_ScriptEditor_Parameter_position_59_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (owner_Connection_60 != null)
      {
         component = owner_Connection_60.GetComponent<UnityEngine.Transform>();
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
      if (owner_Connection_60 != null)
      {
         component = owner_Connection_60.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.position = property_position_Detox_ScriptEditor_Parameter_position_59;
      }
   }
   
   UnityEngine.Vector3 property_right_Detox_ScriptEditor_Parameter_right_212_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (camera_gameobject != null)
      {
         component = camera_gameobject.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.right;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_right_Detox_ScriptEditor_Parameter_right_212_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (camera_gameobject != null)
      {
         component = camera_gameobject.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.right = property_right_Detox_ScriptEditor_Parameter_right_212;
      }
   }
   
   UnityEngine.Vector3 property_forward_Detox_ScriptEditor_Parameter_forward_230_Get_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (camera_gameobject != null)
      {
         component = camera_gameobject.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         return component.forward;
      }
      else
      {
         return new Vector3( );
      }
   }
   
   void property_forward_Detox_ScriptEditor_Parameter_forward_230_Set_Refresh( )
   {
      UnityEngine.Transform component = null;
      if (camera_gameobject != null)
      {
         component = camera_gameobject.GetComponent<UnityEngine.Transform>();
      }
      if ( null != component )
      {
         component.forward = property_forward_Detox_ScriptEditor_Parameter_forward_230;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( camera_gameobject_previous != camera_gameobject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         camera_gameobject_previous = camera_gameobject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
         if ( null != owner_Connection_3 )
         {
            {
               uScript_Input component = owner_Connection_3.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_3.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_0;
               }
            }
         }
      }
      if ( null == owner_Connection_5 || false == m_RegisteredForEvents )
      {
         owner_Connection_5 = parentGameObject;
      }
      if ( null == owner_Connection_6 || false == m_RegisteredForEvents )
      {
         owner_Connection_6 = parentGameObject;
         if ( null != owner_Connection_6 )
         {
            {
               uScript_Input component = owner_Connection_6.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_6.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_9;
               }
            }
         }
      }
      if ( null == owner_Connection_15 || false == m_RegisteredForEvents )
      {
         owner_Connection_15 = parentGameObject;
         if ( null != owner_Connection_15 )
         {
            {
               uScript_Input component = owner_Connection_15.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_15.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_14;
               }
            }
         }
      }
      if ( null == owner_Connection_18 || false == m_RegisteredForEvents )
      {
         owner_Connection_18 = parentGameObject;
         if ( null != owner_Connection_18 )
         {
            {
               uScript_Input component = owner_Connection_18.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_18.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_19;
               }
            }
         }
      }
      if ( null == owner_Connection_24 || false == m_RegisteredForEvents )
      {
         owner_Connection_24 = parentGameObject;
      }
      if ( null == owner_Connection_27 || false == m_RegisteredForEvents )
      {
         owner_Connection_27 = parentGameObject;
         if ( null != owner_Connection_27 )
         {
            {
               uScript_Input component = owner_Connection_27.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_27.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_25;
               }
            }
         }
      }
      if ( null == owner_Connection_33 || false == m_RegisteredForEvents )
      {
         owner_Connection_33 = parentGameObject;
      }
      if ( null == owner_Connection_37 || false == m_RegisteredForEvents )
      {
         owner_Connection_37 = parentGameObject;
      }
      if ( null == owner_Connection_42 || false == m_RegisteredForEvents )
      {
         owner_Connection_42 = parentGameObject;
      }
      if ( null == owner_Connection_45 || false == m_RegisteredForEvents )
      {
         owner_Connection_45 = parentGameObject;
         if ( null != owner_Connection_45 )
         {
            {
               uScript_Update component = owner_Connection_45.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_45.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_43;
                  component.OnLateUpdate += Instance_OnLateUpdate_43;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_43;
               }
            }
         }
      }
      if ( null == owner_Connection_47 || false == m_RegisteredForEvents )
      {
         owner_Connection_47 = parentGameObject;
      }
      if ( null == owner_Connection_51 || false == m_RegisteredForEvents )
      {
         owner_Connection_51 = parentGameObject;
      }
      if ( null == owner_Connection_60 || false == m_RegisteredForEvents )
      {
         owner_Connection_60 = parentGameObject;
      }
      if ( null == owner_Connection_74 || false == m_RegisteredForEvents )
      {
         owner_Connection_74 = parentGameObject;
      }
      if ( null == owner_Connection_84 || false == m_RegisteredForEvents )
      {
         owner_Connection_84 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( camera_gameobject_previous != camera_gameobject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         camera_gameobject_previous = camera_gameobject;
         
         //setup new listeners
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_3 )
         {
            {
               uScript_Input component = owner_Connection_3.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_3.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_0;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_6 )
         {
            {
               uScript_Input component = owner_Connection_6.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_6.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_9;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_15 )
         {
            {
               uScript_Input component = owner_Connection_15.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_15.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_14;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_18 )
         {
            {
               uScript_Input component = owner_Connection_18.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_18.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_19;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_27 )
         {
            {
               uScript_Input component = owner_Connection_27.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = owner_Connection_27.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_25;
               }
            }
         }
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_45 )
         {
            {
               uScript_Update component = owner_Connection_45.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_45.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_43;
                  component.OnLateUpdate += Instance_OnLateUpdate_43;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_43;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_72 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_72 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_72 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_72.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_72.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_72;
                  component.OnLateUpdate += Instance_OnLateUpdate_72;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_72;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_209 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_209 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_209 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_209.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_209.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_209;
                  component.OnLateUpdate += Instance_OnLateUpdate_209;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_209;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_3 )
      {
         {
            uScript_Input component = owner_Connection_3.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_0;
            }
         }
      }
      if ( null != owner_Connection_6 )
      {
         {
            uScript_Input component = owner_Connection_6.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_9;
            }
         }
      }
      if ( null != owner_Connection_15 )
      {
         {
            uScript_Input component = owner_Connection_15.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_14;
            }
         }
      }
      if ( null != owner_Connection_18 )
      {
         {
            uScript_Input component = owner_Connection_18.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_19;
            }
         }
      }
      if ( null != owner_Connection_27 )
      {
         {
            uScript_Input component = owner_Connection_27.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_25;
            }
         }
      }
      if ( null != owner_Connection_45 )
      {
         {
            uScript_Update component = owner_Connection_45.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_43;
               component.OnLateUpdate -= Instance_OnLateUpdate_43;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_43;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_72 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_72.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_72;
               component.OnLateUpdate -= Instance_OnLateUpdate_72;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_72;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_209 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_209.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_209;
               component.OnLateUpdate -= Instance_OnLateUpdate_209;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_209;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4.SetParent(g);
      logic_uScriptAct_AddForce_uScriptAct_AddForce_8.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_13.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22.SetParent(g);
      logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_28.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_29.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_32.SetParent(g);
      logic_uScriptAct_AddForce_uScriptAct_AddForce_34.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_36.SetParent(g);
      logic_uScriptAct_AddForce_uScriptAct_AddForce_38.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_39.SetParent(g);
      logic_uScriptAct_AddForce_uScriptAct_AddForce_40.SetParent(g);
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_44.SetParent(g);
      logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_46.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_49.SetParent(g);
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_50.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_55.SetParent(g);
      logic_uScriptAct_Raycast_uScriptAct_Raycast_58.SetParent(g);
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_62.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_65.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_69.SetParent(g);
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_73.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_76.SetParent(g);
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_78.SetParent(g);
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_81.SetParent(g);
      logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_83.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_85.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_88.SetParent(g);
      logic_uScriptNodeVector3Magnitude_uScriptNodeVector3Magnitude_90.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_93.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_96.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_210.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_218.SetParent(g);
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_224.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_229.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_241.SetParent(g);
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_248.SetParent(g);
      owner_Connection_3 = parentGameObject;
      owner_Connection_5 = parentGameObject;
      owner_Connection_6 = parentGameObject;
      owner_Connection_15 = parentGameObject;
      owner_Connection_18 = parentGameObject;
      owner_Connection_24 = parentGameObject;
      owner_Connection_27 = parentGameObject;
      owner_Connection_33 = parentGameObject;
      owner_Connection_37 = parentGameObject;
      owner_Connection_42 = parentGameObject;
      owner_Connection_45 = parentGameObject;
      owner_Connection_47 = parentGameObject;
      owner_Connection_51 = parentGameObject;
      owner_Connection_60 = parentGameObject;
      owner_Connection_74 = parentGameObject;
      owner_Connection_84 = parentGameObject;
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
   
   void Instance_KeyEvent_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_0( );
   }
   
   void Instance_KeyEvent_9(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_9( );
   }
   
   void Instance_KeyEvent_14(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_14( );
   }
   
   void Instance_KeyEvent_19(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_19( );
   }
   
   void Instance_KeyEvent_25(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_25( );
   }
   
   void Instance_OnUpdate_43(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_43( );
   }
   
   void Instance_OnLateUpdate_43(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_43( );
   }
   
   void Instance_OnFixedUpdate_43(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_43( );
   }
   
   void Instance_OnUpdate_72(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_72( );
   }
   
   void Instance_OnLateUpdate_72(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_72( );
   }
   
   void Instance_OnFixedUpdate_72(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_72( );
   }
   
   void Instance_OnUpdate_209(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_209( );
   }
   
   void Instance_OnLateUpdate_209(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_209( );
   }
   
   void Instance_OnFixedUpdate_209(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_209( );
   }
   
   void Relay_KeyEvent_0()
   {
      Relay_In_1();
   }
   
   void Relay_In_1()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_1 = local_2_UnityEngine_KeyCode;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.In(logic_uScriptAct_OnInputEventFilter_KeyCode_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.KeyHeld;
      
      if ( test_0 == true )
      {
         Relay_In_36();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_4 = local_7_UnityEngine_KeyCode;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4.In(logic_uScriptAct_OnInputEventFilter_KeyCode_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4.KeyHeld;
      
      if ( test_0 == true )
      {
         Relay_In_65();
      }
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptAct_AddForce_Target_8 = owner_Connection_5;
            
         }
         {
            logic_uScriptAct_AddForce_Force_8 = local_30_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddForce_uScriptAct_AddForce_8.In(logic_uScriptAct_AddForce_Target_8, logic_uScriptAct_AddForce_Force_8, logic_uScriptAct_AddForce_Scale_8, logic_uScriptAct_AddForce_UseForceMode_8, logic_uScriptAct_AddForce_ForceModeType_8);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_KeyEvent_9()
   {
      Relay_In_4();
   }
   
   void Relay_In_13()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_13 = local_12_UnityEngine_KeyCode;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_13.In(logic_uScriptAct_OnInputEventFilter_KeyCode_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_13.KeyHeld;
      
      if ( test_0 == true )
      {
         Relay_In_39();
      }
   }
   
   void Relay_KeyEvent_14()
   {
      Relay_In_13();
   }
   
   void Relay_In_17()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_17 = local_21_UnityEngine_KeyCode;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.In(logic_uScriptAct_OnInputEventFilter_KeyCode_17);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.KeyHeld;
      
      if ( test_0 == true )
      {
         Relay_In_69();
      }
   }
   
   void Relay_KeyEvent_19()
   {
      Relay_In_17();
   }
   
   void Relay_In_22()
   {
      {
         {
            logic_uScriptAct_OnInputEventFilter_KeyCode_22 = local_26_UnityEngine_KeyCode;
            
         }
      }
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22.In(logic_uScriptAct_OnInputEventFilter_KeyCode_22);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_22.KeyDown;
      
      if ( test_0 == true )
      {
         Relay_In_62();
      }
   }
   
   void Relay_KeyEvent_25()
   {
      Relay_In_22();
   }
   
   void Relay_In_28()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetRigidbodyVelocity_Target_28.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetRigidbodyVelocity_Target_28, index + 1);
            }
            logic_uScriptAct_SetRigidbodyVelocity_Target_28[ index++ ] = owner_Connection_24;
            
         }
         {
            logic_uScriptAct_SetRigidbodyVelocity_Velocity_28 = local_57_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_28.In(logic_uScriptAct_SetRigidbodyVelocity_Target_28, logic_uScriptAct_SetRigidbodyVelocity_Velocity_28);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_29()
   {
      {
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_29 = local_camera_right_UnityEngine_Vector3;
            
         }
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_29 = local_66_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_29.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_29, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_29, out logic_uScriptAct_MultiplyVector3WithFloat_Result_29);
      local_30_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_29;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_29.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_In_32()
   {
      {
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_32 = local_camera_forward_UnityEngine_Vector3;
            
         }
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_32 = local_68_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_32.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_32, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_32, out logic_uScriptAct_MultiplyVector3WithFloat_Result_32);
      local_31_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_32;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_32.Out;
      
      if ( test_0 == true )
      {
         Relay_In_34();
      }
   }
   
   void Relay_In_34()
   {
      {
         {
            logic_uScriptAct_AddForce_Target_34 = owner_Connection_33;
            
         }
         {
            logic_uScriptAct_AddForce_Force_34 = local_31_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddForce_uScriptAct_AddForce_34.In(logic_uScriptAct_AddForce_Target_34, logic_uScriptAct_AddForce_Force_34, logic_uScriptAct_AddForce_Scale_34, logic_uScriptAct_AddForce_UseForceMode_34, logic_uScriptAct_AddForce_ForceModeType_34);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_36()
   {
      {
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_36 = local_camera_right_UnityEngine_Vector3;
            
         }
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_36 = speed;
            
         }
         {
         }
      }
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_36.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_36, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_36, out logic_uScriptAct_MultiplyVector3WithFloat_Result_36);
      local_35_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_36;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_36.Out;
      
      if ( test_0 == true )
      {
         Relay_In_38();
      }
   }
   
   void Relay_In_38()
   {
      {
         {
            logic_uScriptAct_AddForce_Target_38 = owner_Connection_37;
            
         }
         {
            logic_uScriptAct_AddForce_Force_38 = local_35_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddForce_uScriptAct_AddForce_38.In(logic_uScriptAct_AddForce_Target_38, logic_uScriptAct_AddForce_Force_38, logic_uScriptAct_AddForce_Scale_38, logic_uScriptAct_AddForce_UseForceMode_38, logic_uScriptAct_AddForce_ForceModeType_38);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_39()
   {
      {
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_39 = local_camera_forward_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_39.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_39, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_39, out logic_uScriptAct_MultiplyVector3WithFloat_Result_39);
      local_41_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_39;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_39.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_In_40()
   {
      {
         {
            logic_uScriptAct_AddForce_Target_40 = owner_Connection_42;
            
         }
         {
            logic_uScriptAct_AddForce_Force_40 = local_41_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddForce_uScriptAct_AddForce_40.In(logic_uScriptAct_AddForce_Target_40, logic_uScriptAct_AddForce_Force_40, logic_uScriptAct_AddForce_Scale_40, logic_uScriptAct_AddForce_UseForceMode_40, logic_uScriptAct_AddForce_ForceModeType_40);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnUpdate_43()
   {
   }
   
   void Relay_OnLateUpdate_43()
   {
   }
   
   void Relay_OnFixedUpdate_43()
   {
      Relay_In_44();
   }
   
   void Relay_In_44()
   {
      {
      }
      logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_44.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeIsDialogueRunning_uScriptNodeIsDialogueRunning_44.True;
      
      if ( test_0 == true )
      {
         Relay_In_46();
      }
   }
   
   void Relay_In_46()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetRigidbodyVelocity_Target_46.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetRigidbodyVelocity_Target_46, index + 1);
            }
            logic_uScriptAct_SetRigidbodyVelocity_Target_46[ index++ ] = owner_Connection_47;
            
         }
         {
            logic_uScriptAct_SetRigidbodyVelocity_Velocity_46 = local_48_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_46.In(logic_uScriptAct_SetRigidbodyVelocity_Target_46, logic_uScriptAct_SetRigidbodyVelocity_Velocity_46);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_49()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_49 = local_current_velocity_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_49.In(logic_uScriptAct_GetComponentsVector3_InputVector3_49, out logic_uScriptAct_GetComponentsVector3_X_49, out logic_uScriptAct_GetComponentsVector3_Y_49, out logic_uScriptAct_GetComponentsVector3_Z_49);
      local_53_System_Single = logic_uScriptAct_GetComponentsVector3_X_49;
      local_54_System_Single = logic_uScriptAct_GetComponentsVector3_Z_49;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_49.Out;
      
      if ( test_0 == true )
      {
         Relay_In_55();
      }
   }
   
   void Relay_In_50()
   {
      {
         {
            logic_uScriptAct_GetRigidbodyVelocity_Target_50 = owner_Connection_51;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_50.In(logic_uScriptAct_GetRigidbodyVelocity_Target_50, out logic_uScriptAct_GetRigidbodyVelocity_Velocity_50, out logic_uScriptAct_GetRigidbodyVelocity_Magnitude_50);
      local_current_velocity_UnityEngine_Vector3 = logic_uScriptAct_GetRigidbodyVelocity_Velocity_50;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_50.Out;
      
      if ( test_0 == true )
      {
         Relay_In_49();
      }
   }
   
   void Relay_In_55()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector3_X_55 = local_53_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector3_Y_55 = jump_power;
            
         }
         {
            logic_uScriptAct_SetComponentsVector3_Z_55 = local_54_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_55.In(logic_uScriptAct_SetComponentsVector3_X_55, logic_uScriptAct_SetComponentsVector3_Y_55, logic_uScriptAct_SetComponentsVector3_Z_55, out logic_uScriptAct_SetComponentsVector3_OutputVector3_55);
      local_57_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_55;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_55.Out;
      
      if ( test_0 == true )
      {
         Relay_In_28();
      }
   }
   
   void Relay_In_58()
   {
      {
         {
            logic_uScriptAct_Raycast_Start_58 = property_position_Detox_ScriptEditor_Parameter_position_59_Get_Refresh( );
         }
         {
            logic_uScriptAct_Raycast_End_58 = local_point_below_player_UnityEngine_Vector3;
            
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
      logic_uScriptAct_Raycast_uScriptAct_Raycast_58.In(logic_uScriptAct_Raycast_Start_58, logic_uScriptAct_Raycast_End_58, logic_uScriptAct_Raycast_layerMask_58, logic_uScriptAct_Raycast_include_58, logic_uScriptAct_Raycast_showRay_58, out logic_uScriptAct_Raycast_HitObject_58, out logic_uScriptAct_Raycast_HitDistance_58, out logic_uScriptAct_Raycast_HitLocation_58, out logic_uScriptAct_Raycast_HitNormal_58);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Raycast_uScriptAct_Raycast_58.Obstructed;
      
      if ( test_0 == true )
      {
         Relay_In_50();
      }
   }
   
   void Relay_In_62()
   {
      {
         {
            logic_uScriptAct_AddVector3_v2_A_62 = property_position_Detox_ScriptEditor_Parameter_position_59_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_62.In(logic_uScriptAct_AddVector3_v2_A_62, logic_uScriptAct_AddVector3_v2_B_62, out logic_uScriptAct_AddVector3_v2_Result_62);
      local_point_below_player_UnityEngine_Vector3 = logic_uScriptAct_AddVector3_v2_Result_62;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddVector3_v2_uScriptAct_AddVector3_v2_62.Out;
      
      if ( test_0 == true )
      {
         Relay_In_58();
      }
   }
   
   void Relay_In_65()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_65 = speed;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_65.In(logic_uScriptAct_MultiplyFloat_v2_A_65, logic_uScriptAct_MultiplyFloat_v2_B_65, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_65, out logic_uScriptAct_MultiplyFloat_v2_IntResult_65);
      local_66_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_65;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_65.Out;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
   }
   
   void Relay_In_69()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_69 = speed;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_69.In(logic_uScriptAct_MultiplyFloat_v2_A_69, logic_uScriptAct_MultiplyFloat_v2_B_69, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_69, out logic_uScriptAct_MultiplyFloat_v2_IntResult_69);
      local_68_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_69;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_69.Out;
      
      if ( test_0 == true )
      {
         Relay_In_32();
      }
   }
   
   void Relay_OnUpdate_72()
   {
   }
   
   void Relay_OnLateUpdate_72()
   {
      Relay_In_73();
   }
   
   void Relay_OnFixedUpdate_72()
   {
   }
   
   void Relay_In_73()
   {
      {
         {
            logic_uScriptAct_GetRigidbodyVelocity_Target_73 = owner_Connection_74;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_73.In(logic_uScriptAct_GetRigidbodyVelocity_Target_73, out logic_uScriptAct_GetRigidbodyVelocity_Velocity_73, out logic_uScriptAct_GetRigidbodyVelocity_Magnitude_73);
      local_current_velocity_UnityEngine_Vector3 = logic_uScriptAct_GetRigidbodyVelocity_Velocity_73;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRigidbodyVelocity_uScriptAct_GetRigidbodyVelocity_73.Out;
      
      if ( test_0 == true )
      {
         Relay_In_85();
      }
   }
   
   void Relay_In_76()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_76 = local_91_System_Single;
            
         }
         {
            logic_uScriptCon_CompareFloat_B_76 = max_velocity;
            
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_76.In(logic_uScriptCon_CompareFloat_A_76, logic_uScriptCon_CompareFloat_B_76);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_76.GreaterThan;
      
      if ( test_0 == true )
      {
         Relay_In_78();
      }
   }
   
   void Relay_In_78()
   {
      {
         {
            logic_uScriptAct_NormalizeVector3_Target_78 = local_xz_velocity_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_78.In(logic_uScriptAct_NormalizeVector3_Target_78, out logic_uScriptAct_NormalizeVector3_NormalizedVector_78);
      local_79_UnityEngine_Vector3 = logic_uScriptAct_NormalizeVector3_NormalizedVector_78;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_78.Out;
      
      if ( test_0 == true )
      {
         Relay_In_81();
      }
   }
   
   void Relay_In_81()
   {
      {
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_81 = local_79_UnityEngine_Vector3;
            
         }
         {
            logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_81 = max_velocity;
            
         }
         {
         }
      }
      logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_81.In(logic_uScriptAct_MultiplyVector3WithFloat_targetVector3_81, logic_uScriptAct_MultiplyVector3WithFloat_targetFloat_81, out logic_uScriptAct_MultiplyVector3WithFloat_Result_81);
      local_final_xz_velocity_UnityEngine_Vector3 = logic_uScriptAct_MultiplyVector3WithFloat_Result_81;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyVector3WithFloat_uScriptAct_MultiplyVector3WithFloat_81.Out;
      
      if ( test_0 == true )
      {
         Relay_In_93();
      }
   }
   
   void Relay_In_83()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetRigidbodyVelocity_Target_83.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetRigidbodyVelocity_Target_83, index + 1);
            }
            logic_uScriptAct_SetRigidbodyVelocity_Target_83[ index++ ] = owner_Connection_84;
            
         }
         {
            logic_uScriptAct_SetRigidbodyVelocity_Velocity_83 = local_final_vel_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetRigidbodyVelocity_uScriptAct_SetRigidbodyVelocity_83.In(logic_uScriptAct_SetRigidbodyVelocity_Target_83, logic_uScriptAct_SetRigidbodyVelocity_Velocity_83);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_85()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_85 = local_current_velocity_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_85.In(logic_uScriptAct_GetComponentsVector3_InputVector3_85, out logic_uScriptAct_GetComponentsVector3_X_85, out logic_uScriptAct_GetComponentsVector3_Y_85, out logic_uScriptAct_GetComponentsVector3_Z_85);
      local_86_System_Single = logic_uScriptAct_GetComponentsVector3_X_85;
      local_current_y_vel_System_Single = logic_uScriptAct_GetComponentsVector3_Y_85;
      local_87_System_Single = logic_uScriptAct_GetComponentsVector3_Z_85;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_85.Out;
      
      if ( test_0 == true )
      {
         Relay_In_88();
      }
   }
   
   void Relay_In_88()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector3_X_88 = local_86_System_Single;
            
         }
         {
         }
         {
            logic_uScriptAct_SetComponentsVector3_Z_88 = local_87_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_88.In(logic_uScriptAct_SetComponentsVector3_X_88, logic_uScriptAct_SetComponentsVector3_Y_88, logic_uScriptAct_SetComponentsVector3_Z_88, out logic_uScriptAct_SetComponentsVector3_OutputVector3_88);
      local_xz_velocity_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_88;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_88.Out;
      
      if ( test_0 == true )
      {
         Relay_In_90();
      }
   }
   
   void Relay_In_90()
   {
      {
         {
            logic_uScriptNodeVector3Magnitude_input_90 = local_xz_velocity_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptNodeVector3Magnitude_uScriptNodeVector3Magnitude_90.In(logic_uScriptNodeVector3Magnitude_input_90, out logic_uScriptNodeVector3Magnitude_Result_90);
      local_91_System_Single = logic_uScriptNodeVector3Magnitude_Result_90;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeVector3Magnitude_uScriptNodeVector3Magnitude_90.Out;
      
      if ( test_0 == true )
      {
         Relay_In_76();
      }
   }
   
   void Relay_In_93()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_93 = local_final_xz_velocity_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_93.In(logic_uScriptAct_GetComponentsVector3_InputVector3_93, out logic_uScriptAct_GetComponentsVector3_X_93, out logic_uScriptAct_GetComponentsVector3_Y_93, out logic_uScriptAct_GetComponentsVector3_Z_93);
      local_94_System_Single = logic_uScriptAct_GetComponentsVector3_X_93;
      local_95_System_Single = logic_uScriptAct_GetComponentsVector3_Z_93;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_93.Out;
      
      if ( test_0 == true )
      {
         Relay_In_96();
      }
   }
   
   void Relay_In_96()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector3_X_96 = local_94_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector3_Y_96 = local_current_y_vel_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector3_Z_96 = local_95_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_96.In(logic_uScriptAct_SetComponentsVector3_X_96, logic_uScriptAct_SetComponentsVector3_Y_96, logic_uScriptAct_SetComponentsVector3_Z_96, out logic_uScriptAct_SetComponentsVector3_OutputVector3_96);
      local_final_vel_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_96;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_96.Out;
      
      if ( test_0 == true )
      {
         Relay_In_83();
      }
   }
   
   void Relay_OnUpdate_209()
   {
      Relay_In_210();
   }
   
   void Relay_OnLateUpdate_209()
   {
   }
   
   void Relay_OnFixedUpdate_209()
   {
   }
   
   void Relay_In_210()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_210 = property_right_Detox_ScriptEditor_Parameter_right_212_Get_Refresh( );
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_210.In(logic_uScriptAct_GetComponentsVector3_InputVector3_210, out logic_uScriptAct_GetComponentsVector3_X_210, out logic_uScriptAct_GetComponentsVector3_Y_210, out logic_uScriptAct_GetComponentsVector3_Z_210);
      local_214_System_Single = logic_uScriptAct_GetComponentsVector3_X_210;
      local_216_System_Single = logic_uScriptAct_GetComponentsVector3_Z_210;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_210.Out;
      
      if ( test_0 == true )
      {
         Relay_In_218();
      }
   }
   
   void Relay_In_218()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector3_X_218 = local_214_System_Single;
            
         }
         {
         }
         {
            logic_uScriptAct_SetComponentsVector3_Z_218 = local_216_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_218.In(logic_uScriptAct_SetComponentsVector3_X_218, logic_uScriptAct_SetComponentsVector3_Y_218, logic_uScriptAct_SetComponentsVector3_Z_218, out logic_uScriptAct_SetComponentsVector3_OutputVector3_218);
      local_camera_right_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_218;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_218.Out;
      
      if ( test_0 == true )
      {
         Relay_In_224();
      }
   }
   
   void Relay_In_224()
   {
      {
         {
            logic_uScriptAct_NormalizeVector3_Target_224 = local_camera_right_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_224.In(logic_uScriptAct_NormalizeVector3_Target_224, out logic_uScriptAct_NormalizeVector3_NormalizedVector_224);
      local_camera_right_UnityEngine_Vector3 = logic_uScriptAct_NormalizeVector3_NormalizedVector_224;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_224.Out;
      
      if ( test_0 == true )
      {
         Relay_In_229();
      }
   }
   
   void Relay_In_229()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_229 = property_forward_Detox_ScriptEditor_Parameter_forward_230_Get_Refresh( );
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_229.In(logic_uScriptAct_GetComponentsVector3_InputVector3_229, out logic_uScriptAct_GetComponentsVector3_X_229, out logic_uScriptAct_GetComponentsVector3_Y_229, out logic_uScriptAct_GetComponentsVector3_Z_229);
      local_237_System_Single = logic_uScriptAct_GetComponentsVector3_X_229;
      local_239_System_Single = logic_uScriptAct_GetComponentsVector3_Z_229;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_229.Out;
      
      if ( test_0 == true )
      {
         Relay_In_241();
      }
   }
   
   void Relay_In_241()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector3_X_241 = local_237_System_Single;
            
         }
         {
         }
         {
            logic_uScriptAct_SetComponentsVector3_Z_241 = local_239_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_241.In(logic_uScriptAct_SetComponentsVector3_X_241, logic_uScriptAct_SetComponentsVector3_Y_241, logic_uScriptAct_SetComponentsVector3_Z_241, out logic_uScriptAct_SetComponentsVector3_OutputVector3_241);
      local_camera_forward_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_241;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_241.Out;
      
      if ( test_0 == true )
      {
         Relay_In_248();
      }
   }
   
   void Relay_In_248()
   {
      {
         {
            logic_uScriptAct_NormalizeVector3_Target_248 = local_camera_forward_UnityEngine_Vector3;
            
         }
         {
         }
      }
      logic_uScriptAct_NormalizeVector3_uScriptAct_NormalizeVector3_248.In(logic_uScriptAct_NormalizeVector3_Target_248, out logic_uScriptAct_NormalizeVector3_NormalizedVector_248);
      local_camera_forward_UnityEngine_Vector3 = logic_uScriptAct_NormalizeVector3_NormalizedVector_248;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
