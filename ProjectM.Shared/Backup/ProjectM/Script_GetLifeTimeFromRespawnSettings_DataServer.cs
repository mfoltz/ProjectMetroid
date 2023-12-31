// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_GetLifeTimeFromRespawnSettings_DataServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_GetLifeTimeFromRespawnSettings_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    [FieldOffset(0)]
    public float Min;
    [FieldOffset(4)]
    public float Max;

    static Script_GetLifeTimeFromRespawnSettings_DataServer()
    {
      Il2CppClassPointerStore<Script_GetLifeTimeFromRespawnSettings_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Script_GetLifeTimeFromRespawnSettings_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_GetLifeTimeFromRespawnSettings_DataServer>.NativeClassPtr);
      Script_GetLifeTimeFromRespawnSettings_DataServer.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GetLifeTimeFromRespawnSettings_DataServer>.NativeClassPtr, nameof (Min));
      Script_GetLifeTimeFromRespawnSettings_DataServer.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GetLifeTimeFromRespawnSettings_DataServer>.NativeClassPtr, nameof (Max));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_GetLifeTimeFromRespawnSettings_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
