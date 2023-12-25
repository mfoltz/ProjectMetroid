// Decompiled with JetBrains decompiler
// Type: ProjectM.DoorAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DoorAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OpenDoorLeft;
    private static readonly IntPtr NativeFieldInfoPtr_OpenDoorRight;
    private static readonly IntPtr NativeFieldInfoPtr_ClosedDoor;
    private static readonly IntPtr NativeFieldInfoPtr_AutoCloseTime;
    private static readonly IntPtr NativeFieldInfoPtr_DenyManualCloseDoor;
    private static readonly IntPtr NativeFieldInfoPtr_CanBeOpenedByServant;
    private static readonly IntPtr NativeFieldInfoPtr_OpenLeftDoorSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_CloseLeftDoorSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_OpenRightDoorSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_CloseRightDoorSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_RaidOverrideSequenceField;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986904, XrefRangeEnd = 986947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DoorAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986947, XrefRangeEnd = 986951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DoorAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986951, XrefRangeEnd = 986952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DoorAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DoorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DoorAuthoring()
    {
      Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DoorAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr);
      DoorAuthoring.NativeFieldInfoPtr_OpenDoorLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (OpenDoorLeft));
      DoorAuthoring.NativeFieldInfoPtr_OpenDoorRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (OpenDoorRight));
      DoorAuthoring.NativeFieldInfoPtr_ClosedDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (ClosedDoor));
      DoorAuthoring.NativeFieldInfoPtr_AutoCloseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (AutoCloseTime));
      DoorAuthoring.NativeFieldInfoPtr_DenyManualCloseDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (DenyManualCloseDoor));
      DoorAuthoring.NativeFieldInfoPtr_CanBeOpenedByServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (CanBeOpenedByServant));
      DoorAuthoring.NativeFieldInfoPtr_OpenLeftDoorSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (OpenLeftDoorSequenceField));
      DoorAuthoring.NativeFieldInfoPtr_CloseLeftDoorSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (CloseLeftDoorSequenceField));
      DoorAuthoring.NativeFieldInfoPtr_OpenRightDoorSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (OpenRightDoorSequenceField));
      DoorAuthoring.NativeFieldInfoPtr_CloseRightDoorSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (CloseRightDoorSequenceField));
      DoorAuthoring.NativeFieldInfoPtr_RaidOverrideSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, nameof (RaidOverrideSequenceField));
      DoorAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, 100676123);
      DoorAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, 100676124);
      DoorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorAuthoring>.NativeClassPtr, 100676125);
    }

    public DoorAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject OpenDoorLeft
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenDoorLeft));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenDoorLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject OpenDoorRight
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenDoorRight));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenDoorRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject ClosedDoor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_ClosedDoor));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_ClosedDoor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float AutoCloseTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_AutoCloseTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_AutoCloseTime)) = value;
      }
    }

    public unsafe bool DenyManualCloseDoor
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_DenyManualCloseDoor));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_DenyManualCloseDoor)) = value;
      }
    }

    public unsafe bool CanBeOpenedByServant
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_CanBeOpenedByServant));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_CanBeOpenedByServant)) = value;
      }
    }

    public unsafe SequenceField OpenLeftDoorSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenLeftDoorSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenLeftDoorSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField CloseLeftDoorSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_CloseLeftDoorSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_CloseLeftDoorSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField OpenRightDoorSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenRightDoorSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_OpenRightDoorSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField CloseRightDoorSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_CloseRightDoorSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_CloseRightDoorSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField RaidOverrideSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_RaidOverrideSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DoorAuthoring.NativeFieldInfoPtr_RaidOverrideSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
