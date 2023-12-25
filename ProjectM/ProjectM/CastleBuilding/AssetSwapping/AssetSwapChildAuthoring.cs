// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.AssetSwapping.AssetSwapChildAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding.AssetSwapping
{
  public class AssetSwapChildAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EnableFlags;
    private static readonly IntPtr NativeFieldInfoPtr_DisableFlags;
    private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136950, XrefRangeEnd = 1136965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValidate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwapChildAuthoring.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetSwapChildAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwapChildAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwapChildAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AssetSwapChildAuthoring()
    {
      Il2CppClassPointerStore<AssetSwapChildAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.AssetSwapping", nameof (AssetSwapChildAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapChildAuthoring>.NativeClassPtr);
      AssetSwapChildAuthoring.NativeFieldInfoPtr_EnableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapChildAuthoring>.NativeClassPtr, nameof (EnableFlags));
      AssetSwapChildAuthoring.NativeFieldInfoPtr_DisableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapChildAuthoring>.NativeClassPtr, nameof (DisableFlags));
      AssetSwapChildAuthoring.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapChildAuthoring>.NativeClassPtr, 100690023);
      AssetSwapChildAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapChildAuthoring>.NativeClassPtr, 100690024);
    }

    public AssetSwapChildAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AssetSwapFlags EnableFlags
    {
      get
      {
        return *(AssetSwapFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapChildAuthoring.NativeFieldInfoPtr_EnableFlags));
      }
      [param: In] set
      {
        *(AssetSwapFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapChildAuthoring.NativeFieldInfoPtr_EnableFlags)) = value;
      }
    }

    public unsafe AssetSwapFlags DisableFlags
    {
      get
      {
        return *(AssetSwapFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapChildAuthoring.NativeFieldInfoPtr_DisableFlags));
      }
      [param: In] set
      {
        *(AssetSwapFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapChildAuthoring.NativeFieldInfoPtr_DisableFlags)) = value;
      }
    }
  }
}
