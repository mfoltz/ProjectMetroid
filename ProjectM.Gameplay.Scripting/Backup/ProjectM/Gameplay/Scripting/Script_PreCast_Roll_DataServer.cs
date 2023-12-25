// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_PreCast_Roll_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_PreCast_Roll_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpTriggerTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_RollAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputIsPressed;
    [FieldOffset(0)]
    public float JumpTriggerTimer;
    [FieldOffset(4)]
    public PrefabGUID RollAbility;
    [FieldOffset(8)]
    public PrefabGUID JumpAbility;
    [FieldOffset(12)]
    public bool InputIsPressed;

    static Script_PreCast_Roll_DataServer()
    {
      Il2CppClassPointerStore<Script_PreCast_Roll_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_PreCast_Roll_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_PreCast_Roll_DataServer>.NativeClassPtr);
      Script_PreCast_Roll_DataServer.NativeFieldInfoPtr_JumpTriggerTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll_DataServer>.NativeClassPtr, nameof (JumpTriggerTimer));
      Script_PreCast_Roll_DataServer.NativeFieldInfoPtr_RollAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll_DataServer>.NativeClassPtr, nameof (RollAbility));
      Script_PreCast_Roll_DataServer.NativeFieldInfoPtr_JumpAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll_DataServer>.NativeClassPtr, nameof (JumpAbility));
      Script_PreCast_Roll_DataServer.NativeFieldInfoPtr_InputIsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll_DataServer>.NativeClassPtr, nameof (InputIsPressed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_PreCast_Roll_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
