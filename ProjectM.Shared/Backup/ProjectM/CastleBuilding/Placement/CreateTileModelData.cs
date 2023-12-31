// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.CreateTileModelData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromTransformedEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllExistingFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentRootCreateIndex;
    [FieldOffset(0)]
    public Entity Prefab;
    [FieldOffset(8)]
    public Translation Translation;
    [FieldOffset(20)]
    public Rotation Rotation;
    [FieldOffset(36)]
    public Entity FromTransformedEntity;
    [FieldOffset(44)]
    public BoundsMinMax LocalBounds;
    [FieldOffset(60)]
    public BoundsMinMax WorldBounds;
    [FieldOffset(80)]
    public PlacementTypeData MatchingFlags;
    [FieldOffset(120)]
    public PlacementTypeData AllExistingFlags;
    [FieldOffset(160)]
    public Entity CastleTerritoryConnection;
    [FieldOffset(168)]
    public Entity CastleHeartConnection;
    [FieldOffset(176)]
    public Nullable_Unboxed<int> ParentRootCreateIndex;

    static CreateTileModelData()
    {
      Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (CreateTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr);
      CreateTileModelData.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (Prefab));
      CreateTileModelData.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (Translation));
      CreateTileModelData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (Rotation));
      CreateTileModelData.NativeFieldInfoPtr_FromTransformedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (FromTransformedEntity));
      CreateTileModelData.NativeFieldInfoPtr_LocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (LocalBounds));
      CreateTileModelData.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (WorldBounds));
      CreateTileModelData.NativeFieldInfoPtr_MatchingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (MatchingFlags));
      CreateTileModelData.NativeFieldInfoPtr_AllExistingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (AllExistingFlags));
      CreateTileModelData.NativeFieldInfoPtr_CastleTerritoryConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (CastleTerritoryConnection));
      CreateTileModelData.NativeFieldInfoPtr_CastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (CastleHeartConnection));
      CreateTileModelData.NativeFieldInfoPtr_ParentRootCreateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, nameof (ParentRootCreateIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
