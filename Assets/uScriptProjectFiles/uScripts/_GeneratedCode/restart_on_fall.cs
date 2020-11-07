//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class restart_on_fall : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.Vector3 local_4_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_6_System_Single = (float) 0;
   System.Single local_7_System_Single = (float) -20;
   System.String local_current_scene_name_System_String = "";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   UnityEngine.GameObject owner_Connection_3 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_2 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_2 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_2 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_2 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_2 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_2 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_2 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_2 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_5 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_5 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_5;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_5;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_5;
   bool logic_uScriptAct_GetComponentsVector3_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_LoadLevel logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_8 = new uScriptAct_LoadLevel( );
   System.String logic_uScriptAct_LoadLevel_name_8 = "";
   System.Boolean logic_uScriptAct_LoadLevel_destroyOtherObjects_8 = (bool) true;
   System.Boolean logic_uScriptAct_LoadLevel_blockUntilLoaded_8 = (bool) true;
   bool logic_uScriptAct_LoadLevel_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_9 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_9 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_9;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_9;
   bool logic_uScriptAct_GetPositionAndRotation_Out_9 = true;
   //pointer to script instanced logic node
   uScriptNodeGetCurrentSceneName logic_uScriptNodeGetCurrentSceneName_uScriptNodeGetCurrentSceneName_10 = new uScriptNodeGetCurrentSceneName( );
   System.String logic_uScriptNodeGetCurrentSceneName_Result_10;
   bool logic_uScriptNodeGetCurrentSceneName_Out_10 = true;
   
   //event nodes
   
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
               uScript_Update component = owner_Connection_1.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Update>();
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
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
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
               uScript_Update component = owner_Connection_1.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Update>();
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
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_2.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_5.SetParent(g);
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_8.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9.SetParent(g);
      logic_uScriptNodeGetCurrentSceneName_uScriptNodeGetCurrentSceneName_10.SetParent(g);
      owner_Connection_1 = parentGameObject;
      owner_Connection_3 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_8.Loaded += uScriptAct_LoadLevel_Loaded_8;
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
      
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_8.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_8.Loaded -= uScriptAct_LoadLevel_Loaded_8;
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
   
   void uScriptAct_LoadLevel_Loaded_8(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Loaded_8( );
   }
   
   void Relay_OnUpdate_0()
   {
      Relay_In_9();
   }
   
   void Relay_OnLateUpdate_0()
   {
   }
   
   void Relay_OnFixedUpdate_0()
   {
   }
   
   void Relay_In_2()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_2 = local_6_System_Single;
            
         }
         {
            logic_uScriptCon_CompareFloat_B_2 = local_7_System_Single;
            
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_2.In(logic_uScriptCon_CompareFloat_A_2, logic_uScriptCon_CompareFloat_B_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_2.LessThanOrEqualTo;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_5 = local_4_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_5.In(logic_uScriptAct_GetComponentsVector3_InputVector3_5, out logic_uScriptAct_GetComponentsVector3_X_5, out logic_uScriptAct_GetComponentsVector3_Y_5, out logic_uScriptAct_GetComponentsVector3_Z_5);
      local_6_System_Single = logic_uScriptAct_GetComponentsVector3_Y_5;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_5.Out;
      
      if ( test_0 == true )
      {
         Relay_In_2();
      }
   }
   
   void Relay_Loaded_8()
   {
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptAct_LoadLevel_name_8 = local_current_scene_name_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_LoadLevel_uScriptAct_LoadLevel_8.In(logic_uScriptAct_LoadLevel_name_8, logic_uScriptAct_LoadLevel_destroyOtherObjects_8, logic_uScriptAct_LoadLevel_blockUntilLoaded_8);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_9()
   {
      {
         {
            logic_uScriptAct_GetPositionAndRotation_Target_9 = owner_Connection_3;
            
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
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9.In(logic_uScriptAct_GetPositionAndRotation_Target_9, logic_uScriptAct_GetPositionAndRotation_GetLocal_9, out logic_uScriptAct_GetPositionAndRotation_Position_9, out logic_uScriptAct_GetPositionAndRotation_Rotation_9, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_9, out logic_uScriptAct_GetPositionAndRotation_Forward_9, out logic_uScriptAct_GetPositionAndRotation_Up_9, out logic_uScriptAct_GetPositionAndRotation_Right_9);
      local_4_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_9;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9.Out;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_10()
   {
      {
         {
         }
      }
      logic_uScriptNodeGetCurrentSceneName_uScriptNodeGetCurrentSceneName_10.In(out logic_uScriptNodeGetCurrentSceneName_Result_10);
      local_current_scene_name_System_String = logic_uScriptNodeGetCurrentSceneName_Result_10;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptNodeGetCurrentSceneName_uScriptNodeGetCurrentSceneName_10.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
}
