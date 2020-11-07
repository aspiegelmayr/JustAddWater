//uScript Generated Code - Build 1.1.3133
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class spawn_objects_on_proximity : uScriptLogic
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
   public UnityEngine.GameObject[] objects_to_spawn = new UnityEngine.GameObject[] {};
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_2 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_4 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_4 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_4 = (bool) false;
   System.Boolean logic_uScriptAct_Toggle_checkState_4 = (bool) true;
   bool logic_uScriptAct_Toggle_Out_4 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_1 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_2 || false == m_RegisteredForEvents )
      {
         owner_Connection_2 = parentGameObject;
         if ( null != owner_Connection_2 )
         {
            {
               uScript_Trigger component = owner_Connection_2.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_2.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
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
         if ( null != owner_Connection_2 )
         {
            {
               uScript_Trigger component = owner_Connection_2.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_2.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
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
      if ( null != owner_Connection_2 )
      {
         {
            uScript_Trigger component = owner_Connection_2.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
               component.OnExitTrigger -= Instance_OnExitTrigger_1;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.SetParent(g);
      owner_Connection_2 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OnOut += uScriptAct_Toggle_OnOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OffOut += uScriptAct_Toggle_OffOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.ToggleOut += uScriptAct_Toggle_ToggleOut_4;
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
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OnOut -= uScriptAct_Toggle_OnOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.OffOut -= uScriptAct_Toggle_OffOut_4;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_4.ToggleOut -= uScriptAct_Toggle_ToggleOut_4;
   }
   
   void Instance_OnEnterTrigger_1(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_1( );
   }
   
   void Instance_OnExitTrigger_1(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_1( );
   }
   
   void Instance_WhileInsideTrigger_1(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_1( );
   }
   
   void uScriptAct_Toggle_OnOut_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_4( );
   }
   
   void uScriptAct_Toggle_OffOut_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_4( );
   }
   
   void uScriptAct_Toggle_ToggleOut_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_4( );
   }
   
   void Relay_OnEnterTrigger_1()
   {
      if (true == CheckDebugBreak("201364ec-2fbf-4b33-8a46-6f473a543736", "Trigger_Event", Relay_OnEnterTrigger_1)) return; 
      Relay_TurnOn_4();
   }
   
   void Relay_OnExitTrigger_1()
   {
      if (true == CheckDebugBreak("201364ec-2fbf-4b33-8a46-6f473a543736", "Trigger_Event", Relay_OnExitTrigger_1)) return; 
   }
   
   void Relay_WhileInsideTrigger_1()
   {
      if (true == CheckDebugBreak("201364ec-2fbf-4b33-8a46-6f473a543736", "Trigger_Event", Relay_WhileInsideTrigger_1)) return; 
   }
   
   void Relay_OnOut_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16f711a9-4741-4b2f-91a4-e809b62137d9", "Toggle", Relay_OnOut_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript spawn_objects_on_proximity.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OffOut_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16f711a9-4741-4b2f-91a4-e809b62137d9", "Toggle", Relay_OffOut_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript spawn_objects_on_proximity.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_ToggleOut_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16f711a9-4741-4b2f-91a4-e809b62137d9", "Toggle", Relay_ToggleOut_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript spawn_objects_on_proximity.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOn_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16f711a9-4741-4b2f-91a4-e809b62137d9", "Toggle", Relay_TurnOn_4)) return; 
         {
            {
               System.Array properties;
               int index = 0;
               properties = objects_to_spawn;
               if ( logic_uScriptAct_Toggle_Target_4.Length != index + properties.Length)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_4, index + properties.Length);
               }
               System.Array.Copy(properties, 0, logic_uScriptAct_Toggle_Target_4, index, properties.Length);
               index += properties.Length;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_4.TurnOn(logic_uScriptAct_Toggle_Target_4, logic_uScriptAct_Toggle_IgnoreChildren_4, logic_uScriptAct_Toggle_checkState_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript spawn_objects_on_proximity.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_TurnOff_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16f711a9-4741-4b2f-91a4-e809b62137d9", "Toggle", Relay_TurnOff_4)) return; 
         {
            {
               System.Array properties;
               int index = 0;
               properties = objects_to_spawn;
               if ( logic_uScriptAct_Toggle_Target_4.Length != index + properties.Length)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_4, index + properties.Length);
               }
               System.Array.Copy(properties, 0, logic_uScriptAct_Toggle_Target_4, index, properties.Length);
               index += properties.Length;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_4.TurnOff(logic_uScriptAct_Toggle_Target_4, logic_uScriptAct_Toggle_IgnoreChildren_4, logic_uScriptAct_Toggle_checkState_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript spawn_objects_on_proximity.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Toggle_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("16f711a9-4741-4b2f-91a4-e809b62137d9", "Toggle", Relay_Toggle_4)) return; 
         {
            {
               System.Array properties;
               int index = 0;
               properties = objects_to_spawn;
               if ( logic_uScriptAct_Toggle_Target_4.Length != index + properties.Length)
               {
                  System.Array.Resize(ref logic_uScriptAct_Toggle_Target_4, index + properties.Length);
               }
               System.Array.Copy(properties, 0, logic_uScriptAct_Toggle_Target_4, index, properties.Length);
               index += properties.Length;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_Toggle_uScriptAct_Toggle_4.Toggle(logic_uScriptAct_Toggle_Target_4, logic_uScriptAct_Toggle_IgnoreChildren_4, logic_uScriptAct_Toggle_checkState_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript spawn_objects_on_proximity.uscript at Toggle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "spawn_objects_on_proximity.uscript:objects_to_spawn", objects_to_spawn);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b24ecfa3-b998-4f01-83c8-11e3ed1cd1e0", objects_to_spawn);
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
