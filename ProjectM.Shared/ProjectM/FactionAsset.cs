// Decompiled with JetBrains decompiler
// Type: ProjectM.FactionAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class FactionAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Membership;
    private static readonly IntPtr NativeFieldInfoPtr_Friendly;
    private static readonly IntPtr NativeFieldInfoPtr_Neutral;
    private static readonly IntPtr NativeFieldInfoPtr_Hostile;
    private static readonly IntPtr NativeFieldInfoPtr_AggroMultipliers;
    private static readonly IntPtr NativeFieldInfoPtr_FactionCollection;
    private static readonly IntPtr NativeFieldInfoPtr_CollectionIndex;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723070, XrefRangeEnd = 723071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(FactionAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723071, XrefRangeEnd = 723110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FactionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FactionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FactionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FactionAsset()
    {
      Il2CppClassPointerStore<FactionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FactionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr);
      FactionAsset.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (Name));
      FactionAsset.NativeFieldInfoPtr_Membership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (Membership));
      FactionAsset.NativeFieldInfoPtr_Friendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (Friendly));
      FactionAsset.NativeFieldInfoPtr_Neutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (Neutral));
      FactionAsset.NativeFieldInfoPtr_Hostile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (Hostile));
      FactionAsset.NativeFieldInfoPtr_AggroMultipliers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (AggroMultipliers));
      FactionAsset.NativeFieldInfoPtr_FactionCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (FactionCollection));
      FactionAsset.NativeFieldInfoPtr_CollectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (CollectionIndex));
      FactionAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, nameof (_Guid));
      FactionAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, 100663902);
      FactionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, 100663903);
      FactionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactionAsset>.NativeClassPtr, 100663904);
    }

    public FactionAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe FactionEnum Membership
    {
      get
      {
        return *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Membership));
      }
      [param: In] set
      {
        *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Membership)) = value;
      }
    }

    public unsafe FactionEnum Friendly
    {
      get
      {
        return *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Friendly));
      }
      [param: In] set
      {
        *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Friendly)) = value;
      }
    }

    public unsafe FactionEnum Neutral
    {
      get
      {
        return *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Neutral));
      }
      [param: In] set
      {
        *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Neutral)) = value;
      }
    }

    public unsafe FactionEnum Hostile
    {
      get
      {
        return *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Hostile));
      }
      [param: In] set
      {
        *(FactionEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_Hostile)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<AggroFactionMultiplier_Editor> AggroMultipliers
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_AggroMultipliers));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<AggroFactionMultiplier_Editor>) null : new Il2CppReferenceArray<AggroFactionMultiplier_Editor>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_AggroMultipliers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FactionCollectionAsset FactionCollection
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_FactionCollection));
        return pointer == IntPtr.Zero ? (FactionCollectionAsset) null : new FactionCollectionAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_FactionCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int CollectionIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_CollectionIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr_CollectionIndex)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FactionAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
