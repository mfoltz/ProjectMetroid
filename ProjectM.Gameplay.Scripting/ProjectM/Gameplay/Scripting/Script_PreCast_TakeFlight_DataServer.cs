// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_PreCast_TakeFlight_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_PreCast_TakeFlight_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_FlightBlocked;
    [FieldOffset(0)]
    public PrefabGUID Ability;
    [FieldOffset(4)]
    public AssetGuid FlightBlocked;

    static Script_PreCast_TakeFlight_DataServer()
    {
      Il2CppClassPointerStore<Script_PreCast_TakeFlight_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_PreCast_TakeFlight_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_PreCast_TakeFlight_DataServer>.NativeClassPtr);
      Script_PreCast_TakeFlight_DataServer.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_TakeFlight_DataServer>.NativeClassPtr, nameof (Ability));
      Script_PreCast_TakeFlight_DataServer.NativeFieldInfoPtr_FlightBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_TakeFlight_DataServer>.NativeClassPtr, nameof (FlightBlocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_PreCast_TakeFlight_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
