// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStormRegion
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.LightningStorm
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningStormRegion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayStrikeTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmbienceStrikeTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_TypeId;
    [FieldOffset(0)]
    public BlobAssetReference<PolygonRegionBlob> Data;
    [FieldOffset(8)]
    public float GameplayStrikeTimer;
    [FieldOffset(12)]
    public float AmbienceStrikeTimer;
    [FieldOffset(16)]
    public PrefabGUID TypeId;

    static LightningStormRegion()
    {
      Il2CppClassPointerStore<LightningStormRegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStormRegion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegion>.NativeClassPtr);
      LightningStormRegion.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegion>.NativeClassPtr, nameof (Data));
      LightningStormRegion.NativeFieldInfoPtr_GameplayStrikeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegion>.NativeClassPtr, nameof (GameplayStrikeTimer));
      LightningStormRegion.NativeFieldInfoPtr_AmbienceStrikeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegion>.NativeClassPtr, nameof (AmbienceStrikeTimer));
      LightningStormRegion.NativeFieldInfoPtr_TypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegion>.NativeClassPtr, nameof (TypeId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegion>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
