// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkIdSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM.Network
{
  public class NetworkIdSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__NetworkIdToEntityMap;
    private static readonly IntPtr NativeFieldInfoPtr__Dependency;
    private static readonly IntPtr NativeMethodInfoPtr_GetNetworkIdMapAndComplete_Public_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNetworkIdMapAsync_Public_NativeHashMap_2_NetworkId_Entity_byref_JobHandle_0;
    private static readonly IntPtr NativeMethodInfoPtr_ResetDependency_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 780510, RefRangeEnd = 780521, XrefRangeStart = 780509, XrefRangeEnd = 780510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeHashMap<NetworkId, Entity> GetNetworkIdMapAndComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkIdSystem.NativeMethodInfoPtr_GetNetworkIdMapAndComplete_Public_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashMap<NetworkId, Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(71)]
    [CachedScanResults(RefRangeStart = 780522, RefRangeEnd = 780593, XrefRangeStart = 780521, XrefRangeEnd = 780522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeHashMap<NetworkId, Entity> GetNetworkIdMapAsync(out JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref dependency;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkIdSystem.NativeMethodInfoPtr_GetNetworkIdMapAsync_Public_NativeHashMap_2_NetworkId_Entity_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashMap<NetworkId, Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 780594, RefRangeEnd = 780599, XrefRangeStart = 780593, XrefRangeEnd = 780594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetDependency()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkIdSystem.NativeMethodInfoPtr_ResetDependency_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 780600, RefRangeEnd = 780601, XrefRangeStart = 780599, XrefRangeEnd = 780600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddDependency(JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &dependency;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkIdSystem.NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 780601, XrefRangeEnd = 780606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NetworkIdSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 780606, XrefRangeEnd = 780610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NetworkIdSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NetworkIdSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkIdSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkIdSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NetworkIdSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkIdSystem()
    {
      Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkIdSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr);
      NetworkIdSystem.NativeFieldInfoPtr__NetworkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, nameof (_NetworkIdToEntityMap));
      NetworkIdSystem.NativeFieldInfoPtr__Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, nameof (_Dependency));
      NetworkIdSystem.NativeMethodInfoPtr_GetNetworkIdMapAndComplete_Public_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669103);
      NetworkIdSystem.NativeMethodInfoPtr_GetNetworkIdMapAsync_Public_NativeHashMap_2_NetworkId_Entity_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669104);
      NetworkIdSystem.NativeMethodInfoPtr_ResetDependency_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669105);
      NetworkIdSystem.NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669106);
      NetworkIdSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669107);
      NetworkIdSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669108);
      NetworkIdSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669109);
      NetworkIdSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669110);
      NetworkIdSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkIdSystem>.NativeClassPtr, 100669111);
    }

    public NetworkIdSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashMap<NetworkId, Entity> _NetworkIdToEntityMap
    {
      get
      {
        return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkIdSystem.NativeFieldInfoPtr__NetworkIdToEntityMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkIdSystem.NativeFieldInfoPtr__NetworkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe JobHandleManager _Dependency
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkIdSystem.NativeFieldInfoPtr__Dependency));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkIdSystem.NativeFieldInfoPtr__Dependency)) = value;
      }
    }
  }
}
