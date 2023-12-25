// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.AssetSwapping.AssetSwappableAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.AssetSwapping
{
  public class AssetSwappableAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_ConvertBlobConfig_Private_BlobAssetReference_1_AssetSwapConfig_Il2CppReferenceArray_1_AssetSwapChildAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136965, XrefRangeEnd = 1137040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AssetSwappableAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1137057, RefRangeEnd = 1137058, XrefRangeStart = 1137040, XrefRangeEnd = 1137057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<AssetSwapConfig> ConvertBlobConfig(
      Il2CppReferenceArray<AssetSwapChildAuthoring> assetSwapConfigs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assetSwapConfigs);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwappableAuthoring.NativeMethodInfoPtr_ConvertBlobConfig_Private_BlobAssetReference_1_AssetSwapConfig_Il2CppReferenceArray_1_AssetSwapChildAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<AssetSwapConfig>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetSwappableAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwappableAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwappableAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AssetSwappableAuthoring()
    {
      Il2CppClassPointerStore<AssetSwappableAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.AssetSwapping", nameof (AssetSwappableAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwappableAuthoring>.NativeClassPtr);
      AssetSwappableAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappableAuthoring>.NativeClassPtr, 100690025);
      AssetSwappableAuthoring.NativeMethodInfoPtr_ConvertBlobConfig_Private_BlobAssetReference_1_AssetSwapConfig_Il2CppReferenceArray_1_AssetSwapChildAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappableAuthoring>.NativeClassPtr, 100690026);
      AssetSwappableAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappableAuthoring>.NativeClassPtr, 100690027);
    }

    public AssetSwappableAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
