// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CommandInput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CommandInput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControlledEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Command;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountData;
    private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMapData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionDetection;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMapCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCollisionRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetBuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMoveStopTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetEntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPlayerCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTileCollisionHistoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTileGameplayHeightsHistoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTileCollisionHistoryMetadataBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetInputCommandStateHistoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveStopHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollisionCastResults;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldType;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseTileCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseDynamicCollision;
    [FieldOffset(0)]
    public Entity UserEntity;
    [FieldOffset(8)]
    public Entity ControlledEntity;
    [FieldOffset(16)]
    public InputCommandBufferElement Command;
    [FieldOffset(224)]
    public int CurrentFrame;
    [FieldOffset(228)]
    public ConstantCommandMountData MountData;
    [FieldOffset(272)]
    public ProjectM.Velocity Velocity;
    [FieldOffset(284)]
    public MoveVelocity MoveVelocity;
    [FieldOffset(288)]
    public Translation Translation;
    [FieldOffset(300)]
    public LastTranslation LastTranslation;
    [FieldOffset(312)]
    public Rotation Rotation;
    [FieldOffset(328)]
    public EntityAimData AimData;
    [FieldOffset(368)]
    public TileMapCollisionMath.TilePolygons TilePolygons;
    [FieldOffset(448)]
    public TileMapCollisionMath.MapData CurrentMapData;
    [FieldOffset(552)]
    public CollisionDetection CollisionDetection;
    [FieldOffset(568)]
    public ComponentDataFromEntity<MapCollision> GetMapCollision;
    [FieldOffset(600)]
    public ComponentDataFromEntity<CollisionRadius> GetCollisionRadius;
    [FieldOffset(632)]
    public ComponentDataFromEntity<DynamicCollision> GetDynamicCollision;
    [FieldOffset(664)]
    public ComponentDataFromEntity<BuffableFlagState> GetBuffableFlagState;
    [FieldOffset(696)]
    public ComponentDataFromEntity<Translation> GetTranslation;
    [FieldOffset(728)]
    public ComponentDataFromEntity<Dead> GetDead;
    [FieldOffset(760)]
    public ComponentDataFromEntity<MoveStopTrigger> GetMoveStopTrigger;
    [FieldOffset(792)]
    public ComponentDataFromEntity<EntityCategory> GetEntityCategory;
    [FieldOffset(824)]
    public ComponentDataFromEntity<PlayerCharacter> GetPlayerCharacter;
    [FieldOffset(856)]
    public ComponentDataFromEntity<Team> GetTeam;
    [FieldOffset(888)]
    public BufferFromEntity<TileCollisionHistoryElement> GetTileCollisionHistoryBuffer;
    [FieldOffset(928)]
    public BufferFromEntity<TileGameplayHeightsHistoryElement> GetTileGameplayHeightsHistoryBuffer;
    [FieldOffset(968)]
    public BufferFromEntity<TileCollisionHistoryMetadataElement> GetTileCollisionHistoryMetadataBuffer;
    [FieldOffset(1008)]
    public BufferFromEntity<InputCommandStateHistoryBufferElement> GetInputCommandStateHistoryBuffer;
    [FieldOffset(1048)]
    public CurveCollection CurveCollection;
    [FieldOffset(1064)]
    public NativeList<ColliderCastHit> MoveStopHits;
    [FieldOffset(1080)]
    public NativeList<CastResult> DynamicCollisionCastResults;
    [FieldOffset(1096)]
    public WorldType WorldType;
    [FieldOffset(1100)]
    public bool UseTileCollision;
    [FieldOffset(1101)]
    public bool UseDynamicCollision;

    static CommandInput()
    {
      Il2CppClassPointerStore<CommandInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CommandInput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandInput>.NativeClassPtr);
      CommandInput.NativeFieldInfoPtr_UserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (UserEntity));
      CommandInput.NativeFieldInfoPtr_ControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (ControlledEntity));
      CommandInput.NativeFieldInfoPtr_Command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (Command));
      CommandInput.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (CurrentFrame));
      CommandInput.NativeFieldInfoPtr_MountData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (MountData));
      CommandInput.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (Velocity));
      CommandInput.NativeFieldInfoPtr_MoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (MoveVelocity));
      CommandInput.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (Translation));
      CommandInput.NativeFieldInfoPtr_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (LastTranslation));
      CommandInput.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (Rotation));
      CommandInput.NativeFieldInfoPtr_AimData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (AimData));
      CommandInput.NativeFieldInfoPtr_TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (TilePolygons));
      CommandInput.NativeFieldInfoPtr_CurrentMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (CurrentMapData));
      CommandInput.NativeFieldInfoPtr_CollisionDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (CollisionDetection));
      CommandInput.NativeFieldInfoPtr_GetMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetMapCollision));
      CommandInput.NativeFieldInfoPtr_GetCollisionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetCollisionRadius));
      CommandInput.NativeFieldInfoPtr_GetDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetDynamicCollision));
      CommandInput.NativeFieldInfoPtr_GetBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetBuffableFlagState));
      CommandInput.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetTranslation));
      CommandInput.NativeFieldInfoPtr_GetDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetDead));
      CommandInput.NativeFieldInfoPtr_GetMoveStopTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetMoveStopTrigger));
      CommandInput.NativeFieldInfoPtr_GetEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetEntityCategory));
      CommandInput.NativeFieldInfoPtr_GetPlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetPlayerCharacter));
      CommandInput.NativeFieldInfoPtr_GetTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetTeam));
      CommandInput.NativeFieldInfoPtr_GetTileCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetTileCollisionHistoryBuffer));
      CommandInput.NativeFieldInfoPtr_GetTileGameplayHeightsHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetTileGameplayHeightsHistoryBuffer));
      CommandInput.NativeFieldInfoPtr_GetTileCollisionHistoryMetadataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetTileCollisionHistoryMetadataBuffer));
      CommandInput.NativeFieldInfoPtr_GetInputCommandStateHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (GetInputCommandStateHistoryBuffer));
      CommandInput.NativeFieldInfoPtr_CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (CurveCollection));
      CommandInput.NativeFieldInfoPtr_MoveStopHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (MoveStopHits));
      CommandInput.NativeFieldInfoPtr_DynamicCollisionCastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (DynamicCollisionCastResults));
      CommandInput.NativeFieldInfoPtr_WorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (WorldType));
      CommandInput.NativeFieldInfoPtr_UseTileCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (UseTileCollision));
      CommandInput.NativeFieldInfoPtr_UseDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, nameof (UseDynamicCollision));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandInput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
