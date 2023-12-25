// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.SnappingPointCollider
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SnappingPointCollider
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SnappingPointIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Collider;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColliderLocalTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    [FieldOffset(0)]
    public int SnappingPointIndex;
    [FieldOffset(8)]
    public BlobAssetReference<Unity.Physics.Collider> Collider;
    [FieldOffset(16)]
    public Translation ColliderLocalTranslation;
    [FieldOffset(28)]
    public int Priority;

    static SnappingPointCollider()
    {
      Il2CppClassPointerStore<SnappingPointCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (SnappingPointCollider));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnappingPointCollider>.NativeClassPtr);
      SnappingPointCollider.NativeFieldInfoPtr_SnappingPointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointCollider>.NativeClassPtr, nameof (SnappingPointIndex));
      SnappingPointCollider.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointCollider>.NativeClassPtr, nameof (Collider));
      SnappingPointCollider.NativeFieldInfoPtr_ColliderLocalTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointCollider>.NativeClassPtr, nameof (ColliderLocalTranslation));
      SnappingPointCollider.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointCollider>.NativeClassPtr, nameof (Priority));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SnappingPointCollider>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
