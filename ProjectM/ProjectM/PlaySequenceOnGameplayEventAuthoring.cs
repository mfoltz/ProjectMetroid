﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.PlaySequenceOnGameplayEventAuthoring
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

#nullable disable
namespace ProjectM
{
  public class PlaySequenceOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly IntPtr NativeFieldInfoPtr_SequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_SequencePosition;
    private static readonly IntPtr NativeFieldInfoPtr_SequenceRotation;
    private static readonly IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 56402, RefRangeEnd = 56403, XrefRangeStart = 56402, XrefRangeEnd = 56403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlaySequenceOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008249, XrefRangeEnd = 1008257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PlaySequenceOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlaySequenceOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySequenceOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlaySequenceOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlaySequenceOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr);
      PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr, nameof (SequenceField));
      PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequencePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr, nameof (SequencePosition));
      PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr, nameof (SequenceRotation));
      PlaySequenceOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr, 100678323);
      PlaySequenceOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr, 100678324);
      PlaySequenceOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceOnGameplayEventAuthoring>.NativeClassPtr, 100678325);
    }

    public PlaySequenceOnGameplayEventAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField SequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlaySequenceOnGameplayEventTarget SequencePosition
    {
      get
      {
        return *(PlaySequenceOnGameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequencePosition));
      }
      [param: In] set
      {
        *(PlaySequenceOnGameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequencePosition)) = value;
      }
    }

    public unsafe PlaySequenceOnGameplayEventTarget SequenceRotation
    {
      get
      {
        return *(PlaySequenceOnGameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceRotation));
      }
      [param: In] set
      {
        *(PlaySequenceOnGameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnGameplayEventAuthoring.NativeFieldInfoPtr_SequenceRotation)) = value;
      }
    }
  }
}
