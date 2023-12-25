// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkRemappingLookup`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Terrain;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  public struct ChunkRemappingLookup<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplaceMap;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeHashMap_2_ChunkRemapping_1_T_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFind_Public_Boolean_TerrainChunk_T_byref_T_0;
    public NativeHashMap<ChunkRemapping<T>, T> _ReplaceMap;

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRemappingLookup(NativeHashMap<ChunkRemapping<T>, T> replaceMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &replaceMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRemappingLookup<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeHashMap_2_ChunkRemapping_1_T_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1012502, RefRangeEnd = 1012503, XrefRangeStart = 1012500, XrefRangeEnd = 1012502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFind(TerrainChunk coordinate, T sourcePrefab, out T replaceWith)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &coordinate;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) sourcePrefab;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref sourcePrefab;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local3;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local3 = ref (*(T*) &zero);
      }
      else
        local3 = ref replaceWith;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ChunkRemappingLookup<T>.NativeMethodInfoPtr_TryFind_Public_Boolean_TerrainChunk_T_byref_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local4 = ref replaceWith;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local4 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    static ChunkRemappingLookup()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ChunkRemappingLookup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", "ChunkRemappingLookup`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRemappingLookup<T>>.NativeClassPtr);
      ChunkRemappingLookup<T>.NativeFieldInfoPtr__ReplaceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRemappingLookup<T>>.NativeClassPtr, nameof (_ReplaceMap));
      ChunkRemappingLookup<T>.NativeMethodInfoPtr__ctor_Public_Void_NativeHashMap_2_ChunkRemapping_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRemappingLookup<T>>.NativeClassPtr, 100678888);
      ChunkRemappingLookup<T>.NativeMethodInfoPtr_TryFind_Public_Boolean_TerrainChunk_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRemappingLookup<T>>.NativeClassPtr, 100678889);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkRemappingLookup<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
