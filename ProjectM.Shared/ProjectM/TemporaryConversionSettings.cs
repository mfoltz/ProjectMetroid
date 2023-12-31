// Decompiled with JetBrains decompiler
// Type: ProjectM.TemporaryConversionSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TemporaryConversionSettings : GameObjectConversionSettings
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_World_ConversionFlags_BlobAssetStore_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762072, XrefRangeEnd = 762073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TemporaryConversionSettings(
      World destinationWorld,
      GameObjectConversionUtility.ConversionFlags conversionFlags,
      BlobAssetStore blobAssetStore)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemporaryConversionSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destinationWorld);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &conversionFlags;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blobAssetStore);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TemporaryConversionSettings.NativeMethodInfoPtr__ctor_Public_Void_World_ConversionFlags_BlobAssetStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TemporaryConversionSettings()
    {
      Il2CppClassPointerStore<TemporaryConversionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TemporaryConversionSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporaryConversionSettings>.NativeClassPtr);
      TemporaryConversionSettings.NativeMethodInfoPtr__ctor_Public_Void_World_ConversionFlags_BlobAssetStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporaryConversionSettings>.NativeClassPtr, 100667327);
    }

    public TemporaryConversionSettings(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
