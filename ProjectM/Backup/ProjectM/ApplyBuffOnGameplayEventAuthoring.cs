// Decompiled with JetBrains decompiler
// Type: ProjectM.ApplyBuffOnGameplayEventAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ApplyBuffOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HitEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buffs;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeIfAlreadyExists;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeGameplayEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeConditional;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007777, XrefRangeEnd = 1007780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    public virtual unsafe IEnumerable<GameplayEventIdSource> GameplayEventIds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007780, XrefRangeEnd = 1007783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<GameplayEventIdSource>) null : new IEnumerable<GameplayEventIdSource>(pointer);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007783, XrefRangeEnd = 1007831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007831, XrefRangeEnd = 1007845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetHeaderName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007845, XrefRangeEnd = 1007846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ApplyBuffOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ApplyBuffOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ApplyBuffOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr);
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_HitEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (HitEventId));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (Buffs));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (BuffTarget));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellTarget));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (EntityOwner));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_OverrideDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (OverrideDuration));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (Duration));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (Stacks));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellMods));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeIfAlreadyExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (ConsumeIfAlreadyExists));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeGameplayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (ConsumeGameplayEvent));
      ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeConditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (ConsumeConditional));
      ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678239);
      ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678240);
      ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678241);
      ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678242);
      ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678243);
      ApplyBuffOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678244);
    }

    public ApplyBuffOnGameplayEventAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int HitEventId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_HitEventId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_HitEventId)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ApplyBuffOnGameplayEventAuthoring.BuffsArray Buffs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Buffs));
        return pointer == System.IntPtr.Zero ? (ApplyBuffOnGameplayEventAuthoring.BuffsArray) null : new ApplyBuffOnGameplayEventAuthoring.BuffsArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Buffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ApplyBuffTarget BuffTarget
    {
      get
      {
        return *(ApplyBuffTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffTarget));
      }
      [param: In] set
      {
        *(ApplyBuffTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffTarget)) = value;
      }
    }

    public unsafe SetSpellTarget SpellTarget
    {
      get
      {
        return *(SetSpellTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellTarget));
      }
      [param: In] set
      {
        *(SetSpellTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellTarget)) = value;
      }
    }

    public unsafe SetEntityOwner EntityOwner
    {
      get
      {
        return *(SetEntityOwner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_EntityOwner));
      }
      [param: In] set
      {
        *(SetEntityOwner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_EntityOwner)) = value;
      }
    }

    public unsafe bool OverrideDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_OverrideDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_OverrideDuration)) = value;
      }
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe byte Stacks
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Stacks));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Stacks)) = value;
      }
    }

    public ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods);
        return new ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool ConsumeIfAlreadyExists
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeIfAlreadyExists));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeIfAlreadyExists)) = value;
      }
    }

    public GameplayEventIdSource ConsumeGameplayEvent
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeGameplayEvent);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeGameplayEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent ConsumeConditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeConditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_ConsumeConditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class BuffsArray : ReorderableArray<ApplyBuffOnGameplayEventEntry_Editor>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007774, XrefRangeEnd = 1007777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BuffsArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ApplyBuffOnGameplayEventAuthoring.BuffsArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuffsArray()
      {
        Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (BuffsArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr);
        ApplyBuffOnGameplayEventAuthoring.BuffsArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr, 100678245);
      }

      public BuffsArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
      private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
      private static readonly System.IntPtr NativeFieldInfoPtr_Buffs;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr);
        ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (Duration));
        ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (Stacks));
        ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (Buffs));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Duration
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Stacks
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Stacks));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Stacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModPrefabGuidSettings> Buffs
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Buffs));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModPrefabGuidSettings>) null : new Il2CppReferenceArray<SpellModPrefabGuidSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApplyBuffOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Buffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
