// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientAdminConsoleCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Text;
using ProjectM.CastleBuilding;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ClientAdminConsoleCommandSystem : ConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ADD_TIME_LIVE_MAX_HOURS;
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendUsers_Public_Static_Void_World_StringBuilder_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugViewEnabled_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleDebugViewMode_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDebugViewModeCommand_Private_Void_DefaultConsoleCommand_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Observe_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleInvulnerable_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdminDeauth_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AuthUser_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdminOnly_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Kick_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BanCharacter_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BanUser_Private_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Unban_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Banned_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayerInfo_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DecayCastlesOfPlayer_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PerformanceTestChunkRangeAdvanced_Private_Void_Single_Single_Single_Single_Int32_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PerformanceTestChunksAdvanced_Private_Void_Single_String_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PerformanceTestChunks_Private_Void_Single_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTime_Debug_Private_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTime_Live_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeDurability_Private_Void_Single_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHealthOfClosestToMouse_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceJoinClan_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastleTerritorySuggestions_Private_Il2CppStringArray_TerritoryInclude_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleAbandon_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleExpose_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleUpgrade_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleDisableDefenses_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleClaim_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CastleDestroy_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildCastleInTerritory_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParseTerritoryAndGetCastleHeart_Private_Boolean_String_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParseTerritory_Private_Boolean_String_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTerritoryCastleHeart_Private_Boolean_Int32_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_0_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_2_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_3_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_4_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_5_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_9_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_11_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_12_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_13_Private_Void_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_14_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_15_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_16_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_17_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_18_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_19_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_20_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_21_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetCastleTerritorySuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryParseTerritory_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryGetTerritoryCastleHeart_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638940, XrefRangeEnd = 1638950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638950, XrefRangeEnd = 1639736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1639821, RefRangeEnd = 1639822, XrefRangeStart = 1639736, XrefRangeEnd = 1639821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendUsers(World world, StringBuilder sb, bool includeDisconnected)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDisconnected;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AppendUsers_Public_Static_Void_World_StringBuilder_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639822, XrefRangeEnd = 1639826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DebugViewEnabled(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_DebugViewEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639826, XrefRangeEnd = 1639839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleDebugViewMode(string categoryString)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(categoryString);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ToggleDebugViewMode_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1639870, RefRangeEnd = 1639871, XrefRangeStart = 1639839, XrefRangeEnd = 1639870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeDebugViewModeCommand(DefaultConsoleCommand defaultConsoleCommand)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultConsoleCommand);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_InitializeDebugViewModeCommand_Private_Void_DefaultConsoleCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639871, XrefRangeEnd = 1639875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Observe(int mode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Observe_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639875, XrefRangeEnd = 1639879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleInvulnerable(bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ToggleInvulnerable_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639879, XrefRangeEnd = 1639880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639880, XrefRangeEnd = 1639884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AdminDeauth()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AdminDeauth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639884, XrefRangeEnd = 1639908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AuthUser(string characterName, string adminLevelString)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(characterName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(adminLevelString);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AuthUser_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639908, XrefRangeEnd = 1639912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AdminOnly(bool active)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &active;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AdminOnly_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639912, XrefRangeEnd = 1639921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Kick(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Kick_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639921, XrefRangeEnd = 1639937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BanCharacter(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_BanCharacter_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639937, XrefRangeEnd = 1639946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BanUser(ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &platformId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_BanUser_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639946, XrefRangeEnd = 1639968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Unban(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Unban_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639968, XrefRangeEnd = 1639972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Banned()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Banned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639972, XrefRangeEnd = 1640001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayerInfo(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PlayerInfo_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640001, XrefRangeEnd = 1640010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DecayCastlesOfPlayer(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_DecayCastlesOfPlayer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640010, XrefRangeEnd = 1640112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PerformanceTestChunkRangeAdvanced(
      float distBetweenSamples,
      float chunkLoadInterval,
      float sampleTimeInterval,
      float syncSpikeTimeInterval,
      int startChunkX,
      int startChunkY,
      int chunkRangeX,
      int chunkRangeY)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &distBetweenSamples;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkLoadInterval;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sampleTimeInterval;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &syncSpikeTimeInterval;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startChunkX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &startChunkY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkRangeX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkRangeY;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PerformanceTestChunkRangeAdvanced_Private_Void_Single_Single_Single_Single_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640112, XrefRangeEnd = 1640232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PerformanceTestChunksAdvanced(
      float distBetweenSamples,
      string testMode,
      float chunkLoadInterval,
      float sampleTimeInterval,
      float syncSpikeTimeInterval)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &distBetweenSamples;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(testMode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkLoadInterval;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sampleTimeInterval;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &syncSpikeTimeInterval;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PerformanceTestChunksAdvanced_Private_Void_Single_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640232, XrefRangeEnd = 1640352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PerformanceTestChunks(float distBetweenSamples, string testMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &distBetweenSamples;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(testMode);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PerformanceTestChunks_Private_Void_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640352, XrefRangeEnd = 1640356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddTime_Debug(int hour, int day)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &hour;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &day;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AddTime_Debug_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640356, XrefRangeEnd = 1640364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddTime_Live(int hour)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hour;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AddTime_Live_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640364, XrefRangeEnd = 1640377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeDurability(float change, string equipmentTypeString)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &change;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(equipmentTypeString);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ChangeDurability_Private_Void_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640377, XrefRangeEnd = 1640385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeHealthOfClosestToMouse(int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ChangeHealthOfClosestToMouse_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640385, XrefRangeEnd = 1640412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ForceJoinClan(string modeString, string playerName = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(modeString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(playerName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ForceJoinClan_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1640493, RefRangeEnd = 1640500, XrefRangeStart = 1640412, XrefRangeEnd = 1640493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppStringArray GetCastleTerritorySuggestions(
      ClientAdminConsoleCommandSystem.TerritoryInclude include)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &include;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_GetCastleTerritorySuggestions_Private_Il2CppStringArray_TerritoryInclude_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640500, XrefRangeEnd = 1640503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleAbandon(string territoryText)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleAbandon_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640503, XrefRangeEnd = 1640506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleExpose(string territoryText)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleExpose_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640506, XrefRangeEnd = 1640509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleUpgrade(string territoryText)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleUpgrade_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640509, XrefRangeEnd = 1640512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleDisableDefenses(string territoryText)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleDisableDefenses_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640512, XrefRangeEnd = 1640515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleClaim(string territoryText)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleClaim_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640515, XrefRangeEnd = 1640518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CastleDestroy(string territoryText)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleDestroy_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640518, XrefRangeEnd = 1640523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildCastleInTerritory(string territoryText)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_BuildCastleInTerritory_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1640529, RefRangeEnd = 1640535, XrefRangeStart = 1640523, XrefRangeEnd = 1640529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryParseTerritoryAndGetCastleHeart(
      string territoryText,
      out Entity castleHeartEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_TryParseTerritoryAndGetCastleHeart_Private_Boolean_String_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1640561, RefRangeEnd = 1640563, XrefRangeStart = 1640535, XrefRangeEnd = 1640561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryParseTerritory(string territoryText, out int territoryIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(territoryText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_TryParseTerritory_Private_Boolean_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1640580, RefRangeEnd = 1640581, XrefRangeStart = 1640563, XrefRangeEnd = 1640580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetTerritoryCastleHeart(int territoryIndex, out Entity castleHeartEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &territoryIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_TryGetTerritoryCastleHeart_Private_Boolean_Int32_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 732837, RefRangeEnd = 732840, XrefRangeStart = 732837, XrefRangeEnd = 732840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientAdminConsoleCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640581, XrefRangeEnd = 1640583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_0(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_0_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_2(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_2_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640583, XrefRangeEnd = 1640585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_3(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_3_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640585, XrefRangeEnd = 1640617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_4(bool includeDisconnected)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &includeDisconnected;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_4_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_5(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_5_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_9(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_9_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640617, XrefRangeEnd = 1640633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_11(string characterName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(characterName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_11_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_12(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_12_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640633, XrefRangeEnd = 1640655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_13(int amount, string characterName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(characterName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_13_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_14(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_14_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640655, XrefRangeEnd = 1640658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_15(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_15_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_16(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_16_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_17(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_17_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_18(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_18_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_19(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_19_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_20(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_20_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640658, XrefRangeEnd = 1640661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__4_21(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_21_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640661, XrefRangeEnd = 1640766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640766, XrefRangeEnd = 1640782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetCastleTerritorySuggestions_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetCastleTerritorySuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640782, XrefRangeEnd = 1640801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryParseTerritory_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryParseTerritory_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640801, XrefRangeEnd = 1640817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryGetTerritoryCastleHeart_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryGetTerritoryCastleHeart_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640817, XrefRangeEnd = 1640821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640821, XrefRangeEnd = 1640825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640825, XrefRangeEnd = 1640829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientAdminConsoleCommandSystem()
    {
      Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (ClientAdminConsoleCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr);
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr_ADD_TIME_LIVE_MAX_HOURS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, nameof (ADD_TIME_LIVE_MAX_HOURS));
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>GetCastleTerritorySuggestions_LambdaJob0_entityQuery");
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>GetCastleTerritorySuggestions_LambdaJob0_profilerMarker");
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>TryParseTerritory_LambdaJob0_entityQuery");
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>TryParseTerritory_LambdaJob0_profilerMarker");
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>TryGetTerritoryCastleHeart_LambdaJob0_entityQuery");
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>TryGetTerritoryCastleHeart_LambdaJob0_profilerMarker");
      ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalControlled_0));
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663300);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663301);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AppendUsers_Public_Static_Void_World_StringBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663302);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_DebugViewEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663303);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ToggleDebugViewMode_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663304);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_InitializeDebugViewModeCommand_Private_Void_DefaultConsoleCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663305);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Observe_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663306);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ToggleInvulnerable_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663307);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663308);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AdminDeauth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663309);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AuthUser_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663310);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AdminOnly_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663311);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Kick_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663312);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_BanCharacter_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663313);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_BanUser_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663314);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Unban_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663315);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Banned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663316);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PlayerInfo_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663317);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_DecayCastlesOfPlayer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663318);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PerformanceTestChunkRangeAdvanced_Private_Void_Single_Single_Single_Single_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663319);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PerformanceTestChunksAdvanced_Private_Void_Single_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663320);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_PerformanceTestChunks_Private_Void_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663321);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AddTime_Debug_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663322);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_AddTime_Live_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663323);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ChangeDurability_Private_Void_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663324);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ChangeHealthOfClosestToMouse_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663325);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_ForceJoinClan_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663326);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_GetCastleTerritorySuggestions_Private_Il2CppStringArray_TerritoryInclude_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663327);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleAbandon_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663328);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleExpose_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663329);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleUpgrade_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663330);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleDisableDefenses_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663331);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleClaim_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663332);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_CastleDestroy_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663333);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_BuildCastleInTerritory_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663334);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_TryParseTerritoryAndGetCastleHeart_Private_Boolean_String_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663335);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_TryParseTerritory_Private_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663336);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_TryGetTerritoryCastleHeart_Private_Boolean_Int32_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663337);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663338);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_0_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663339);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_2_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663340);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_3_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663341);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_4_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663342);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_5_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663343);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_9_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663344);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_11_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663345);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_12_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663346);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_13_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663347);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_14_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663348);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_15_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663349);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_16_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663350);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_17_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663351);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_18_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663352);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_19_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663353);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_20_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663354);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_21_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663355);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663356);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetCastleTerritorySuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663357);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryParseTerritory_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663358);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryGetTerritoryCastleHeart_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663359);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663360);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663361);
      ClientAdminConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, 100663362);
    }

    public ClientAdminConsoleCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int ADD_TIME_LIVE_MAX_HOURS
    {
      get
      {
        int timeLiveMaxHours;
        IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr_ADD_TIME_LIVE_MAX_HOURS, (void*) &timeLiveMaxHours);
        return timeLiveMaxHours;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr_ADD_TIME_LIVE_MAX_HOURS, (void*) &value);
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __GetCastleTerritorySuggestions_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetCastleTerritorySuggestions_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___GetCastleTerritorySuggestions_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TryParseTerritory_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryParseTerritory_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryParseTerritory_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TryGetTerritoryCastleHeart_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryGetTerritoryCastleHeart_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr___TryGetTerritoryCastleHeart_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalControlled_0
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_0));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_0)) = value;
      }
    }

    [Flags]
    public enum TerritoryInclude
    {
      Occupied = 1,
      Unoccupied = 2,
    }

    [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_6;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_7;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_22;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_23;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_24;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_8;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_10;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__22_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__22_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__24_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_1_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_6_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_7_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_22_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_23_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_24_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_8_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_10_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PerformanceTestChunkRangeAdvanced_b__22_0_Internal_Int32_Vector2Int_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PerformanceTestChunkRangeAdvanced_b__22_1_Internal_Int32_Vector2Int_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PerformanceTestChunksAdvanced_b__23_0_Internal_Int32_Vector2Int_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PerformanceTestChunksAdvanced_b__23_1_Internal_Int32_Vector2Int_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PerformanceTestChunks_b__24_0_Internal_Int32_Vector2Int_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PerformanceTestChunks_b__24_1_Internal_Int32_Vector2Int_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638534, XrefRangeEnd = 1638546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_1(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_1_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638546, XrefRangeEnd = 1638553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_6(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_6_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638553, XrefRangeEnd = 1638560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_7(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_7_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638560, XrefRangeEnd = 1638562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_22(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_22_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638562, XrefRangeEnd = 1638564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_23(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_23_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638564, XrefRangeEnd = 1638566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_24(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_24_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638566, XrefRangeEnd = 1638584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_8(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_8_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638584, XrefRangeEnd = 1638596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_10(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_10_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _PerformanceTestChunkRangeAdvanced_b__22_0(Vector2Int a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &a;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunkRangeAdvanced_b__22_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _PerformanceTestChunkRangeAdvanced_b__22_1(Vector2Int a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &a;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunkRangeAdvanced_b__22_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _PerformanceTestChunksAdvanced_b__23_0(Vector2Int a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &a;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunksAdvanced_b__23_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _PerformanceTestChunksAdvanced_b__23_1(Vector2Int a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &a;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunksAdvanced_b__23_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _PerformanceTestChunks_b__24_0(Vector2Int a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &a;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunks_b__24_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _PerformanceTestChunks_b__24_1(Vector2Int a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &a;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunks_b__24_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr);
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_1");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_6");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_7");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_22");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_23");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_24");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_8");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_10");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__22_0");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__22_1");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__23_0");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__23_1");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__24_0");
        ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, "<>9__24_1");
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663364);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_1_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663365);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_6_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663366);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_7_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663367);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_22_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663368);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_23_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663369);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_24_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663370);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_8_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663371);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_10_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663372);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunkRangeAdvanced_b__22_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663373);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunkRangeAdvanced_b__22_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663374);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunksAdvanced_b__23_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663375);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunksAdvanced_b__23_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663376);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunks_b__24_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663377);
        ClientAdminConsoleCommandSystem.__c.NativeMethodInfoPtr__PerformanceTestChunks_b__24_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c>.NativeClassPtr, 100663378);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ClientAdminConsoleCommandSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ClientAdminConsoleCommandSystem.__c) null : new ClientAdminConsoleCommandSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_6
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_6, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_7
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_7, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_7, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_22
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_22, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_22, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_23
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_23, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_23, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_24
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_24, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_24, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_8
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_8, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_8, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__4_10
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_10, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_10, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Vector2Int, int> __9__22_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__22_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Vector2Int, int>) null : new Il2CppSystem.Func<Vector2Int, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__22_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Vector2Int, int> __9__22_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__22_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Vector2Int, int>) null : new Il2CppSystem.Func<Vector2Int, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__22_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Vector2Int, int> __9__23_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__23_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Vector2Int, int>) null : new Il2CppSystem.Func<Vector2Int, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__23_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Vector2Int, int> __9__23_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__23_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Vector2Int, int>) null : new Il2CppSystem.Func<Vector2Int, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__23_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Vector2Int, int> __9__24_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__24_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Vector2Int, int>) null : new Il2CppSystem.Func<Vector2Int, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__24_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Vector2Int, int> __9__24_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__24_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Vector2Int, int>) null : new Il2CppSystem.Func<Vector2Int, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c.NativeFieldInfoPtr___9__24_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/<>c__DisplayClass31_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass31_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_include;
      private static readonly System.IntPtr NativeFieldInfoPtr_validTerritoryList;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetCastleTerritorySuggestions_b__0_Internal_Void_byref_CastleTerritory_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ClientAdminConsoleCommandSystem.TerritoryInclude include;
      [FieldOffset(16)]
      public NativeList<CastleTerritory> validTerritoryList;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass31_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GetCastleTerritorySuggestions_b__0([In] ref CastleTerritory territory)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref territory;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__GetCastleTerritorySuggestions_b__0_Internal_Void_byref_CastleTerritory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass31_0()
      {
        Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass31_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr);
        ClientAdminConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (entityManager));
        ClientAdminConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_include = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (include));
        ClientAdminConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_validTerritoryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (validTerritoryList));
        ClientAdminConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, 100663379);
        ClientAdminConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__GetCastleTerritorySuggestions_b__0_Internal_Void_byref_CastleTerritory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, 100663380);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/<>c__DisplayClass40_0")]
    public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mouseTile;
      private static readonly System.IntPtr NativeFieldInfoPtr_matchingTerritoryIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryParseTerritory_b__0_Internal_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass40_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TryParseTerritory_b__0(
        [In] ref CastleTerritory territory,
        [In] ref DynamicBuffer<CastleTerritoryTiles> territoryTiles)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref territory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryTiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__TryParseTerritory_b__0_Internal_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass40_0()
      {
        Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass40_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr);
        ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_mouseTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, nameof (mouseTile));
        ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_matchingTerritoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, nameof (matchingTerritoryIndex));
        ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, 100663381);
        ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__TryParseTerritory_b__0_Internal_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, 100663382);
      }

      public __c__DisplayClass40_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int2 mouseTile
      {
        get
        {
          return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_mouseTile));
        }
        [param: In] set
        {
          *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_mouseTile)) = value;
        }
      }

      public unsafe Nullable_Unboxed<int> matchingTerritoryIndex
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_matchingTerritoryIndex));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientAdminConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_matchingTerritoryIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/<>c__DisplayClass41_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass41_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_entity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryGetTerritoryCastleHeart_b__0_Internal_Void_byref_CastleTerritory_0;
      [FieldOffset(0)]
      public int territoryIndex;
      [FieldOffset(4)]
      public Entity entity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass41_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TryGetTerritoryCastleHeart_b__0([In] ref CastleTerritory territory)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref territory;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__TryGetTerritoryCastleHeart_b__0_Internal_Void_byref_CastleTerritory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass41_0()
      {
        Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass41_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr);
        ClientAdminConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_territoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (territoryIndex));
        ClientAdminConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (entity));
        ClientAdminConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, 100663383);
        ClientAdminConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__TryGetTerritoryCastleHeart_b__0_Internal_Void_byref_CastleTerritory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, 100663384);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_include;
      private static readonly System.IntPtr NativeFieldInfoPtr_validTerritoryList;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ClientAdminConsoleCommandSystem.TerritoryInclude include;
      [FieldOffset(16)]
      public NativeList<CastleTerritory> validTerritoryList;
      [FieldOffset(32)]
      public ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638679, XrefRangeEnd = 1638686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref CastleTerritory territory)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref territory;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1343335, RefRangeEnd = 1343337, XrefRangeStart = 1343335, XrefRangeEnd = 1343337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1343337, RefRangeEnd = 1343339, XrefRangeStart = 1343337, XrefRangeEnd = 1343339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638686, XrefRangeEnd = 1638688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1638693, RefRangeEnd = 1638694, XrefRangeStart = 1638688, XrefRangeEnd = 1638693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1638696, RefRangeEnd = 1638697, XrefRangeStart = 1638694, XrefRangeEnd = 1638696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientAdminConsoleCommandSystem componentSystem,
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass31_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_byref___c__DisplayClass31_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638697, XrefRangeEnd = 1638701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638701, XrefRangeEnd = 1638707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_include = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (include));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_validTerritoryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (validTerritoryList));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663385);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663386);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663387);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663388);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663389);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663390);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663391);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, 100663392);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territory;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_territory;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638599, RefRangeEnd = 1638600, XrefRangeStart = 1638596, XrefRangeEnd = 1638599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientAdminConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638603, RefRangeEnd = 1638604, XrefRangeStart = 1638600, XrefRangeEnd = 1638603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territory));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663393);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663394);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territory;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_territory;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territory));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0/ProjectM.RunWithoutJobSystem_0000005C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000005C$PostfixBurstDelegate");
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663395);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663396);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663397);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663398);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0/ProjectM.RunWithoutJobSystem_0000005C$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638604, XrefRangeEnd = 1638618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638618, XrefRangeEnd = 1638636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638636, XrefRangeEnd = 1638651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638678, RefRangeEnd = 1638679, XrefRangeStart = 1638651, XrefRangeEnd = 1638678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000005C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663399);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663400);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663401);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663402);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663404);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_GetCastleTerritorySuggestions_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_TryParseTerritory_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TryParseTerritory_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mouseTile;
      private static readonly System.IntPtr NativeFieldInfoPtr_matchingTerritoryIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass40_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass40_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem___c__DisplayClass40_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int2 mouseTile;
      [FieldOffset(8)]
      public Nullable_Unboxed<int> matchingTerritoryIndex;
      [FieldOffset(16)]
      public ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638796, XrefRangeEnd = 1638811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref CastleTerritory territory,
        [In] ref DynamicBuffer<CastleTerritoryTiles> territoryTiles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref territory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref territoryTiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1638811, RefRangeEnd = 1638812, XrefRangeStart = 1638811, XrefRangeEnd = 1638811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ClientAdminConsoleCommandSystem.__c__DisplayClass40_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass40_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public virtual unsafe void WriteToDisplayClass(
        ClientAdminConsoleCommandSystem.__c__DisplayClass40_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass40_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638812, XrefRangeEnd = 1638814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1638822, RefRangeEnd = 1638823, XrefRangeStart = 1638814, XrefRangeEnd = 1638822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638823, XrefRangeEnd = 1638825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientAdminConsoleCommandSystem componentSystem,
        ClientAdminConsoleCommandSystem.__c__DisplayClass40_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem___c__DisplayClass40_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638825, XrefRangeEnd = 1638829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638829, XrefRangeEnd = 1638835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryParseTerritory_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_TryParseTerritory_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_mouseTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, nameof (mouseTile));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_matchingTerritoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, nameof (matchingTerritoryIndex));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663405);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass40_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663406);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass40_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663407);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663408);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663409);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem___c__DisplayClass40_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663410);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663411);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, 100663412);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territory;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territoryTiles;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_territory;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles> forParameter_territoryTiles;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638713, RefRangeEnd = 1638714, XrefRangeStart = 1638707, XrefRangeEnd = 1638713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientAdminConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638720, RefRangeEnd = 1638721, XrefRangeStart = 1638714, XrefRangeEnd = 1638720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territory));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territoryTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territoryTiles));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663413);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663414);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territory;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territoryTiles;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_territory;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles>.Runtime runtime_territoryTiles;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territory));
            ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territoryTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territoryTiles));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_TryParseTerritory_LambdaJob0/ProjectM.RunWithoutJobSystem_00000065$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000065$PostfixBurstDelegate");
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663415);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663416);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663417);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663418);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_TryParseTerritory_LambdaJob0/ProjectM.RunWithoutJobSystem_00000065$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638721, XrefRangeEnd = 1638735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638735, XrefRangeEnd = 1638753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638753, XrefRangeEnd = 1638768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638795, RefRangeEnd = 1638796, XrefRangeStart = 1638768, XrefRangeEnd = 1638795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000065$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663419);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663420);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663421);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663422);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663424);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryParseTerritory_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int territoryIndex;
      [FieldOffset(4)]
      public Entity entity;
      [FieldOffset(16)]
      public ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1638918, RefRangeEnd = 1638919, XrefRangeStart = 1638918, XrefRangeEnd = 1638918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref CastleTerritory territory)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref territory;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638919, XrefRangeEnd = 1638921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1638926, RefRangeEnd = 1638927, XrefRangeStart = 1638921, XrefRangeEnd = 1638926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1638929, RefRangeEnd = 1638930, XrefRangeStart = 1638927, XrefRangeEnd = 1638929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientAdminConsoleCommandSystem componentSystem,
        ref ClientAdminConsoleCommandSystem.__c__DisplayClass41_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_byref___c__DisplayClass41_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638930, XrefRangeEnd = 1638934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638934, XrefRangeEnd = 1638940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_territoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, nameof (territoryIndex));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, nameof (entity));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleTerritory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663425);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663426);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663427);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663428);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663429);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663430);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663431);
        ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, 100663432);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_territory;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_territory;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638838, RefRangeEnd = 1638839, XrefRangeStart = 1638835, XrefRangeEnd = 1638838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientAdminConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638842, RefRangeEnd = 1638843, XrefRangeStart = 1638839, XrefRangeEnd = 1638842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_territory));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientAdminConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663433);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663434);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_territory;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_territory;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_territory));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0/ProjectM.RunWithoutJobSystem_0000006E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000006E$PostfixBurstDelegate");
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663435);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663436);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663437);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663438);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ClientAdminConsoleCommandSystem/ProjectM.<>c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0/ProjectM.RunWithoutJobSystem_0000006E$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638843, XrefRangeEnd = 1638857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638857, XrefRangeEnd = 1638875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638875, XrefRangeEnd = 1638890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1638917, RefRangeEnd = 1638918, XrefRangeStart = 1638890, XrefRangeEnd = 1638917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000006E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663439);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663440);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663441);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663442);
          ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663444);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientAdminConsoleCommandSystem.__c__DisplayClass_TryGetTerritoryCastleHeart_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
