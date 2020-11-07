//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class can_collect : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.String local_12_System_String = "";
   System.String local_14_System_String = "Score : ";
   System.String local_15_System_String = "";
   System.String local_17_System_String = " / ";
   System.String local_18_System_String = "";
   System.String local_20_System_String = "";
   System.String local_23_System_String = "collectible";
   System.String local_53_System_String = "";
   System.Int32 local_score_System_Int32 = (int) 0;
   UnityEngine.GameObject local_triggering_gameobject_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_triggering_gameobject_UnityEngine_GameObject_previous = null;
   public UnityEngine.GameObject text_mesh = default(UnityEngine.GameObject);
   UnityEngine.GameObject text_mesh_previous = null;
   public System.Int32 total_possible_points = (int) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_3 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_2 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_2 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_2 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_2 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_2 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_2 = false;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_6 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_6 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_6 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_6 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_6 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_6;
   bool logic_uScriptAct_SetString_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_8 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_B_8 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_8;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_8;
   bool logic_uScriptAct_AddInt_v2_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_IntToString logic_uScriptAct_IntToString_uScriptAct_IntToString_11 = new uScriptAct_IntToString( );
   System.Int32 logic_uScriptAct_IntToString_Target_11 = (int) 0;
   uScriptAct_IntToString.FormatType logic_uScriptAct_IntToString_StandardFormat_11 = uScriptAct_IntToString.FormatType.General;
   System.String logic_uScriptAct_IntToString_CustomFormat_11 = "";
   System.String logic_uScriptAct_IntToString_CustomCulture_11 = "";
   System.String logic_uScriptAct_IntToString_Result_11;
   bool logic_uScriptAct_IntToString_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_Concatenate logic_uScriptAct_Concatenate_uScriptAct_Concatenate_13 = new uScriptAct_Concatenate( );
   System.Object[] logic_uScriptAct_Concatenate_A_13 = new System.Object[] {};
   System.Object[] logic_uScriptAct_Concatenate_B_13 = new System.Object[] {};
   System.String logic_uScriptAct_Concatenate_Separator_13 = "";
   System.String logic_uScriptAct_Concatenate_Result_13;
   bool logic_uScriptAct_Concatenate_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_Concatenate logic_uScriptAct_Concatenate_uScriptAct_Concatenate_16 = new uScriptAct_Concatenate( );
   System.Object[] logic_uScriptAct_Concatenate_A_16 = new System.Object[] {};
   System.Object[] logic_uScriptAct_Concatenate_B_16 = new System.Object[] {};
   System.String logic_uScriptAct_Concatenate_Separator_16 = "";
   System.String logic_uScriptAct_Concatenate_Result_16;
   bool logic_uScriptAct_Concatenate_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_Concatenate logic_uScriptAct_Concatenate_uScriptAct_Concatenate_19 = new uScriptAct_Concatenate( );
   System.Object[] logic_uScriptAct_Concatenate_A_19 = new System.Object[] {};
   System.Object[] logic_uScriptAct_Concatenate_B_19 = new System.Object[] {};
   System.String logic_uScriptAct_Concatenate_Separator_19 = "";
   System.String logic_uScriptAct_Concatenate_Result_19;
   bool logic_uScriptAct_Concatenate_Out_19 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_22 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_22 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_22 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_22 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_22 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_22 = true;
   //pointer to script instanced logic node
   uScriptAct_IntToString logic_uScriptAct_IntToString_uScriptAct_IntToString_51 = new uScriptAct_IntToString( );
   System.Int32 logic_uScriptAct_IntToString_Target_51 = (int) 0;
   uScriptAct_IntToString.FormatType logic_uScriptAct_IntToString_StandardFormat_51 = uScriptAct_IntToString.FormatType.General;
   System.String logic_uScriptAct_IntToString_CustomFormat_51 = "";
   System.String logic_uScriptAct_IntToString_CustomCulture_51 = "";
   System.String logic_uScriptAct_IntToString_Result_51;
   bool logic_uScriptAct_IntToString_Out_51 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_58 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_58 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_58 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_58 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_58 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_58 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_58 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_58 = true;
   bool logic_uScriptCon_CompareInt_LessThan_58 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_65 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_65 = "You Win!";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_65 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_65 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_65 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_65;
   bool logic_uScriptAct_SetString_Out_65 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_5 = default(UnityEngine.GameObject);
   
   //property nodes
   System.String property_text_Detox_ScriptEditor_Parameter_text_4 = "";
   System.String property_text_Detox_ScriptEditor_Parameter_text_66 = "";
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.String property_text_Detox_ScriptEditor_Parameter_text_4_Get_Refresh( )
   {
      UnityEngine.TextMesh component = null;
      if (text_mesh != null)
      {
         component = text_mesh.GetComponent<UnityEngine.TextMesh>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_4_Set_Refresh( )
   {
      UnityEngine.TextMesh component = null;
      if (text_mesh != null)
      {
         component = text_mesh.GetComponent<UnityEngine.TextMesh>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_4;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_66_Get_Refresh( )
   {
      UnityEngine.TextMesh component = null;
      if (text_mesh != null)
      {
         component = text_mesh.GetComponent<UnityEngine.TextMesh>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_66_Set_Refresh( )
   {
      UnityEngine.TextMesh component = null;
      if (text_mesh != null)
      {
         component = text_mesh.GetComponent<UnityEngine.TextMesh>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_66;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( text_mesh_previous != text_mesh || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         text_mesh_previous = text_mesh;
         
         //setup new listeners
      }
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
         if ( null != owner_Connection_3 )
         {
            {
               uScript_Trigger component = owner_Connection_3.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_3.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( text_mesh_previous != text_mesh || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         text_mesh_previous = text_mesh;
         
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
               uScript_Trigger component = owner_Connection_3.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_3.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_5 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_5 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_5 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_5.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_5;
                  component.OnLateUpdate += Instance_OnLateUpdate_5;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_5;
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
            uScript_Trigger component = owner_Connection_3.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_5 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_5;
               component.OnLateUpdate -= Instance_OnLateUpdate_5;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_5;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Destroy_uScriptAct_Destroy_2.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_6.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8.SetParent(g);
      logic_uScriptAct_IntToString_uScriptAct_IntToString_11.SetParent(g);
      logic_uScriptAct_Concatenate_uScriptAct_Concatenate_13.SetParent(g);
      logic_uScriptAct_Concatenate_uScriptAct_Concatenate_16.SetParent(g);
      logic_uScriptAct_Concatenate_uScriptAct_Concatenate_19.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_22.SetParent(g);
      logic_uScriptAct_IntToString_uScriptAct_IntToString_51.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_58.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_65.SetParent(g);
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
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      if (true == logic_uScriptAct_Destroy_WaitOneTick_2)
      {
         Relay_WaitOneTick_2();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnEnterTrigger_0(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_0( );
   }
   
   void Instance_OnExitTrigger_0(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_0( );
   }
   
   void Instance_WhileInsideTrigger_0(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_0( );
   }
   
   void Instance_OnUpdate_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_5( );
   }
   
   void Instance_OnLateUpdate_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_5( );
   }
   
   void Instance_OnFixedUpdate_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_5( );
   }
   
   void Relay_OnEnterTrigger_0()
   {
      local_triggering_gameobject_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_22();
   }
   
   void Relay_OnExitTrigger_0()
   {
      local_triggering_gameobject_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_0()
   {
      local_triggering_gameobject_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_In_2()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Destroy_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Destroy_Target_2, index + 1);
            }
            logic_uScriptAct_Destroy_Target_2[ index++ ] = local_triggering_gameobject_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_Destroy_uScriptAct_Destroy_2.In(logic_uScriptAct_Destroy_Target_2, logic_uScriptAct_Destroy_DelayTime_2);
      logic_uScriptAct_Destroy_WaitOneTick_2 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Destroy_uScriptAct_Destroy_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_WaitOneTick_2( )
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Destroy_Target_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Destroy_Target_2, index + 1);
            }
            logic_uScriptAct_Destroy_Target_2[ index++ ] = local_triggering_gameobject_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_Destroy_WaitOneTick_2 = logic_uScriptAct_Destroy_uScriptAct_Destroy_2.WaitOneTick();
      if ( true == logic_uScriptAct_Destroy_WaitOneTick_2 )
      {
         if ( logic_uScriptAct_Destroy_uScriptAct_Destroy_2.Out == true )
         {
            Relay_In_8();
         }
      }
   }
   void Relay_OnUpdate_5()
   {
      Relay_In_58();
   }
   
   void Relay_OnLateUpdate_5()
   {
   }
   
   void Relay_OnFixedUpdate_5()
   {
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptAct_SetString_Value_6 = local_20_System_String;
            
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
      logic_uScriptAct_SetString_uScriptAct_SetString_6.In(logic_uScriptAct_SetString_Value_6, logic_uScriptAct_SetString_ToUpperCase_6, logic_uScriptAct_SetString_ToLowerCase_6, logic_uScriptAct_SetString_TrimWhitespace_6, out logic_uScriptAct_SetString_Target_6);
      property_text_Detox_ScriptEditor_Parameter_text_4 = logic_uScriptAct_SetString_Target_6;
      property_text_Detox_ScriptEditor_Parameter_text_4_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptAct_AddInt_v2_A_8 = local_score_System_Int32;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_8.In(logic_uScriptAct_AddInt_v2_A_8, logic_uScriptAct_AddInt_v2_B_8, out logic_uScriptAct_AddInt_v2_IntResult_8, out logic_uScriptAct_AddInt_v2_FloatResult_8);
      local_score_System_Int32 = logic_uScriptAct_AddInt_v2_IntResult_8;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_11()
   {
      {
         {
            logic_uScriptAct_IntToString_Target_11 = local_score_System_Int32;
            
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
      logic_uScriptAct_IntToString_uScriptAct_IntToString_11.In(logic_uScriptAct_IntToString_Target_11, logic_uScriptAct_IntToString_StandardFormat_11, logic_uScriptAct_IntToString_CustomFormat_11, logic_uScriptAct_IntToString_CustomCulture_11, out logic_uScriptAct_IntToString_Result_11);
      local_12_System_String = logic_uScriptAct_IntToString_Result_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_IntToString_uScriptAct_IntToString_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_In_13()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_Concatenate_A_13.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Concatenate_A_13, index + 1);
            }
            logic_uScriptAct_Concatenate_A_13[ index++ ] = local_14_System_String;
            
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Concatenate_B_13.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Concatenate_B_13, index + 1);
            }
            logic_uScriptAct_Concatenate_B_13[ index++ ] = local_12_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Concatenate_uScriptAct_Concatenate_13.In(logic_uScriptAct_Concatenate_A_13, logic_uScriptAct_Concatenate_B_13, logic_uScriptAct_Concatenate_Separator_13, out logic_uScriptAct_Concatenate_Result_13);
      local_15_System_String = logic_uScriptAct_Concatenate_Result_13;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Concatenate_uScriptAct_Concatenate_13.Out;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_Concatenate_A_16.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Concatenate_A_16, index + 1);
            }
            logic_uScriptAct_Concatenate_A_16[ index++ ] = local_15_System_String;
            
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Concatenate_B_16.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Concatenate_B_16, index + 1);
            }
            logic_uScriptAct_Concatenate_B_16[ index++ ] = local_17_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Concatenate_uScriptAct_Concatenate_16.In(logic_uScriptAct_Concatenate_A_16, logic_uScriptAct_Concatenate_B_16, logic_uScriptAct_Concatenate_Separator_16, out logic_uScriptAct_Concatenate_Result_16);
      local_18_System_String = logic_uScriptAct_Concatenate_Result_16;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Concatenate_uScriptAct_Concatenate_16.Out;
      
      if ( test_0 == true )
      {
         Relay_In_51();
      }
   }
   
   void Relay_In_19()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_Concatenate_A_19.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Concatenate_A_19, index + 1);
            }
            logic_uScriptAct_Concatenate_A_19[ index++ ] = local_18_System_String;
            
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Concatenate_B_19.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Concatenate_B_19, index + 1);
            }
            logic_uScriptAct_Concatenate_B_19[ index++ ] = local_53_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Concatenate_uScriptAct_Concatenate_19.In(logic_uScriptAct_Concatenate_A_19, logic_uScriptAct_Concatenate_B_19, logic_uScriptAct_Concatenate_Separator_19, out logic_uScriptAct_Concatenate_Result_19);
      local_20_System_String = logic_uScriptAct_Concatenate_Result_19;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Concatenate_uScriptAct_Concatenate_19.Out;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_In_22()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_triggering_gameobject_UnityEngine_GameObject_previous != local_triggering_gameobject_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_triggering_gameobject_UnityEngine_GameObject_previous = local_triggering_gameobject_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_GameObjectHasTag_GameObject_22 = local_triggering_gameobject_UnityEngine_GameObject;
            
         }
         {
            int index = 0;
            if ( logic_uScriptCon_GameObjectHasTag_Tag_22.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptCon_GameObjectHasTag_Tag_22, index + 1);
            }
            logic_uScriptCon_GameObjectHasTag_Tag_22[ index++ ] = local_23_System_String;
            
         }
      }
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_22.In(logic_uScriptCon_GameObjectHasTag_GameObject_22, logic_uScriptCon_GameObjectHasTag_Tag_22);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_22.HasAllTags;
      
      if ( test_0 == true )
      {
         Relay_In_2();
      }
   }
   
   void Relay_In_51()
   {
      {
         {
            logic_uScriptAct_IntToString_Target_51 = total_possible_points;
            
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
      logic_uScriptAct_IntToString_uScriptAct_IntToString_51.In(logic_uScriptAct_IntToString_Target_51, logic_uScriptAct_IntToString_StandardFormat_51, logic_uScriptAct_IntToString_CustomFormat_51, logic_uScriptAct_IntToString_CustomCulture_51, out logic_uScriptAct_IntToString_Result_51);
      local_53_System_String = logic_uScriptAct_IntToString_Result_51;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_IntToString_uScriptAct_IntToString_51.Out;
      
      if ( test_0 == true )
      {
         Relay_In_19();
      }
   }
   
   void Relay_In_58()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_58 = local_score_System_Int32;
            
         }
         {
            logic_uScriptCon_CompareInt_B_58 = total_possible_points;
            
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_58.In(logic_uScriptCon_CompareInt_A_58, logic_uScriptCon_CompareInt_B_58);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_58.GreaterThanOrEqualTo;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_58.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_65();
      }
      if ( test_1 == true )
      {
         Relay_In_11();
      }
   }
   
   void Relay_In_65()
   {
      {
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
      logic_uScriptAct_SetString_uScriptAct_SetString_65.In(logic_uScriptAct_SetString_Value_65, logic_uScriptAct_SetString_ToUpperCase_65, logic_uScriptAct_SetString_ToLowerCase_65, logic_uScriptAct_SetString_TrimWhitespace_65, out logic_uScriptAct_SetString_Target_65);
      property_text_Detox_ScriptEditor_Parameter_text_66 = logic_uScriptAct_SetString_Target_65;
      property_text_Detox_ScriptEditor_Parameter_text_66_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
