//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class camera_trigger : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Camera_Gameobject = default(UnityEngine.GameObject);
   UnityEngine.GameObject Camera_Gameobject_previous = null;
   UnityEngine.Vector3 local_desired_position_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Quaternion local_desired_rotation_UnityEngine_Quaternion = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   public UnityEngine.Transform position_transform = default(UnityEngine.Transform);
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetPositionFromTransform logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_3 = new uScriptAct_GetPositionFromTransform( );
   UnityEngine.Transform logic_uScriptAct_GetPositionFromTransform_target_3 = default(UnityEngine.Transform);
   System.Boolean logic_uScriptAct_GetPositionFromTransform_getLocal_3 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_position_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_forward_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_right_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_up_3;
   UnityEngine.Matrix4x4 logic_uScriptAct_GetPositionFromTransform_worldMatrix_3;
   bool logic_uScriptAct_GetPositionFromTransform_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRotationFromTransform logic_uScriptAct_GetRotationFromTransform_uScriptAct_GetRotationFromTransform_7 = new uScriptAct_GetRotationFromTransform( );
   UnityEngine.Transform logic_uScriptAct_GetRotationFromTransform_target_7 = default(UnityEngine.Transform);
   System.Boolean logic_uScriptAct_GetRotationFromTransform_getLocal_7 = (bool) false;
   UnityEngine.Quaternion logic_uScriptAct_GetRotationFromTransform_rotation_7;
   UnityEngine.Vector3 logic_uScriptAct_GetRotationFromTransform_eulerAngle_7;
   bool logic_uScriptAct_GetRotationFromTransform_Out_7 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   UnityEngine.Vector3 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_position_5 = new Vector3( );
   UnityEngine.Quaternion method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_rotation_5 = new Quaternion( );
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Camera_Gameobject_previous != Camera_Gameobject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Camera_Gameobject_previous = Camera_Gameobject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Trigger component = owner_Connection_1.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Trigger>();
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
      if ( Camera_Gameobject_previous != Camera_Gameobject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Camera_Gameobject_previous = Camera_Gameobject;
         
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
               uScript_Trigger component = owner_Connection_1.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Trigger>();
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
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_1 )
      {
         {
            uScript_Trigger component = owner_Connection_1.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_3.SetParent(g);
      logic_uScriptAct_GetRotationFromTransform_uScriptAct_GetRotationFromTransform_7.SetParent(g);
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
   
   void Relay_OnEnterTrigger_0()
   {
   }
   
   void Relay_OnExitTrigger_0()
   {
   }
   
   void Relay_WhileInsideTrigger_0()
   {
      Relay_In_3();
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptAct_GetPositionFromTransform_target_3 = position_transform;
            
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
      logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_3.In(logic_uScriptAct_GetPositionFromTransform_target_3, logic_uScriptAct_GetPositionFromTransform_getLocal_3, out logic_uScriptAct_GetPositionFromTransform_position_3, out logic_uScriptAct_GetPositionFromTransform_forward_3, out logic_uScriptAct_GetPositionFromTransform_right_3, out logic_uScriptAct_GetPositionFromTransform_up_3, out logic_uScriptAct_GetPositionFromTransform_worldMatrix_3);
      local_desired_position_UnityEngine_Vector3 = logic_uScriptAct_GetPositionFromTransform_position_3;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_SetPositionAndRotation_5()
   {
      {
         {
         }
         {
            method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_position_5 = local_desired_position_UnityEngine_Vector3;
            
         }
         {
            method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_rotation_5 = local_desired_rotation_UnityEngine_Quaternion;
            
         }
      }
      {
         UnityEngine.Transform component;
         component = Camera_Gameobject.GetComponent<UnityEngine.Transform>();
         if ( null != component )
         {
            component.SetPositionAndRotation(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_position_5, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_rotation_5);
         }
      }
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptAct_GetRotationFromTransform_target_7 = position_transform;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetRotationFromTransform_uScriptAct_GetRotationFromTransform_7.In(logic_uScriptAct_GetRotationFromTransform_target_7, logic_uScriptAct_GetRotationFromTransform_getLocal_7, out logic_uScriptAct_GetRotationFromTransform_rotation_7, out logic_uScriptAct_GetRotationFromTransform_eulerAngle_7);
      local_desired_rotation_UnityEngine_Quaternion = logic_uScriptAct_GetRotationFromTransform_rotation_7;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRotationFromTransform_uScriptAct_GetRotationFromTransform_7.Out;
      
      if ( test_0 == true )
      {
         Relay_SetPositionAndRotation_5();
      }
   }
   
}
