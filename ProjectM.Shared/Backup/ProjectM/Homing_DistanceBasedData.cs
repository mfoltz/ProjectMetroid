// Decompiled with JetBrains decompiler
// Type: ProjectM.Homing_DistanceBasedData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Homing_DistanceBasedData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndDistance;
    [FieldOffset(0)]
    public float StartDistance;
    [FieldOffset(4)]
    public float EndDistance;

    static Homing_DistanceBasedData()
    {
      Il2CppClassPointerStore<Homing_DistanceBasedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Homing_DistanceBasedData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Homing_DistanceBasedData>.NativeClassPtr);
      Homing_DistanceBasedData.NativeFieldInfoPtr_StartDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_DistanceBasedData>.NativeClassPtr, nameof (StartDistance));
      Homing_DistanceBasedData.NativeFieldInfoPtr_EndDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Homing_DistanceBasedData>.NativeClassPtr, nameof (EndDistance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Homing_DistanceBasedData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
