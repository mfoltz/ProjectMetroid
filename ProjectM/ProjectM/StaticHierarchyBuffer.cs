// Decompiled with JetBrains decompiler
// Type: ProjectM.StaticHierarchyBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StaticHierarchyBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlobIndex;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public ushort BlobIndex;

    static StaticHierarchyBuffer()
    {
      Il2CppClassPointerStore<StaticHierarchyBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StaticHierarchyBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticHierarchyBuffer>.NativeClassPtr);
      StaticHierarchyBuffer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticHierarchyBuffer>.NativeClassPtr, nameof (Entity));
      StaticHierarchyBuffer.NativeFieldInfoPtr_BlobIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticHierarchyBuffer>.NativeClassPtr, nameof (BlobIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticHierarchyBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
