// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModAsset
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
namespace ProjectM.Shared
{
  public class SpellModAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Values;
    private static readonly IntPtr NativeFieldInfoPtr_UniqueFlags;
    private static readonly IntPtr NativeFieldInfoPtr_Description;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModBlob_0;
    private static readonly IntPtr NativeMethodInfoPtr_BuildUIBlob_Public_BlobAssetReference_1_SpellModBlob_UI_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 748888, RefRangeEnd = 748893, XrefRangeStart = 748888, XrefRangeEnd = 748893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798536, RefRangeEnd = 798537, XrefRangeStart = 798518, XrefRangeEnd = 798536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<SpellModBlob> BuildBlob()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<SpellModBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798563, RefRangeEnd = 798564, XrefRangeStart = 798537, XrefRangeEnd = 798563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<SpellModBlob_UI> BuildUIBlob()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModAsset.NativeMethodInfoPtr_BuildUIBlob_Public_BlobAssetReference_1_SpellModBlob_UI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<SpellModBlob_UI>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798564, XrefRangeEnd = 798574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModAsset()
    {
      Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr);
      SpellModAsset.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, nameof (Values));
      SpellModAsset.NativeFieldInfoPtr_UniqueFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, nameof (UniqueFlags));
      SpellModAsset.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, nameof (Description));
      SpellModAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, nameof (_Guid));
      SpellModAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, 100670414);
      SpellModAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, 100670415);
      SpellModAsset.NativeMethodInfoPtr_BuildUIBlob_Public_BlobAssetReference_1_SpellModBlob_UI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, 100670416);
      SpellModAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, 100670417);
      SpellModAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModAsset>.NativeClassPtr, 100670418);
    }

    public SpellModAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<SpellModEvaluator> Values
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr_Values));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SpellModEvaluator>) null : new Il2CppReferenceArray<SpellModEvaluator>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModUniqueFlags UniqueFlags
    {
      get
      {
        return *(SpellModUniqueFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr_UniqueFlags));
      }
      [param: In] set
      {
        *(SpellModUniqueFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr_UniqueFlags)) = value;
      }
    }

    public unsafe LocalizationKey Description
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr_Description)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
