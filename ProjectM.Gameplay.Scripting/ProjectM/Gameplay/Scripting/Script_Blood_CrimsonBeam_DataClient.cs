// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataClient
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Blood_CrimsonBeam_DataClient
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TickRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTickTime;
    [FieldOffset(0)]
    public float TickRate;
    [FieldOffset(8)]
    public double LastTickTime;

    static Script_Blood_CrimsonBeam_DataClient()
    {
      Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Blood_CrimsonBeam_DataClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataClient>.NativeClassPtr);
      Script_Blood_CrimsonBeam_DataClient.NativeFieldInfoPtr_TickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataClient>.NativeClassPtr, nameof (TickRate));
      Script_Blood_CrimsonBeam_DataClient.NativeFieldInfoPtr_LastTickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataClient>.NativeClassPtr, nameof (LastTickTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataClient>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
