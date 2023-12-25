// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipmentSetAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Malee;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class EquipmentSetAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ItemSetName;
    private static readonly IntPtr NativeFieldInfoPtr_ItemsInSet;
    private static readonly IntPtr NativeFieldInfoPtr_Settings;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 748888, RefRangeEnd = 748893, XrefRangeStart = 748888, XrefRangeEnd = 748893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipmentSetAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067313, XrefRangeEnd = 1067376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquipmentSetAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EquipmentSetAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquipmentSetAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EquipmentSetAsset()
    {
      Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquipmentSetAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr);
      EquipmentSetAsset.NativeFieldInfoPtr_ItemSetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, nameof (ItemSetName));
      EquipmentSetAsset.NativeFieldInfoPtr_ItemsInSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, nameof (ItemsInSet));
      EquipmentSetAsset.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, nameof (Settings));
      EquipmentSetAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, nameof (_Guid));
      EquipmentSetAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, 100683958);
      EquipmentSetAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, 100683959);
      EquipmentSetAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, 100683960);
    }

    public EquipmentSetAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey ItemSetName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr_ItemSetName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr_ItemSetName)) = value;
      }
    }

    public unsafe List<PrefabGuidComponent> ItemsInSet
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr_ItemsInSet));
        return pointer == IntPtr.Zero ? (List<PrefabGuidComponent>) null : new List<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr_ItemsInSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EquipmentSetAsset.EquipmentSetBuffs Settings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr_Settings));
        return pointer == IntPtr.Zero ? (EquipmentSetAsset.EquipmentSetBuffs) null : new EquipmentSetAsset.EquipmentSetBuffs(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public class EquipmentSetBuffs : ReorderableArray<EquipmentSetElements_Editor>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067310, XrefRangeEnd = 1067313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EquipmentSetBuffs()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipmentSetAsset.EquipmentSetBuffs>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipmentSetAsset.EquipmentSetBuffs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EquipmentSetBuffs()
      {
        Il2CppClassPointerStore<EquipmentSetAsset.EquipmentSetBuffs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipmentSetAsset>.NativeClassPtr, nameof (EquipmentSetBuffs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentSetAsset.EquipmentSetBuffs>.NativeClassPtr);
        EquipmentSetAsset.EquipmentSetBuffs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipmentSetAsset.EquipmentSetBuffs>.NativeClassPtr, 100683961);
      }

      public EquipmentSetBuffs(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
