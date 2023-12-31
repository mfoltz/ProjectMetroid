// Decompiled with JetBrains decompiler
// Type: ProjectM.CollisionDetectionSystem_Base
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM
{
  public class CollisionDetectionSystem_Base : SystemBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetCollisionDetectionAsync_Public_Abstract_Virtual_New_CollisionDetection_byref_JobHandle_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCollisionDetectionAndComplete_Public_Abstract_Virtual_New_CollisionDetection_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddInputJobHandle_Public_Abstract_Virtual_New_Void_JobHandle_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public virtual unsafe CollisionDetection GetCollisionDetectionAsync(out JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref dependency;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem_Base.NativeMethodInfoPtr_GetCollisionDetectionAsync_Public_Abstract_Virtual_New_CollisionDetection_byref_JobHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CollisionDetection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe CollisionDetection GetCollisionDetectionAndComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem_Base.NativeMethodInfoPtr_GetCollisionDetectionAndComplete_Public_Abstract_Virtual_New_CollisionDetection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CollisionDetection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe void AddInputJobHandle(JobHandle jobHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &jobHandle;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem_Base.NativeMethodInfoPtr_AddInputJobHandle_Public_Abstract_Virtual_New_Void_JobHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CollisionDetectionSystem_Base()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CollisionDetectionSystem_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollisionDetectionSystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CollisionDetectionSystem_Base()
    {
      Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CollisionDetectionSystem_Base));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr);
      CollisionDetectionSystem_Base.NativeMethodInfoPtr_GetCollisionDetectionAsync_Public_Abstract_Virtual_New_CollisionDetection_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr, 100663866);
      CollisionDetectionSystem_Base.NativeMethodInfoPtr_GetCollisionDetectionAndComplete_Public_Abstract_Virtual_New_CollisionDetection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr, 100663867);
      CollisionDetectionSystem_Base.NativeMethodInfoPtr_AddInputJobHandle_Public_Abstract_Virtual_New_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr, 100663868);
      CollisionDetectionSystem_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr, 100663869);
      CollisionDetectionSystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDetectionSystem_Base>.NativeClassPtr, 100663870);
    }

    public CollisionDetectionSystem_Base(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
