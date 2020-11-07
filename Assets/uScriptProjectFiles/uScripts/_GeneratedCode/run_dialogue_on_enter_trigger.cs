//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class run_dialogue_on_enter_trigger : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   [Multiline(3)]
   public System.String yarn_node_name = "";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptNodeStartDialogue logic_uScriptNodeStartDialogue_uScriptNodeStartDialogue_2 = new uScriptNodeStartDialogue( );
   System.String logic_uScriptNodeStartDialogue_yarn_node_name_2 = "";
   bool logic_uScriptNodeStartDialogue_Out_2 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   
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
               uScript_Trigger_NoStay component = owner_Connection_1.GetComponent<uScript_Trigger_NoStay>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Trigger_NoStay>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
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
               uScript_Trigger_NoStay component = owner_Connection_1.GetComponent<uScript_Trigger_NoStay>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Trigger_NoStay>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
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
            uScript_Trigger_NoStay component = owner_Connection_1.GetComponent<uScript_Trigger_NoStay>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptNodeStartDialogue_uScriptNodeStartDialogue_2.SetParent(g);
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
   
   void Instance_OnEnterTrigger_0(object o, uScript_Trigger_NoStay.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_0( );
   }
   
   void Instance_OnExitTrigger_0(object o, uScript_Trigger_NoStay.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_0( );
   }
   
   void Relay_OnEnterTrigger_0()
   {
      Relay_In_2();
   }
   
   void Relay_OnExitTrigger_0()
   {
   }
   
   void Relay_In_2()
   {
      {
         {
            logic_uScriptNodeStartDialogue_yarn_node_name_2 = yarn_node_name;
            
         }
      }
      logic_uScriptNodeStartDialogue_uScriptNodeStartDialogue_2.In(logic_uScriptNodeStartDialogue_yarn_node_name_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
