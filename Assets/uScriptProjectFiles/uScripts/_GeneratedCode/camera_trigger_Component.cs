//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/camera_trigger")]
public class camera_trigger_Component : uScriptCode
{
   #pragma warning disable 414
   public camera_trigger ExposedVariables = new camera_trigger( ); 
   #pragma warning restore 414
   
   public UnityEngine.Transform position_transform { get { return ExposedVariables.position_transform; } set { ExposedVariables.position_transform = value; } } 
   public UnityEngine.GameObject Camera_Gameobject { get { return ExposedVariables.Camera_Gameobject; } set { ExposedVariables.Camera_Gameobject = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.PLE" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
      }
   #endif
}
