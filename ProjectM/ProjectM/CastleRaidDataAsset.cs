// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleRaidDataAsset
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
  public class CastleRaidDataAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedItemCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRaidLevel;
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRaidDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRaidDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989301, XrefRangeEnd = 989355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRaidDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnBeforeSerialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRaidDataAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAfterDeserialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRaidDataAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleRaidDataAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRaidDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleRaidDataAsset()
    {
      Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CastleRaidDataAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr);
      CastleRaidDataAsset.NativeFieldInfoPtr_ItemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, nameof (ItemCost));
      CastleRaidDataAsset.NativeFieldInfoPtr_SharedItemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, nameof (SharedItemCost));
      CastleRaidDataAsset.NativeFieldInfoPtr_CastleRaidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, nameof (CastleRaidLevel));
      CastleRaidDataAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, nameof (_Guid));
      CastleRaidDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, 100676342);
      CastleRaidDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, 100676343);
      CastleRaidDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, 100676344);
      CastleRaidDataAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, 100676345);
      CastleRaidDataAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, 100676346);
      CastleRaidDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, 100676347);
    }

    public CastleRaidDataAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<CastleRaidDataAsset.CastleRaidRequirement> ItemCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr_ItemCost));
        return pointer == System.IntPtr.Zero ? (List<CastleRaidDataAsset.CastleRaidRequirement>) null : new List<CastleRaidDataAsset.CastleRaidRequirement>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr_ItemCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SharedItemRequirementAsset> SharedItemCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr_SharedItemCost));
        return pointer == System.IntPtr.Zero ? (List<SharedItemRequirementAsset>) null : new List<SharedItemRequirementAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr_SharedItemCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int CastleRaidLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr_CastleRaidLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr_CastleRaidLevel)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public sealed class CastleRaidRequirement : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static CastleRaidRequirement()
      {
        Il2CppClassPointerStore<CastleRaidDataAsset.CastleRaidRequirement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRaidDataAsset>.NativeClassPtr, nameof (CastleRaidRequirement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRaidDataAsset.CastleRaidRequirement>.NativeClassPtr);
        CastleRaidDataAsset.CastleRaidRequirement.NativeFieldInfoPtr_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidDataAsset.CastleRaidRequirement>.NativeClassPtr, nameof (ItemPrefab));
        CastleRaidDataAsset.CastleRaidRequirement.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRaidDataAsset.CastleRaidRequirement>.NativeClassPtr, nameof (Amount));
      }

      public CastleRaidRequirement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public CastleRaidRequirement()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CastleRaidDataAsset.CastleRaidRequirement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRaidDataAsset.CastleRaidRequirement>.NativeClassPtr, data));
      }

      public unsafe WeakAssetReference<ItemDataComponent> ItemPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.CastleRaidRequirement.NativeFieldInfoPtr_ItemPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.CastleRaidRequirement.NativeFieldInfoPtr_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.CastleRaidRequirement.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRaidDataAsset.CastleRaidRequirement.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }
  }
}
