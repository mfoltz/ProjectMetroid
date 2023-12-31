// Decompiled with JetBrains decompiler
// Type: JobHandleManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;

#nullable disable
[StructLayout(LayoutKind.Explicit)]
public struct JobHandleManager
{
  private static readonly System.IntPtr NativeFieldInfoPtr__UnmergedJobHandles;
  private static readonly System.IntPtr NativeFieldInfoPtr__InitialCapacity;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Public_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CombineAllDependencies_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddDependencies_Public_Void_NativeArray_1_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDependency_Public_Void_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearDependency_Public_Void_0;
  [FieldOffset(0)]
  public NativeList<JobHandle> _UnmergedJobHandles;
  [FieldOffset(16)]
  public readonly int _InitialCapacity;

  [CallerCount(16)]
  [CachedScanResults(RefRangeStart = 716000, RefRangeEnd = 716016, XrefRangeStart = 715997, XrefRangeEnd = 716000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JobHandleManager(Allocator allocator, int capacity = 8)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &allocator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &capacity;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr__ctor_Public_Void_Allocator_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716016, XrefRangeEnd = 716020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void System_IDisposable_Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(16)]
  [CachedScanResults(RefRangeStart = 716024, RefRangeEnd = 716040, XrefRangeStart = 716020, XrefRangeEnd = 716024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose(bool completeDependencyBeforeDisposing)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &completeDependencyBeforeDisposing;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 716049, RefRangeEnd = 716061, XrefRangeStart = 716040, XrefRangeEnd = 716049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JobHandle GetJobHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_GetJobHandle_Public_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 716074, RefRangeEnd = 716077, XrefRangeStart = 716061, XrefRangeEnd = 716074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CombineAllDependencies()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_CombineAllDependencies_Private_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 716098, RefRangeEnd = 716120, XrefRangeStart = 716077, XrefRangeEnd = 716098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Complete()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_Complete_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 716127, RefRangeEnd = 716150, XrefRangeStart = 716120, XrefRangeEnd = 716127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddDependency(JobHandle dependency)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &dependency;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716150, XrefRangeEnd = 716157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddDependencies(NativeArray<JobHandle> dependencies)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &dependencies;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_AddDependencies_Public_Void_NativeArray_1_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 716163, RefRangeEnd = 716170, XrefRangeStart = 716157, XrefRangeEnd = 716163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDependency(JobHandle dependency)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &dependency;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_SetDependency_Public_Void_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 716173, RefRangeEnd = 716174, XrefRangeStart = 716170, XrefRangeEnd = 716173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearDependency()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JobHandleManager.NativeMethodInfoPtr_ClearDependency_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JobHandleManager()
  {
    Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (JobHandleManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr);
    JobHandleManager.NativeFieldInfoPtr__UnmergedJobHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, nameof (_UnmergedJobHandles));
    JobHandleManager.NativeFieldInfoPtr__InitialCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, nameof (_InitialCapacity));
    JobHandleManager.NativeMethodInfoPtr__ctor_Public_Void_Allocator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663427);
    JobHandleManager.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663428);
    JobHandleManager.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663429);
    JobHandleManager.NativeMethodInfoPtr_GetJobHandle_Public_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663430);
    JobHandleManager.NativeMethodInfoPtr_CombineAllDependencies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663431);
    JobHandleManager.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663432);
    JobHandleManager.NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663433);
    JobHandleManager.NativeMethodInfoPtr_AddDependencies_Public_Void_NativeArray_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663434);
    JobHandleManager.NativeMethodInfoPtr_SetDependency_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663435);
    JobHandleManager.NativeMethodInfoPtr_ClearDependency_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, 100663436);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobHandleManager>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
