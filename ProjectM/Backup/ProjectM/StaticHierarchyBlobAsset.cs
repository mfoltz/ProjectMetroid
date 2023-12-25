// Decompiled with JetBrains decompiler
// Type: ProjectM.StaticHierarchyBlobAsset
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
  public struct StaticHierarchyBlobAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalToParents;
    [FieldOffset(0)]
    public BlobArray<float4x4> LocalToParents;

    static StaticHierarchyBlobAsset()
    {
      Il2CppClassPointerStore<StaticHierarchyBlobAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StaticHierarchyBlobAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticHierarchyBlobAsset>.NativeClassPtr);
      StaticHierarchyBlobAsset.NativeFieldInfoPtr_LocalToParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticHierarchyBlobAsset>.NativeClassPtr, nameof (LocalToParents));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticHierarchyBlobAsset>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
