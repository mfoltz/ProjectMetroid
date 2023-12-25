// Decompiled with JetBrains decompiler
// Type: ProjectM.StatModAssetAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class StatModAssetAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ItemAsset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetAbilityModsGenerator_Private_Void_byref_BlobAssetReference_1_SpellModSetGeneratorBlob_ReplaceAbilityOnSlotBuff_Editor_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039266, XrefRangeEnd = 1039285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(StatModAssetAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1039290, RefRangeEnd = 1039292, XrefRangeStart = 1039285, XrefRangeEnd = 1039290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityModsGenerator(
      ref BlobAssetReference<SpellModSetGeneratorBlob> generator,
      ReplaceAbilityOnSlotBuff_Editor replaceAbilityOnSlot)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref generator;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) replaceAbilityOnSlot));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatModAssetAuthoring.NativeMethodInfoPtr_SetAbilityModsGenerator_Private_Void_byref_BlobAssetReference_1_SpellModSetGeneratorBlob_ReplaceAbilityOnSlotBuff_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039292, XrefRangeEnd = 1039296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatModAssetAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatModAssetAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatModAssetAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StatModAssetAuthoring()
    {
      Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StatModAssetAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr);
      StatModAssetAuthoring.NativeFieldInfoPtr_ItemAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr, nameof (ItemAsset));
      StatModAssetAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr, 100681375);
      StatModAssetAuthoring.NativeMethodInfoPtr_SetAbilityModsGenerator_Private_Void_byref_BlobAssetReference_1_SpellModSetGeneratorBlob_ReplaceAbilityOnSlotBuff_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr, 100681376);
      StatModAssetAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr, 100681377);
      StatModAssetAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatModAssetAuthoring>.NativeClassPtr, 100681378);
    }

    public StatModAssetAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LegendaryItemAsset ItemAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatModAssetAuthoring.NativeFieldInfoPtr_ItemAsset));
        return pointer == IntPtr.Zero ? (LegendaryItemAsset) null : new LegendaryItemAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatModAssetAuthoring.NativeFieldInfoPtr_ItemAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
