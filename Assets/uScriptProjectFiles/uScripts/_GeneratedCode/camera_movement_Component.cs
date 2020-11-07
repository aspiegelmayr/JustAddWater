//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/camera_movement")]
public class camera_movement_Component : uScriptCode
{
   #pragma warning disable 414
   public camera_movement ExposedVariables = new camera_movement( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject follow_target { get { return ExposedVariables.follow_target; } set { ExposedVariables.follow_target = value; } } 
   public UnityEngine.Vector3 camera_offset { get { return ExposedVariables.camera_offset; } set { ExposedVariables.camera_offset = value; } } 
   public System.Boolean should_follow_during_cutscene { get { return ExposedVariables.should_follow_during_cutscene; } set { ExposedVariables.should_follow_during_cutscene = value; } } 
   
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
