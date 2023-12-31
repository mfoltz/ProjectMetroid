// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.GameplayLocationHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Gameplay
{
  public static class GameplayLocationHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FindLocation_Public_Static_float3_byref_TileWorld_byref_CollisionWorld_byref_GameplayLocationInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBackupLocation_Private_Static_Void_float3_float3_byref_BackupLocation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBackCastResult_Private_Static_CastTargetResult_byref_TileWorld_byref_CollisionWorld_byref_GameplayLocationInfo_float3_TileCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastResult_Private_Static_CastTargetResult_byref_TileWorld_byref_CollisionWorld_byref_TileCoordinate_TileCoordinate_byref_GameplayLocationCollisionInfo_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUnreachable_Private_Static_Boolean_byref_CollisionWorld_int2_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileColliderBounds_Private_Static_BoundsMinMax_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckBoundsCollision_Private_Static_Boolean_byref_TileWorld_BoundsMinMax_Byte_MapCollisionFlags_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 789888, RefRangeEnd = 789896, XrefRangeStart = 789842, XrefRangeEnd = 789888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 FindLocation(
      [In] ref TileWorld tileWorld,
      ref CollisionWorld collisionWorld,
      [In] ref GameplayLocationInfo castInfo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castInfo;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.NativeMethodInfoPtr_FindLocation_Public_Static_float3_byref_TileWorld_byref_CollisionWorld_byref_GameplayLocationInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void UpdateBackupLocation(
      float3 location,
      float3 target,
      ref GameplayLocationHelper.BackupLocation backup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &location;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref backup;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.NativeMethodInfoPtr_UpdateBackupLocation_Private_Static_Void_float3_float3_byref_BackupLocation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 789905, RefRangeEnd = 789906, XrefRangeStart = 789896, XrefRangeEnd = 789905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameplayLocationHelper.CastTargetResult GetBackCastResult(
      [In] ref TileWorld tileWorld,
      ref CollisionWorld collisionWorld,
      [In] ref GameplayLocationInfo castInfo,
      float3 target,
      TileCoordinate targetTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castInfo;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &targetTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.NativeMethodInfoPtr_GetBackCastResult_Private_Static_CastTargetResult_byref_TileWorld_byref_CollisionWorld_byref_GameplayLocationInfo_float3_TileCoordinate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayLocationHelper.CastTargetResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 789948, RefRangeEnd = 789950, XrefRangeStart = 789906, XrefRangeEnd = 789948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameplayLocationHelper.CastTargetResult GetCastResult(
      [In] ref TileWorld tileWorld,
      ref CollisionWorld collisionWorld,
      [In] ref TileCoordinate start,
      TileCoordinate end,
      [In] ref GameplayLocationCollisionInfo collision,
      bool returnFirstValidPosition = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref collision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &returnFirstValidPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.NativeMethodInfoPtr_GetCastResult_Private_Static_CastTargetResult_byref_TileWorld_byref_CollisionWorld_byref_TileCoordinate_TileCoordinate_byref_GameplayLocationCollisionInfo_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayLocationHelper.CastTargetResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 789953, RefRangeEnd = 789954, XrefRangeStart = 789950, XrefRangeEnd = 789953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsUnreachable(
      ref CollisionWorld collisionWorld,
      int2 tile,
      float gameplayHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.NativeMethodInfoPtr_IsUnreachable_Private_Static_Boolean_byref_CollisionWorld_int2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789954, XrefRangeEnd = 789959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetTileColliderBounds(float radius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &radius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.NativeMethodInfoPtr_GetTileColliderBounds_Private_Static_BoundsMinMax_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 789977, RefRangeEnd = 789978, XrefRangeStart = 789959, XrefRangeEnd = 789977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckBoundsCollision(
      [In] ref TileWorld tileWorld,
      BoundsMinMax worldBounds,
      byte currentHeightLevel,
      MapCollisionFlags collisionFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &currentHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.NativeMethodInfoPtr_CheckBoundsCollision_Private_Static_Boolean_byref_TileWorld_BoundsMinMax_Byte_MapCollisionFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameplayLocationHelper()
    {
      Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay", nameof (GameplayLocationHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr);
      GameplayLocationHelper.NativeMethodInfoPtr_FindLocation_Public_Static_float3_byref_TileWorld_byref_CollisionWorld_byref_GameplayLocationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, 100669498);
      GameplayLocationHelper.NativeMethodInfoPtr_UpdateBackupLocation_Private_Static_Void_float3_float3_byref_BackupLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, 100669499);
      GameplayLocationHelper.NativeMethodInfoPtr_GetBackCastResult_Private_Static_CastTargetResult_byref_TileWorld_byref_CollisionWorld_byref_GameplayLocationInfo_float3_TileCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, 100669500);
      GameplayLocationHelper.NativeMethodInfoPtr_GetCastResult_Private_Static_CastTargetResult_byref_TileWorld_byref_CollisionWorld_byref_TileCoordinate_TileCoordinate_byref_GameplayLocationCollisionInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, 100669501);
      GameplayLocationHelper.NativeMethodInfoPtr_IsUnreachable_Private_Static_Boolean_byref_CollisionWorld_int2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, 100669502);
      GameplayLocationHelper.NativeMethodInfoPtr_GetTileColliderBounds_Private_Static_BoundsMinMax_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, 100669503);
      GameplayLocationHelper.NativeMethodInfoPtr_CheckBoundsCollision_Private_Static_Boolean_byref_TileWorld_BoundsMinMax_Byte_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, 100669504);
    }

    public GameplayLocationHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BackupLocation
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      [FieldOffset(0)]
      public float DistanceSq;
      [FieldOffset(4)]
      public float3 Position;

      static BackupLocation()
      {
        Il2CppClassPointerStore<GameplayLocationHelper.BackupLocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, nameof (BackupLocation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayLocationHelper.BackupLocation>.NativeClassPtr);
        GameplayLocationHelper.BackupLocation.NativeFieldInfoPtr_DistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationHelper.BackupLocation>.NativeClassPtr, nameof (DistanceSq));
        GameplayLocationHelper.BackupLocation.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationHelper.BackupLocation>.NativeClassPtr, nameof (Position));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayLocationHelper.BackupLocation>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CastTargetResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LastValidTile;
      private static readonly System.IntPtr NativeFieldInfoPtr_FoundValidTargetTile;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReachedTargetHeight;
      private static readonly System.IntPtr NativeFieldInfoPtr_PathBlockingCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_SurpassedHeightLimits;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetValid_Public_get_Boolean_0;
      [FieldOffset(0)]
      public TileCoordinate LastValidTile;
      [FieldOffset(12)]
      public bool FoundValidTargetTile;
      [FieldOffset(13)]
      public bool ReachedTargetHeight;
      [FieldOffset(14)]
      public bool PathBlockingCollision;
      [FieldOffset(15)]
      public bool SurpassedHeightLimits;

      public unsafe bool TargetValid
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 789841, RefRangeEnd = 789842, XrefRangeStart = 789841, XrefRangeEnd = 789841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayLocationHelper.CastTargetResult.NativeMethodInfoPtr_get_TargetValid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      static CastTargetResult()
      {
        Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayLocationHelper>.NativeClassPtr, nameof (CastTargetResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr);
        GameplayLocationHelper.CastTargetResult.NativeFieldInfoPtr_LastValidTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr, nameof (LastValidTile));
        GameplayLocationHelper.CastTargetResult.NativeFieldInfoPtr_FoundValidTargetTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr, nameof (FoundValidTargetTile));
        GameplayLocationHelper.CastTargetResult.NativeFieldInfoPtr_ReachedTargetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr, nameof (ReachedTargetHeight));
        GameplayLocationHelper.CastTargetResult.NativeFieldInfoPtr_PathBlockingCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr, nameof (PathBlockingCollision));
        GameplayLocationHelper.CastTargetResult.NativeFieldInfoPtr_SurpassedHeightLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr, nameof (SurpassedHeightLimits));
        GameplayLocationHelper.CastTargetResult.NativeMethodInfoPtr_get_TargetValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr, 100669505);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayLocationHelper.CastTargetResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
