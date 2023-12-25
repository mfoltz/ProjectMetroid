// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollCreateData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RagdollCreateData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelUserEntity;
    [FieldOffset(0)]
    public float3 RagdollForce;
    [FieldOffset(12)]
    public Entity HybridModelUserEntity;

    static RagdollCreateData()
    {
      Il2CppClassPointerStore<RagdollCreateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollCreateData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollCreateData>.NativeClassPtr);
      RagdollCreateData.NativeFieldInfoPtr_RagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollCreateData>.NativeClassPtr, nameof (RagdollForce));
      RagdollCreateData.NativeFieldInfoPtr_HybridModelUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollCreateData>.NativeClassPtr, nameof (HybridModelUserEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollCreateData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
