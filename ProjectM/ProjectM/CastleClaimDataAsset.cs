// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleClaimDataAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CastleClaimDataAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedItemCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleClaimLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 64928, RefRangeEnd = 64933, XrefRangeStart = 64928, XrefRangeEnd = 64933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleClaimDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 64928, RefRangeEnd = 64933, XrefRangeStart = 64928, XrefRangeEnd = 64933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleClaimDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989193, XrefRangeEnd = 989247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleClaimDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnBeforeSerialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleClaimDataAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAfterDeserialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleClaimDataAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleClaimDataAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleClaimDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleClaimDataAsset()
    {
      Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CastleClaimDataAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr);
      CastleClaimDataAsset.NativeFieldInfoPtr_ItemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, nameof (ItemCost));
      CastleClaimDataAsset.NativeFieldInfoPtr_SharedItemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, nameof (SharedItemCost));
      CastleClaimDataAsset.NativeFieldInfoPtr_CastleClaimLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, nameof (CastleClaimLevel));
      CastleClaimDataAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, nameof (_Guid));
      CastleClaimDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, 100676330);
      CastleClaimDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, 100676331);
      CastleClaimDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, 100676332);
      CastleClaimDataAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, 100676333);
      CastleClaimDataAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, 100676334);
      CastleClaimDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, 100676335);
    }

    public CastleClaimDataAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<CastleClaimDataAsset.CastleClaimRequirement> ItemCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr_ItemCost));
        return pointer == System.IntPtr.Zero ? (List<CastleClaimDataAsset.CastleClaimRequirement>) null : new List<CastleClaimDataAsset.CastleClaimRequirement>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr_ItemCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SharedItemRequirementAsset> SharedItemCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr_SharedItemCost));
        return pointer == System.IntPtr.Zero ? (List<SharedItemRequirementAsset>) null : new List<SharedItemRequirementAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr_SharedItemCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int CastleClaimLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr_CastleClaimLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr_CastleClaimLevel)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public sealed class CastleClaimRequirement : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static CastleClaimRequirement()
      {
        Il2CppClassPointerStore<CastleClaimDataAsset.CastleClaimRequirement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleClaimDataAsset>.NativeClassPtr, nameof (CastleClaimRequirement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleClaimDataAsset.CastleClaimRequirement>.NativeClassPtr);
        CastleClaimDataAsset.CastleClaimRequirement.NativeFieldInfoPtr_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimDataAsset.CastleClaimRequirement>.NativeClassPtr, nameof (ItemPrefab));
        CastleClaimDataAsset.CastleClaimRequirement.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimDataAsset.CastleClaimRequirement>.NativeClassPtr, nameof (Amount));
      }

      public CastleClaimRequirement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public CastleClaimRequirement()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CastleClaimDataAsset.CastleClaimRequirement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleClaimDataAsset.CastleClaimRequirement>.NativeClassPtr, data));
      }

      public unsafe WeakAssetReference<ItemDataComponent> ItemPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.CastleClaimRequirement.NativeFieldInfoPtr_ItemPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.CastleClaimRequirement.NativeFieldInfoPtr_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.CastleClaimRequirement.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleClaimDataAsset.CastleClaimRequirement.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }
  }
}
