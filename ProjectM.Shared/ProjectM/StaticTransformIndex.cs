// Decompiled with JetBrains decompiler
// Type: ProjectM.StaticTransformIndex
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StaticTransformIndex
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSceneId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StaticTransformIndex_0;
    [FieldOffset(0)]
    public ChunkSceneId ChunkSceneId;
    [FieldOffset(8)]
    public int TransformIndex;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762370, XrefRangeEnd = 762371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(StaticTransformIndex other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StaticTransformIndex.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StaticTransformIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StaticTransformIndex()
    {
      Il2CppClassPointerStore<StaticTransformIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StaticTransformIndex));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformIndex>.NativeClassPtr);
      StaticTransformIndex.NativeFieldInfoPtr_ChunkSceneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndex>.NativeClassPtr, nameof (ChunkSceneId));
      StaticTransformIndex.NativeFieldInfoPtr_TransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndex>.NativeClassPtr, nameof (TransformIndex));
      StaticTransformIndex.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StaticTransformIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndex>.NativeClassPtr, 100667373);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticTransformIndex>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
