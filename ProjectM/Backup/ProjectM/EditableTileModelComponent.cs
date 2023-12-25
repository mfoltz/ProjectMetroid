// Decompiled with JetBrains decompiler
// Type: ProjectM.EditableTileModelComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class EditableTileModelComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IsEditedSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_HoveredCanBeEditedSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_HoveredOnlyDismantleSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_HoveredBlockedSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_RepairingSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_DismantlingSequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_CanRotateDuringBuild;
    private static readonly IntPtr NativeFieldInfoPtr_CanMoveAfterBuild;
    private static readonly IntPtr NativeFieldInfoPtr_CanRotateAfterBuild;
    private static readonly IntPtr NativeFieldInfoPtr_CanDismantle;
    private static readonly IntPtr NativeFieldInfoPtr_DismantleAbility;
    private static readonly IntPtr NativeFieldInfoPtr_PlaceAbility;
    private static readonly IntPtr NativeFieldInfoPtr_RepairAbility;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074002, XrefRangeEnd = 1074037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(EditableTileModelComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074037, XrefRangeEnd = 1074041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EditableTileModelComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074041, XrefRangeEnd = 1074066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Test(TestContext<GameObject> context, List<ContentIssue> issues)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) issues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EditableTileModelComponent.NativeMethodInfoPtr_Test_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074066, XrefRangeEnd = 1074067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EditableTileModelComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EditableTileModelComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EditableTileModelComponent()
    {
      Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EditableTileModelComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr);
      EditableTileModelComponent.NativeFieldInfoPtr_IsEditedSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (IsEditedSequenceField));
      EditableTileModelComponent.NativeFieldInfoPtr_HoveredCanBeEditedSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (HoveredCanBeEditedSequenceField));
      EditableTileModelComponent.NativeFieldInfoPtr_HoveredOnlyDismantleSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (HoveredOnlyDismantleSequenceField));
      EditableTileModelComponent.NativeFieldInfoPtr_HoveredBlockedSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (HoveredBlockedSequenceField));
      EditableTileModelComponent.NativeFieldInfoPtr_RepairingSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (RepairingSequenceField));
      EditableTileModelComponent.NativeFieldInfoPtr_DismantlingSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (DismantlingSequenceField));
      EditableTileModelComponent.NativeFieldInfoPtr_CanRotateDuringBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (CanRotateDuringBuild));
      EditableTileModelComponent.NativeFieldInfoPtr_CanMoveAfterBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (CanMoveAfterBuild));
      EditableTileModelComponent.NativeFieldInfoPtr_CanRotateAfterBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (CanRotateAfterBuild));
      EditableTileModelComponent.NativeFieldInfoPtr_CanDismantle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (CanDismantle));
      EditableTileModelComponent.NativeFieldInfoPtr_DismantleAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (DismantleAbility));
      EditableTileModelComponent.NativeFieldInfoPtr_PlaceAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (PlaceAbility));
      EditableTileModelComponent.NativeFieldInfoPtr_RepairAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, nameof (RepairAbility));
      EditableTileModelComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, 100684625);
      EditableTileModelComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, 100684626);
      EditableTileModelComponent.NativeMethodInfoPtr_Test_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, 100684627);
      EditableTileModelComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditableTileModelComponent>.NativeClassPtr, 100684628);
    }

    public EditableTileModelComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceField IsEditedSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_IsEditedSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_IsEditedSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField HoveredCanBeEditedSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_HoveredCanBeEditedSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_HoveredCanBeEditedSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField HoveredOnlyDismantleSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_HoveredOnlyDismantleSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_HoveredOnlyDismantleSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField HoveredBlockedSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_HoveredBlockedSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_HoveredBlockedSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField RepairingSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_RepairingSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_RepairingSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField DismantlingSequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_DismantlingSequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_DismantlingSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool CanRotateDuringBuild
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanRotateDuringBuild));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanRotateDuringBuild)) = value;
      }
    }

    public unsafe bool CanMoveAfterBuild
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanMoveAfterBuild));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanMoveAfterBuild)) = value;
      }
    }

    public unsafe bool CanRotateAfterBuild
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanRotateAfterBuild));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanRotateAfterBuild)) = value;
      }
    }

    public unsafe bool CanDismantle
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanDismantle));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_CanDismantle)) = value;
      }
    }

    public unsafe PrefabGuidComponent DismantleAbility
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_DismantleAbility));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_DismantleAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent PlaceAbility
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_PlaceAbility));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_PlaceAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent RepairAbility
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_RepairAbility));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditableTileModelComponent.NativeFieldInfoPtr_RepairAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
