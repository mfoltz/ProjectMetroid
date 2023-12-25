// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayerTeleportCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class PlayerTeleportCommandSystem : ConsoleCommandSystem
  {
    private static readonly IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__MousePosition;
    private static readonly IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly IntPtr NativeFieldInfoPtr__ChunkWaypointQuery;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroyConsoleCommands_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportCommand_Private_Void_String_String_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_LogError_Private_Static_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportToPlayer_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportPlayerToMe_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportPlayerToMousePosition_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_ChunkTeleport_Suggestions_Private_Void_ArgumentSuggestionCollection_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_WaypointTeleport_Suggestions_Private_Void_ArgumentSuggestionCollection_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportToChunkWaypoint_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportToNether_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_PlayerTeleportCommand_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GatherAllPlayersCommand_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GatherAllPlayersExceptMeCommand_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GatherAllAlliesCommand_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GatherAllAlliesExceptMeCommand_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GatherAllNonAlliesCommand_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TeleportPlayerToChunkCommand_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryParseTerrainChunk_Private_Static_Boolean_String_byref_TerrainChunk_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_0_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_1_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_2_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_3_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_4_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_5_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_6_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649367, XrefRangeEnd = 1649404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerTeleportCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649404, XrefRangeEnd = 1649654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerTeleportCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroyConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerTeleportCommandSystem.NativeMethodInfoPtr_OnDestroyConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649654, XrefRangeEnd = 1649655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerTeleportCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649655, XrefRangeEnd = 1649749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportCommand(
      string who,
      string where,
      float worldPosX,
      float worldPosY,
      float worldPosZ)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(who);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(where);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &worldPosX;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &worldPosY;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &worldPosZ;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportCommand_Private_Void_String_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1649757, RefRangeEnd = 1649759, XrefRangeStart = 1649749, XrefRangeEnd = 1649757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LogError(string message)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(message);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_LogError_Private_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649759, XrefRangeEnd = 1649765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportToPlayer(string userName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(userName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportToPlayer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649765, XrefRangeEnd = 1649771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportPlayerToMe(string userName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(userName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportPlayerToMe_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649771, XrefRangeEnd = 1649777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportPlayerToMousePosition(string userName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(userName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportPlayerToMousePosition_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1649800, RefRangeEnd = 1649802, XrefRangeStart = 1649777, XrefRangeEnd = 1649800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChunkTeleport_Suggestions(
      ArgumentSuggestionCollection suggestionCollection,
      string prefix = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestionCollection);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_ChunkTeleport_Suggestions_Private_Void_ArgumentSuggestionCollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1649824, RefRangeEnd = 1649826, XrefRangeStart = 1649802, XrefRangeEnd = 1649824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WaypointTeleport_Suggestions(
      ArgumentSuggestionCollection suggestionCollection,
      string prefix = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestionCollection);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_WaypointTeleport_Suggestions_Private_Void_ArgumentSuggestionCollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649826, XrefRangeEnd = 1649848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportToChunkWaypoint(string coordinate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(coordinate);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportToChunkWaypoint_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649848, XrefRangeEnd = 1649852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportToNether()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportToNether_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649852, XrefRangeEnd = 1649856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayerTeleportCommand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_PlayerTeleportCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649856, XrefRangeEnd = 1649860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GatherAllPlayersCommand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllPlayersCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649860, XrefRangeEnd = 1649864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GatherAllPlayersExceptMeCommand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllPlayersExceptMeCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649864, XrefRangeEnd = 1649868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GatherAllAlliesCommand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllAlliesCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649868, XrefRangeEnd = 1649872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GatherAllAlliesExceptMeCommand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllAlliesExceptMeCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649872, XrefRangeEnd = 1649876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GatherAllNonAlliesCommand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllNonAlliesCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649876, XrefRangeEnd = 1649885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportPlayerToChunkCommand(string coordinate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(coordinate);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportPlayerToChunkCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1649899, RefRangeEnd = 1649903, XrefRangeStart = 1649885, XrefRangeEnd = 1649899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryParseTerrainChunk(string coordinate, out TerrainChunk terrainChunk)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(coordinate);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref terrainChunk;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_TryParseTerrainChunk_Private_Static_Boolean_String_byref_TerrainChunk_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref blockInputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &inputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 732837, RefRangeEnd = 732840, XrefRangeStart = 732837, XrefRangeEnd = 732840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerTeleportCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649903, XrefRangeEnd = 1649943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__7_0(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_0_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649943, XrefRangeEnd = 1650015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__7_1(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_1_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650015, XrefRangeEnd = 1650018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__7_2(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_2_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650018, XrefRangeEnd = 1650021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__7_3(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_3_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__7_4(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_4_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__7_5(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_5_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__7_6(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_6_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerTeleportCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayerTeleportCommandSystem()
    {
      Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (PlayerTeleportCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr);
      PlayerTeleportCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      PlayerTeleportCommandSystem.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, nameof (_InputSystem));
      PlayerTeleportCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      PlayerTeleportCommandSystem.NativeFieldInfoPtr__MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, nameof (_MousePosition));
      PlayerTeleportCommandSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, nameof (_TerrainManager));
      PlayerTeleportCommandSystem.NativeFieldInfoPtr__ChunkWaypointQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, nameof (_ChunkWaypointQuery));
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663828);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663829);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_OnDestroyConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663830);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663831);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportCommand_Private_Void_String_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663832);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_LogError_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663833);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportToPlayer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663834);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportPlayerToMe_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663835);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportPlayerToMousePosition_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663836);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_ChunkTeleport_Suggestions_Private_Void_ArgumentSuggestionCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663837);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_WaypointTeleport_Suggestions_Private_Void_ArgumentSuggestionCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663838);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportToChunkWaypoint_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663839);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportToNether_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663840);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_PlayerTeleportCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663841);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllPlayersCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663842);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllPlayersExceptMeCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663843);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllAlliesCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663844);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllAlliesExceptMeCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663845);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_GatherAllNonAlliesCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663846);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TeleportPlayerToChunkCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663847);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_TryParseTerrainChunk_Private_Static_Boolean_String_byref_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663848);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663849);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663850);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663851);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_0_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663852);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_1_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663853);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_2_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663854);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_3_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663855);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_4_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663856);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_5_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663857);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__7_6_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663858);
      PlayerTeleportCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleportCommandSystem>.NativeClassPtr, 100663859);
    }

    public PlayerTeleportCommandSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__InputSystem));
        return pointer == IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float3 _MousePosition
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__MousePosition));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__MousePosition)) = value;
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _ChunkWaypointQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__ChunkWaypointQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerTeleportCommandSystem.NativeFieldInfoPtr__ChunkWaypointQuery)) = value;
      }
    }
  }
}
