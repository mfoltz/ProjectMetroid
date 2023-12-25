// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.AssetSwapping.AssetSwapConfig
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.AssetSwapping
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AssetSwapConfig
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AlternativeConfigs;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldEnable_Public_Boolean_AssetSwapFlags_0;
    [FieldOffset(0)]
    public BlobArray<AssetSwapConfig.ConfigEntry> AlternativeConfigs;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1137062, RefRangeEnd = 1137066, XrefRangeStart = 1137058, XrefRangeEnd = 1137062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldEnable(AssetSwapFlags state)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapConfig.NativeMethodInfoPtr_ShouldEnable_Public_Boolean_AssetSwapFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AssetSwapConfig()
    {
      Il2CppClassPointerStore<AssetSwapConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.AssetSwapping", nameof (AssetSwapConfig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapConfig>.NativeClassPtr);
      AssetSwapConfig.NativeFieldInfoPtr_AlternativeConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapConfig>.NativeClassPtr, nameof (AlternativeConfigs));
      AssetSwapConfig.NativeMethodInfoPtr_ShouldEnable_Public_Boolean_AssetSwapFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapConfig>.NativeClassPtr, 100690031);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapConfig>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ConfigEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EnableFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_DisableFlags;
      [FieldOffset(0)]
      public AssetSwapFlags EnableFlags;
      [FieldOffset(1)]
      public AssetSwapFlags DisableFlags;

      static ConfigEntry()
      {
        Il2CppClassPointerStore<AssetSwapConfig.ConfigEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapConfig>.NativeClassPtr, nameof (ConfigEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapConfig.ConfigEntry>.NativeClassPtr);
        AssetSwapConfig.ConfigEntry.NativeFieldInfoPtr_EnableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapConfig.ConfigEntry>.NativeClassPtr, nameof (EnableFlags));
        AssetSwapConfig.ConfigEntry.NativeFieldInfoPtr_DisableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapConfig.ConfigEntry>.NativeClassPtr, nameof (DisableFlags));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapConfig.ConfigEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
