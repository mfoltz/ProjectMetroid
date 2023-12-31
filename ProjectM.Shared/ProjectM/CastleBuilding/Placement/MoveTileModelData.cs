// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.MoveTileModelData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MoveTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ExistingEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllExistingFlags;
    [FieldOffset(0)]
    public Entity ExistingEntity;
    [FieldOffset(8)]
    public Translation OldTranslation;
    [FieldOffset(20)]
    public Rotation OldRotation;
    [FieldOffset(36)]
    public Translation NewTranslation;
    [FieldOffset(48)]
    public Rotation NewRotation;
    [FieldOffset(64)]
    public BoundsMinMax LocalBounds;
    [FieldOffset(80)]
    public BoundsMinMax WorldBounds;
    [FieldOffset(96)]
    public PlacementTypeData MatchingFlags;
    [FieldOffset(136)]
    public PlacementTypeData AllExistingFlags;

    static MoveTileModelData()
    {
      Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (MoveTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr);
      MoveTileModelData.NativeFieldInfoPtr_ExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (ExistingEntity));
      MoveTileModelData.NativeFieldInfoPtr_OldTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (OldTranslation));
      MoveTileModelData.NativeFieldInfoPtr_OldRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (OldRotation));
      MoveTileModelData.NativeFieldInfoPtr_NewTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (NewTranslation));
      MoveTileModelData.NativeFieldInfoPtr_NewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (NewRotation));
      MoveTileModelData.NativeFieldInfoPtr_LocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (LocalBounds));
      MoveTileModelData.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (WorldBounds));
      MoveTileModelData.NativeFieldInfoPtr_MatchingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (MatchingFlags));
      MoveTileModelData.NativeFieldInfoPtr_AllExistingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, nameof (AllExistingFlags));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
