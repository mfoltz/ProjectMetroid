// Decompiled with JetBrains decompiler
// Type: QueryExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
public static class QueryExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ToEntityArrayAsync_Public_Static_NativeArray_1_Entity_EntityQuery_Allocator_byref_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToComponentDataArrayAsync_Public_Static_NativeArray_1_T_EntityQuery_Allocator_byref_JobHandle_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716846, XrefRangeEnd = 716848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe NativeArray<Entity> ToEntityArrayAsync(
    this EntityQuery query,
    Allocator allocator,
    ref JobHandle injectIntoDependency)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &query;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref injectIntoDependency;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QueryExtensions.NativeMethodInfoPtr_ToEntityArrayAsync_Public_Static_NativeArray_1_Entity_EntityQuery_Allocator_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(NativeArray<Entity>*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe NativeArray<T> ToComponentDataArrayAsync<T>(
    this EntityQuery query,
    Allocator allocator,
    ref JobHandle injectIntoDependency)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &query;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref injectIntoDependency;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QueryExtensions.MethodInfoStoreGeneric_ToComponentDataArrayAsync_Public_Static_NativeArray_1_T_EntityQuery_Allocator_byref_JobHandle_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(NativeArray<T>*) IL2CPP.il2cpp_object_unbox(num);
  }

  static QueryExtensions()
  {
    Il2CppClassPointerStore<QueryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (QueryExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryExtensions>.NativeClassPtr);
    QueryExtensions.NativeMethodInfoPtr_ToEntityArrayAsync_Public_Static_NativeArray_1_Entity_EntityQuery_Allocator_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExtensions>.NativeClassPtr, 100663459);
    QueryExtensions.NativeMethodInfoPtr_ToComponentDataArrayAsync_Public_Static_NativeArray_1_T_EntityQuery_Allocator_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryExtensions>.NativeClassPtr, 100663460);
  }

  public QueryExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_ToComponentDataArrayAsync_Public_Static_NativeArray_1_T_EntityQuery_Allocator_byref_JobHandle_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(QueryExtensions.NativeMethodInfoPtr_ToComponentDataArrayAsync_Public_Static_NativeArray_1_T_EntityQuery_Allocator_byref_JobHandle_0, Il2CppClassPointerStore<QueryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
