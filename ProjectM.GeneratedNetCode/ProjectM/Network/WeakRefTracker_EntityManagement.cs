// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.WeakRefTracker_EntityManagement
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WeakRefTracker_EntityManagement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WeakRefTracker;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBufferWeakRef_Private_Void_NetworkId_WeakRefFieldId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveComponentWeakRef_Private_Void_NetworkId_WeakRefFieldId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveWeakRef_Private_Boolean_WeakRefId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WeakRefTracker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntity_Public_Void_NetworkId_Entity_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyEntity_Public_Void_NetworkId_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntity_Generated_Private_Void_NetworkId_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyEntity_Generated_Private_Void_NetworkId_NetworkSnapshotType_0;
    [FieldOffset(0)]
    public WeakRefTracker WeakRefTracker;

    [CallerCount(78)]
    [CachedScanResults(RefRangeStart = 1622025, RefRangeEnd = 1622103, XrefRangeStart = 1622015, XrefRangeEnd = 1622025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveBufferWeakRef(NetworkId networkId, WeakRefFieldId fieldId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr_RemoveBufferWeakRef_Private_Void_NetworkId_WeakRefFieldId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(327)]
    [CachedScanResults(RefRangeStart = 1622104, RefRangeEnd = 1622431, XrefRangeStart = 1622103, XrefRangeEnd = 1622104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveComponentWeakRef(NetworkId networkId, WeakRefFieldId fieldId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr_RemoveComponentWeakRef_Private_Void_NetworkId_WeakRefFieldId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 1622440, RefRangeEnd = 1622459, XrefRangeStart = 1622431, XrefRangeEnd = 1622440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryRemoveWeakRef(WeakRefTracker.WeakRefId weakRef)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &weakRef;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr_TryRemoveWeakRef_Private_Boolean_WeakRefId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1483809, RefRangeEnd = 1483810, XrefRangeStart = 1483809, XrefRangeEnd = 1483810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WeakRefTracker_EntityManagement(WeakRefTracker weakRefTracker)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &weakRefTracker;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr__ctor_Public_Void_WeakRefTracker_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1622463, RefRangeEnd = 1622465, XrefRangeStart = 1622459, XrefRangeEnd = 1622463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateEntity(
      NetworkId networkId,
      Entity entity,
      NetworkSnapshotType snapshotType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr_CreateEntity_Public_Void_NetworkId_Entity_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1622466, RefRangeEnd = 1622467, XrefRangeStart = 1622465, XrefRangeEnd = 1622466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyEntity(NetworkId networkId, NetworkSnapshotType snapshotType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr_DestroyEntity_Public_Void_NetworkId_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1624209, RefRangeEnd = 1624210, XrefRangeStart = 1622467, XrefRangeEnd = 1624209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateEntity_Generated(NetworkId networkId, NetworkSnapshotType snapshotType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr_CreateEntity_Generated_Private_Void_NetworkId_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1625282, RefRangeEnd = 1625283, XrefRangeStart = 1624210, XrefRangeEnd = 1625282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyEntity_Generated(
      NetworkId networkId,
      NetworkSnapshotType snapshotType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakRefTracker_EntityManagement.NativeMethodInfoPtr_DestroyEntity_Generated_Private_Void_NetworkId_NetworkSnapshotType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WeakRefTracker_EntityManagement()
    {
      Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (WeakRefTracker_EntityManagement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr);
      WeakRefTracker_EntityManagement.NativeFieldInfoPtr_WeakRefTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, nameof (WeakRefTracker));
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr_RemoveBufferWeakRef_Private_Void_NetworkId_WeakRefFieldId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665768);
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr_RemoveComponentWeakRef_Private_Void_NetworkId_WeakRefFieldId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665769);
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr_TryRemoveWeakRef_Private_Boolean_WeakRefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665770);
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr__ctor_Public_Void_WeakRefTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665771);
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr_CreateEntity_Public_Void_NetworkId_Entity_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665772);
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr_DestroyEntity_Public_Void_NetworkId_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665773);
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr_CreateEntity_Generated_Private_Void_NetworkId_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665774);
      WeakRefTracker_EntityManagement.NativeMethodInfoPtr_DestroyEntity_Generated_Private_Void_NetworkId_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, 100665775);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeakRefTracker_EntityManagement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
