// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Malee;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AbilityGroupComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AbilityCastConditions;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Description;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_AbilitySlotPrefabs;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724722, XrefRangeEnd = 724728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityGroupComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724728, XrefRangeEnd = 724743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityGroupComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724743, XrefRangeEnd = 724749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityGroupComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityGroupComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityGroupComponent()
    {
      Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityGroupComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr);
      AbilityGroupComponent.NativeFieldInfoPtr_AbilityCastConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, nameof (AbilityCastConditions));
      AbilityGroupComponent.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, nameof (Name));
      AbilityGroupComponent.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, nameof (Description));
      AbilityGroupComponent.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, nameof (Icon));
      AbilityGroupComponent.NativeFieldInfoPtr_AbilitySlotPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, nameof (AbilitySlotPrefabs));
      AbilityGroupComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, 100664114);
      AbilityGroupComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, 100664115);
      AbilityGroupComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, 100664116);
    }

    public AbilityGroupComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<AbilityCastCondition_Editor> AbilityCastConditions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_AbilityCastConditions));
        return pointer == IntPtr.Zero ? (List<AbilityCastCondition_Editor>) null : new List<AbilityCastCondition_Editor>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_AbilityCastConditions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizedStringBuilder Description
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_Description));
        return pointer == IntPtr.Zero ? (LocalizedStringBuilder) null : new LocalizedStringBuilder(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityGroupComponent.WeakAbilitiesArray AbilitySlotPrefabs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_AbilitySlotPrefabs));
        return pointer == IntPtr.Zero ? (AbilityGroupComponent.WeakAbilitiesArray) null : new AbilityGroupComponent.WeakAbilitiesArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupComponent.NativeFieldInfoPtr_AbilitySlotPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class AbilitiesArray : ReorderableArray<AbilityComponent>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724715, XrefRangeEnd = 724718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilitiesArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityGroupComponent.AbilitiesArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityGroupComponent.AbilitiesArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilitiesArray()
      {
        Il2CppClassPointerStore<AbilityGroupComponent.AbilitiesArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, nameof (AbilitiesArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupComponent.AbilitiesArray>.NativeClassPtr);
        AbilityGroupComponent.AbilitiesArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupComponent.AbilitiesArray>.NativeClassPtr, 100664117);
      }

      public AbilitiesArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class WeakAbilitiesArray : ReorderableArray<WeakAssetReference<AbilityComponent>>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 724721, RefRangeEnd = 724722, XrefRangeStart = 724718, XrefRangeEnd = 724721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe WeakAbilitiesArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityGroupComponent.WeakAbilitiesArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityGroupComponent.WeakAbilitiesArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static WeakAbilitiesArray()
      {
        Il2CppClassPointerStore<AbilityGroupComponent.WeakAbilitiesArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityGroupComponent>.NativeClassPtr, nameof (WeakAbilitiesArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupComponent.WeakAbilitiesArray>.NativeClassPtr);
        AbilityGroupComponent.WeakAbilitiesArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupComponent.WeakAbilitiesArray>.NativeClassPtr, 100664118);
      }

      public WeakAbilitiesArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
