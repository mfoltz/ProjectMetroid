// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStormTypeCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.LightningStorm
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningStormTypeCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningStormTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLightningStormType_Public_Boolean_PrefabGUID_byref_BlobAssetReference_1_LightningStormTypeBlob_0;
    [FieldOffset(0)]
    public NativeHashMap<PrefabGUID, BlobAssetReference<LightningStormTypeBlob>> LightningStormTypes;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116869, RefRangeEnd = 1116870, XrefRangeStart = 1116866, XrefRangeEnd = 1116869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetLightningStormType(
      PrefabGUID id,
      out BlobAssetReference<LightningStormTypeBlob> type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormTypeCollection.NativeMethodInfoPtr_TryGetLightningStormType_Public_Boolean_PrefabGUID_byref_BlobAssetReference_1_LightningStormTypeBlob_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static LightningStormTypeCollection()
    {
      Il2CppClassPointerStore<LightningStormTypeCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStormTypeCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormTypeCollection>.NativeClassPtr);
      LightningStormTypeCollection.NativeFieldInfoPtr_LightningStormTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeCollection>.NativeClassPtr, nameof (LightningStormTypes));
      LightningStormTypeCollection.NativeMethodInfoPtr_TryGetLightningStormType_Public_Boolean_PrefabGUID_byref_BlobAssetReference_1_LightningStormTypeBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormTypeCollection>.NativeClassPtr, 100688510);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormTypeCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
