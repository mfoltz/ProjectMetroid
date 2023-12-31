// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UnitBloodType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class UnitBloodType : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buffs;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(14), CachedScanResults(RefRangeStart = 466385, RefRangeEnd = 466399, XrefRangeStart = 466385, XrefRangeEnd = 466399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitBloodType.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794532, XrefRangeEnd = 794570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitBloodType.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 466385, RefRangeEnd = 466399, XrefRangeStart = 466385, XrefRangeEnd = 466399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitBloodType.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitBloodType()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitBloodType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitBloodType()
    {
      Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (UnitBloodType));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr);
      UnitBloodType.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, nameof (_Guid));
      UnitBloodType.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, nameof (Name));
      UnitBloodType.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, nameof (Icon));
      UnitBloodType.NativeFieldInfoPtr_Icon2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, nameof (Icon2));
      UnitBloodType.NativeFieldInfoPtr_Buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, nameof (Buffs));
      UnitBloodType.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, 100670062);
      UnitBloodType.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, 100670063);
      UnitBloodType.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, 100670064);
      UnitBloodType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, 100670065);
    }

    public UnitBloodType(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Icon2));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Icon2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<UnitBloodType.BloodTypeBuff> Buffs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Buffs));
        return pointer == System.IntPtr.Zero ? (List<UnitBloodType.BloodTypeBuff>) null : new List<UnitBloodType.BloodTypeBuff>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.NativeFieldInfoPtr_Buffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class BloodTypeBuff : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MinQuality;
      private static readonly System.IntPtr NativeFieldInfoPtr_Buff;

      static BloodTypeBuff()
      {
        Il2CppClassPointerStore<UnitBloodType.BloodTypeBuff>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitBloodType>.NativeClassPtr, nameof (BloodTypeBuff));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitBloodType.BloodTypeBuff>.NativeClassPtr);
        UnitBloodType.BloodTypeBuff.NativeFieldInfoPtr_MinQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodType.BloodTypeBuff>.NativeClassPtr, nameof (MinQuality));
        UnitBloodType.BloodTypeBuff.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodType.BloodTypeBuff>.NativeClassPtr, nameof (Buff));
      }

      public BloodTypeBuff(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BloodTypeBuff()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnitBloodType.BloodTypeBuff>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitBloodType.BloodTypeBuff>.NativeClassPtr, data));
      }

      public unsafe float MinQuality
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.BloodTypeBuff.NativeFieldInfoPtr_MinQuality));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.BloodTypeBuff.NativeFieldInfoPtr_MinQuality)) = value;
        }
      }

      public unsafe PrefabGuidComponent Buff
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.BloodTypeBuff.NativeFieldInfoPtr_Buff));
          return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodType.BloodTypeBuff.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
