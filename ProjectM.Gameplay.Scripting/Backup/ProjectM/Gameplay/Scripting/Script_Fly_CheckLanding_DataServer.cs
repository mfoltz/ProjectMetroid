// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Fly_CheckLanding_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Fly_CheckLanding_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnLocationFoundEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_LandingBlocked;
    [FieldOffset(0)]
    public GameplayEventId OnLocationFoundEventId;
    [FieldOffset(8)]
    public AssetGuid LandingBlocked;

    static Script_Fly_CheckLanding_DataServer()
    {
      Il2CppClassPointerStore<Script_Fly_CheckLanding_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Fly_CheckLanding_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Fly_CheckLanding_DataServer>.NativeClassPtr);
      Script_Fly_CheckLanding_DataServer.NativeFieldInfoPtr_OnLocationFoundEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Fly_CheckLanding_DataServer>.NativeClassPtr, nameof (OnLocationFoundEventId));
      Script_Fly_CheckLanding_DataServer.NativeFieldInfoPtr_LandingBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Fly_CheckLanding_DataServer>.NativeClassPtr, nameof (LandingBlocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Fly_CheckLanding_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
