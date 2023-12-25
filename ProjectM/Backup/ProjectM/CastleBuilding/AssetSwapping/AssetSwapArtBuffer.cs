// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.AssetSwapping.AssetSwapArtBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.AssetSwapping
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AssetSwapArtBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetSwapConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_RenderMeshEntity;
    [FieldOffset(0)]
    public BlobAssetReference<ProjectM.CastleBuilding.AssetSwapping.AssetSwapConfig> AssetSwapConfig;
    [FieldOffset(8)]
    public Entity RenderMeshEntity;

    static AssetSwapArtBuffer()
    {
      Il2CppClassPointerStore<AssetSwapArtBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.AssetSwapping", nameof (AssetSwapArtBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapArtBuffer>.NativeClassPtr);
      AssetSwapArtBuffer.NativeFieldInfoPtr_AssetSwapConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapArtBuffer>.NativeClassPtr, nameof (AssetSwapConfig));
      AssetSwapArtBuffer.NativeFieldInfoPtr_RenderMeshEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapArtBuffer>.NativeClassPtr, nameof (RenderMeshEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapArtBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
