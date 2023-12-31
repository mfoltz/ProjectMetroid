// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.PlacementResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HasResult;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementOperation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeepTeamDuringTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModelsToCreate;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModelsToMove;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModelsToBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockReasonsPerBlockedTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModelsToDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModelsToAttach;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModelsToDetach;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public bool HasResult;
    [FieldOffset(4)]
    public PlacementOperation PlacementOperation;
    [FieldOffset(8)]
    public Entity CharacterEntity;
    [FieldOffset(16)]
    public Nullable_Unboxed<Team> UserTeam;
    [FieldOffset(28)]
    public bool KeepTeamDuringTransform;
    [FieldOffset(32)]
    public NativeList<CreateTileModelData> TileModelsToCreate;
    [FieldOffset(48)]
    public NativeList<MoveTileModelData> TileModelsToMove;
    [FieldOffset(64)]
    public NativeList<BlockedTileModelData> TileModelsToBlock;
    [FieldOffset(80)]
    public NativeMultiHashMap<int, TileModelBlockReasonData> BlockReasonsPerBlockedTileModel;
    [FieldOffset(96)]
    public NativeList<DestroyTileModelData> TileModelsToDestroy;
    [FieldOffset(112)]
    public NativeList<AttachTileModelData> TileModelsToAttach;
    [FieldOffset(128)]
    public NativeList<DetachTileModelData> TileModelsToDetach;

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 794432, RefRangeEnd = 794450, XrefRangeStart = 794390, XrefRangeEnd = 794432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlacementResult()
    {
      Il2CppClassPointerStore<PlacementResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (PlacementResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr);
      PlacementResult.NativeFieldInfoPtr_HasResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (HasResult));
      PlacementResult.NativeFieldInfoPtr_PlacementOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (PlacementOperation));
      PlacementResult.NativeFieldInfoPtr_CharacterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (CharacterEntity));
      PlacementResult.NativeFieldInfoPtr_UserTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (UserTeam));
      PlacementResult.NativeFieldInfoPtr_KeepTeamDuringTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (KeepTeamDuringTransform));
      PlacementResult.NativeFieldInfoPtr_TileModelsToCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (TileModelsToCreate));
      PlacementResult.NativeFieldInfoPtr_TileModelsToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (TileModelsToMove));
      PlacementResult.NativeFieldInfoPtr_TileModelsToBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (TileModelsToBlock));
      PlacementResult.NativeFieldInfoPtr_BlockReasonsPerBlockedTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (BlockReasonsPerBlockedTileModel));
      PlacementResult.NativeFieldInfoPtr_TileModelsToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (TileModelsToDestroy));
      PlacementResult.NativeFieldInfoPtr_TileModelsToAttach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (TileModelsToAttach));
      PlacementResult.NativeFieldInfoPtr_TileModelsToDetach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, nameof (TileModelsToDetach));
      PlacementResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, 100670048);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
