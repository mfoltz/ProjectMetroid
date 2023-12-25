// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofTestingUtility
// Assembly: ProjectM.Roofs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D6B6D22B-4E3A-4809-82A6-CC2DECC85297
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Roofs.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using ProjectM.CastleBuilding;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Shared;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Roofs
{
  public static class RoofTestingUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupBasicWorld_Public_Static_WorldData_TestWorld_Int32_Nullable_Unboxed_1_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWorld_Public_Static_Void_TestWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateTerrain_Private_Static_Void_TestWorld_Int32_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupTileModelBuildingRequirements_Private_Static_Void_TestWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateUser_Private_Static_Entity_TestWorld_String_UInt16_UserContentFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCharacter_Private_Static_Entity_TestWorld_Entity_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntity_Private_Static_Entity_TestWorld_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunEvent_Public_Static_Void_TestWorld_WorldData_BasicBuildEvent_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Private_Static_PrefabGUID_TestWorld_BuildingType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLastApplyResult_Public_Static_ApplyResult_TestWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateBuildTileModelEvent_Public_Static_Void_TestWorld_PrefabGUID_Entity_float3_TileRotation_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDismantleTileModelEvent_Public_Static_Void_TestWorld_Entity_Entity_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638179, RefRangeEnd = 1638180, XrefRangeStart = 1638146, XrefRangeEnd = 1638179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RoofTestingUtility.WorldData SetupBasicWorld(
      TestWorld world,
      int worldBlockSize = 16,
      Nullable_Unboxed<float3> characterSpawnLocation = default (Nullable_Unboxed<float3>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBlockSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &characterSpawnLocation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_SetupBasicWorld_Public_Static_WorldData_TestWorld_Int32_Nullable_Unboxed_1_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RoofTestingUtility.WorldData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1638189, RefRangeEnd = 1638192, XrefRangeStart = 1638180, XrefRangeEnd = 1638189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateWorld(TestWorld world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_UpdateWorld_Public_Static_Void_TestWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638209, RefRangeEnd = 1638210, XrefRangeStart = 1638192, XrefRangeEnd = 1638209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateTerrain(
      TestWorld world,
      int minX,
      int minY,
      int maxX,
      int maxY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxY;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_CreateTerrain_Private_Static_Void_TestWorld_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638210, XrefRangeEnd = 1638224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupTileModelBuildingRequirements(TestWorld world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_SetupTileModelBuildingRequirements_Private_Static_Void_TestWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638304, RefRangeEnd = 1638305, XrefRangeStart = 1638224, XrefRangeEnd = 1638304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateUser(
      TestWorld world,
      string userName,
      ushort userIndex,
      UserContentFlags userContentFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(userName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_CreateUser_Private_Static_Entity_TestWorld_String_UInt16_UserContentFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638367, RefRangeEnd = 1638368, XrefRangeStart = 1638305, XrefRangeEnd = 1638367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateCharacter(
      TestWorld world,
      Entity userEntity,
      float3 spawnLocation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_CreateCharacter_Private_Static_Entity_TestWorld_Entity_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638372, RefRangeEnd = 1638373, XrefRangeStart = 1638368, XrefRangeEnd = 1638372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateEntity<T>(TestWorld world, T data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) data;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref data;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.MethodInfoStoreGeneric_CreateEntity_Private_Static_Entity_TestWorld_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1638450, RefRangeEnd = 1638453, XrefRangeStart = 1638373, XrefRangeEnd = 1638450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunEvent(
      TestWorld world,
      RoofTestingUtility.WorldData data,
      RoofTestingUtility.BasicBuildEvent buildEvent,
      bool updateWorld = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) buildEvent));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &updateWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_RunEvent_Public_Static_Void_TestWorld_WorldData_BasicBuildEvent_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638481, RefRangeEnd = 1638482, XrefRangeStart = 1638453, XrefRangeEnd = 1638481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabGUID GetPrefabGUID(
      TestWorld world,
      RoofTestingUtility.BuildingType buildingType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buildingType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_GetPrefabGUID_Private_Static_PrefabGUID_TestWorld_BuildingType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638482, XrefRangeEnd = 1638485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ApplyPlacementResult.ApplyResult GetLastApplyResult(TestWorld world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_GetLastApplyResult_Public_Static_ApplyResult_TestWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ApplyPlacementResult.ApplyResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638511, RefRangeEnd = 1638512, XrefRangeStart = 1638485, XrefRangeEnd = 1638511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateBuildTileModelEvent(
      TestWorld world,
      PrefabGUID prefabGUID,
      Entity user,
      float3 translation,
      TileRotation rotation,
      Entity optionalReplacedTileModel = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalReplacedTileModel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_CreateBuildTileModelEvent_Public_Static_Void_TestWorld_PrefabGUID_Entity_float3_TileRotation_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638512, XrefRangeEnd = 1638534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateDismantleTileModelEvent(
      TestWorld world,
      Entity tileModelEntity,
      Entity user)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.NativeMethodInfoPtr_CreateDismantleTileModelEvent_Public_Static_Void_TestWorld_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RoofTestingUtility()
    {
      Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Roofs.dll", "ProjectM.Roofs", nameof (RoofTestingUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr);
      RoofTestingUtility.NativeMethodInfoPtr_SetupBasicWorld_Public_Static_WorldData_TestWorld_Int32_Nullable_Unboxed_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663346);
      RoofTestingUtility.NativeMethodInfoPtr_UpdateWorld_Public_Static_Void_TestWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663347);
      RoofTestingUtility.NativeMethodInfoPtr_CreateTerrain_Private_Static_Void_TestWorld_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663348);
      RoofTestingUtility.NativeMethodInfoPtr_SetupTileModelBuildingRequirements_Private_Static_Void_TestWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663349);
      RoofTestingUtility.NativeMethodInfoPtr_CreateUser_Private_Static_Entity_TestWorld_String_UInt16_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663350);
      RoofTestingUtility.NativeMethodInfoPtr_CreateCharacter_Private_Static_Entity_TestWorld_Entity_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663351);
      RoofTestingUtility.NativeMethodInfoPtr_CreateEntity_Private_Static_Entity_TestWorld_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663352);
      RoofTestingUtility.NativeMethodInfoPtr_RunEvent_Public_Static_Void_TestWorld_WorldData_BasicBuildEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663353);
      RoofTestingUtility.NativeMethodInfoPtr_GetPrefabGUID_Private_Static_PrefabGUID_TestWorld_BuildingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663354);
      RoofTestingUtility.NativeMethodInfoPtr_GetLastApplyResult_Public_Static_ApplyResult_TestWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663355);
      RoofTestingUtility.NativeMethodInfoPtr_CreateBuildTileModelEvent_Public_Static_Void_TestWorld_PrefabGUID_Entity_float3_TileRotation_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663356);
      RoofTestingUtility.NativeMethodInfoPtr_CreateDismantleTileModelEvent_Public_Static_Void_TestWorld_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, 100663357);
    }

    public RoofTestingUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WorldData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_User;
      private static readonly System.IntPtr NativeFieldInfoPtr_Character;
      [FieldOffset(0)]
      public Entity User;
      [FieldOffset(8)]
      public Entity Character;

      static WorldData()
      {
        Il2CppClassPointerStore<RoofTestingUtility.WorldData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, nameof (WorldData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTestingUtility.WorldData>.NativeClassPtr);
        RoofTestingUtility.WorldData.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.WorldData>.NativeClassPtr, nameof (User));
        RoofTestingUtility.WorldData.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.WorldData>.NativeClassPtr, nameof (Character));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofTestingUtility.WorldData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum BuildingType
    {
      Floor,
      Heart,
      Wall,
      Stairs,
      Stairs180,
      ForgeFloor,
    }

    public sealed class BasicBuildEvent : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BuildingType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Location;
      private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransformedTileModel;
      private static readonly System.IntPtr NativeFieldInfoPtr_Assert;
      private static readonly System.IntPtr NativeFieldInfoPtr_Message;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuildingType_int2_Nullable_Unboxed_1_CardinalDirection_Nullable_Unboxed_1_Byte_Entity_Boolean_String_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638145, XrefRangeEnd = 1638146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BasicBuildEvent(
        RoofTestingUtility.BuildingType buildingType,
        int2 location,
        Nullable_Unboxed<CardinalDirection> direction = default (Nullable_Unboxed<CardinalDirection>),
        Nullable_Unboxed<byte> heightLevel = default (Nullable_Unboxed<byte>),
        Entity transformedTileModel = default (Entity),
        bool assert = false,
        string message = null)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &buildingType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &location;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &transformedTileModel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &assert;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoofTestingUtility.BasicBuildEvent.NativeMethodInfoPtr__ctor_Public_Void_BuildingType_int2_Nullable_Unboxed_1_CardinalDirection_Nullable_Unboxed_1_Byte_Entity_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BasicBuildEvent()
      {
        Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr, nameof (BasicBuildEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr);
        RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_BuildingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, nameof (BuildingType));
        RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, nameof (Location));
        RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, nameof (Direction));
        RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, nameof (HeightLevel));
        RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_TransformedTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, nameof (TransformedTileModel));
        RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Assert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, nameof (Assert));
        RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, nameof (Message));
        RoofTestingUtility.BasicBuildEvent.NativeMethodInfoPtr__ctor_Public_Void_BuildingType_int2_Nullable_Unboxed_1_CardinalDirection_Nullable_Unboxed_1_Byte_Entity_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, 100663358);
      }

      public BasicBuildEvent(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BasicBuildEvent()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofTestingUtility.BasicBuildEvent>.NativeClassPtr, data));
      }

      public unsafe RoofTestingUtility.BuildingType BuildingType
      {
        get
        {
          return *(RoofTestingUtility.BuildingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_BuildingType));
        }
        [param: In] set
        {
          *(RoofTestingUtility.BuildingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_BuildingType)) = value;
        }
      }

      public unsafe int2 Location
      {
        get
        {
          return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Location));
        }
        [param: In] set
        {
          *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Location)) = value;
        }
      }

      public unsafe Nullable_Unboxed<CardinalDirection> Direction
      {
        get
        {
          return *(Nullable_Unboxed<CardinalDirection>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Direction));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Direction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CardinalDirection>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<byte> HeightLevel
      {
        get
        {
          return *(Nullable_Unboxed<byte>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_HeightLevel));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_HeightLevel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity TransformedTileModel
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_TransformedTileModel));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_TransformedTileModel)) = value;
        }
      }

      public unsafe bool Assert
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Assert));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Assert)) = value;
        }
      }

      public unsafe string Message
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Message)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestingUtility.BasicBuildEvent.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_CreateEntity_Private_Static_Entity_TestWorld_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RoofTestingUtility.NativeMethodInfoPtr_CreateEntity_Private_Static_Entity_TestWorld_T_0, Il2CppClassPointerStore<RoofTestingUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
