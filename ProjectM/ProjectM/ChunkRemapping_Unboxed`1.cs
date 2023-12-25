// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkRemapping_Unboxed`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Terrain;

#nullable disable
namespace ProjectM
{
  public struct ChunkRemapping_Unboxed<T> where T : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_Coordinate;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ChunkRemapping_Unboxed_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    public T Key;
    public TerrainChunk Coordinate;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012495, XrefRangeEnd = 1012496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ChunkRemapping_Unboxed<T> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRemapping_Unboxed<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ChunkRemapping_Unboxed_1_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012496, XrefRangeEnd = 1012498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRemapping_Unboxed<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012498, XrefRangeEnd = 1012500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRemapping_Unboxed<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ChunkRemapping_Unboxed()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", "ChunkRemapping`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr);
      ChunkRemapping_Unboxed<T>.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr, nameof (Key));
      ChunkRemapping_Unboxed<T>.NativeFieldInfoPtr_Coordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr, nameof (Coordinate));
      ChunkRemapping_Unboxed<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ChunkRemapping_Unboxed_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr, 100678885);
      ChunkRemapping_Unboxed<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr, 100678886);
      ChunkRemapping_Unboxed<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr, 100678887);
    }

    public ChunkRemapping<T> BoxIl2CppObject()
    {
      return new ChunkRemapping<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkRemapping_Unboxed<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
