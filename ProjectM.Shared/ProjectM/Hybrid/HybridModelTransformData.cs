// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelTransformData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridModelTransformData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    [FieldOffset(0)]
    public Vector3 Position;
    [FieldOffset(12)]
    public Quaternion Rotation;

    static HybridModelTransformData()
    {
      Il2CppClassPointerStore<HybridModelTransformData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (HybridModelTransformData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelTransformData>.NativeClassPtr);
      HybridModelTransformData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelTransformData>.NativeClassPtr, nameof (Position));
      HybridModelTransformData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelTransformData>.NativeClassPtr, nameof (Rotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelTransformData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
