// Decompiled with JetBrains decompiler
// Type: ProjectM.LegendaryItemAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class LegendaryItemAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_PrefixNameGeneratorAsset;
    private static readonly IntPtr NativeFieldInfoPtr_PostfixNameGeneratorAsset;
    private static readonly IntPtr NativeFieldInfoPtr_TierIndex;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038516, XrefRangeEnd = 1038534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(LegendaryItemAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038534, XrefRangeEnd = 1038544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LegendaryItemAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LegendaryItemAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LegendaryItemAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LegendaryItemAuthoring()
    {
      Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LegendaryItemAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr);
      LegendaryItemAuthoring.NativeFieldInfoPtr_PrefixNameGeneratorAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr, nameof (PrefixNameGeneratorAsset));
      LegendaryItemAuthoring.NativeFieldInfoPtr_PostfixNameGeneratorAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr, nameof (PostfixNameGeneratorAsset));
      LegendaryItemAuthoring.NativeFieldInfoPtr_TierIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr, nameof (TierIndex));
      LegendaryItemAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr, 100681290);
      LegendaryItemAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr, 100681291);
      LegendaryItemAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegendaryItemAuthoring>.NativeClassPtr, 100681292);
    }

    public LegendaryItemAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<NameGeneratorSourceAsset> PrefixNameGeneratorAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAuthoring.NativeFieldInfoPtr_PrefixNameGeneratorAsset));
        return pointer == IntPtr.Zero ? (WeakAssetReference<NameGeneratorSourceAsset>) null : new WeakAssetReference<NameGeneratorSourceAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAuthoring.NativeFieldInfoPtr_PrefixNameGeneratorAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<NameGeneratorSourceAsset> PostfixNameGeneratorAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAuthoring.NativeFieldInfoPtr_PostfixNameGeneratorAsset));
        return pointer == IntPtr.Zero ? (WeakAssetReference<NameGeneratorSourceAsset>) null : new WeakAssetReference<NameGeneratorSourceAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAuthoring.NativeFieldInfoPtr_PostfixNameGeneratorAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int TierIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAuthoring.NativeFieldInfoPtr_TierIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAuthoring.NativeFieldInfoPtr_TierIndex)) = value;
      }
    }
  }
}
