//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class constant_rotation : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Single x_rotation = (float) 1;
   public System.Single y_rotation = (float) 1;
   public System.Single z_rotation = (float) 1;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_5 = null;
   
   //logic nodes
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_xAngle_1 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_yAngle_1 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_zAngle_1 = (float) 0;
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
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
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
   
   void Relay_OnUpdate_0()
   {
      Relay_Rotate_1();
   }
   
   void Relay_OnLateUpdate_0()
   {
   }
   
   void Relay_OnFixedUpdate_0()
   {
   }
   
   void Relay_Rotate_1()
   {
      {
         {
         }
         {
            method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_xAngle_1 = x_rotation;
            
         }
         {
            method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_yAngle_1 = y_rotation;
            
         }
         {
            method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_zAngle_1 = z_rotation;
            
         }
      }
      {
         UnityEngine.Transform component;
         component = owner_Connection_5.GetComponent<UnityEngine.Transform>();
         if ( null != component )
         {
            component.Rotate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_xAngle_1, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_yAngle_1, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_zAngle_1);
         }
      }
   }
   
}
