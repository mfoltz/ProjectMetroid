// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.UpdateData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalControlledEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalControlledPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CameraPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrustumPlanes;
    [FieldOffset(0)]
    public Entity LocalControlledEntity;
    [FieldOffset(8)]
    public float3 LocalControlledPosition;
    [FieldOffset(20)]
    public float3 CameraPosition;
    [FieldOffset(32)]
    public NativeArray<float4> FrustumPlanes;

    static UpdateData()
    {
      Il2CppClassPointerStore<UpdateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (UpdateData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateData>.NativeClassPtr);
      UpdateData.NativeFieldInfoPtr_LocalControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateData>.NativeClassPtr, nameof (LocalControlledEntity));
      UpdateData.NativeFieldInfoPtr_LocalControlledPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateData>.NativeClassPtr, nameof (LocalControlledPosition));
      UpdateData.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateData>.NativeClassPtr, nameof (CameraPosition));
      UpdateData.NativeFieldInfoPtr_FrustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateData>.NativeClassPtr, nameof (FrustumPlanes));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
