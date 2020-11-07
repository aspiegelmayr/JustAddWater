//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/follow_target_heightonly")]
public class follow_target_heightonly_Component : uScriptCode
{
   #pragma warning disable 414
   public follow_target_heightonly ExposedVariables = new follow_target_heightonly( ); 
   #pragma warning restore 414
   
   public System.Boolean should_follow_during_cutscene { get { return ExposedVariables.should_follow_during_cutscene; } set { ExposedVariables.should_follow_during_cutscene = value; } } 
   public System.Boolean should_look_at_target { get { return ExposedVariables.should_look_at_target; } set { ExposedVariables.should_look_at_target = value; } } 
   public System.Boolean should_look_in_direction_of_movement { get { return ExposedVariables.should_look_in_direction_of_movement; } set { ExposedVariables.should_look_in_direction_of_movement = value; } } 
   public System.Boolean shoul_look_at_target_during_cutscene { get { return ExposedVariables.shoul_look_at_target_during_cutscene; } set { ExposedVariables.shoul_look_at_target_during_cutscene = value; } } 
   public System.Single height_offset { get { return ExposedVariables.height_offset; } set { ExposedVariables.height_offset = value; } } 
   public System.Single xz_distance { get { return ExposedVariables.xz_distance; } set { ExposedVariables.xz_distance = value; } } 
   public UnityEngine.GameObject target { get { return ExposedVariables.target; } set { ExposedVariables.target = value; } } 
   
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
