// Decompiled with JetBrains decompiler
// Type: JobExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Entities;

#nullable disable
public static class JobExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobs_Public_Static_Void_byref_T_EntityQuery_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 715993, RefRangeEnd = 715997, XrefRangeStart = 715992, XrefRangeEnd = 715993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RunWithoutJobs<T>(ref this T jobData, EntityQuery query)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jobData);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobExtensions.MethodInfoStoreGeneric_RunWithoutJobs_Public_Static_Void_byref_T_EntityQuery_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref T local = ref jobData;
    System.IntPtr objectPointer = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
    local = (T) valueGeneric;
  }

  static JobExtensions()
  {
    Il2CppClassPointerStore<JobExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (JobExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobExtensions>.NativeClassPtr);
    JobExtensions.NativeMethodInfoPtr_RunWithoutJobs_Public_Static_Void_byref_T_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobExtensions>.NativeClassPtr, 100663426);
  }

  public JobExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_RunWithoutJobs_Public_Static_Void_byref_T_EntityQuery_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(JobExtensions.NativeMethodInfoPtr_RunWithoutJobs_Public_Static_Void_byref_T_EntityQuery_0, Il2CppClassPointerStore<JobExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
