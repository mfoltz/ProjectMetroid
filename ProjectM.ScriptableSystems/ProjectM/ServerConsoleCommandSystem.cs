// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerConsoleCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class ServerConsoleCommandSystem : GameplayConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TestCollecitonChecks_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetWallpaper_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetWallpaper_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetWallpaper_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetWallpaper_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DebugShowPhysicsCasts_2;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_3;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_4;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendUsers_Public_Static_Void_World_StringBuilder_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EquipBagSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EquipBag_Private_Void_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EquipJewelSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EquipJewel_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnequipJewel_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpellModSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbilitiesWithSpellModsSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HardCoreTest_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TestCollecitonChecks_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendServerAnnouncement_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendServerIsRestartingAnnouncement_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGameplayDebuggerState_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TestCollectionChecks_Private_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TestCollectionChecks2_Private_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogStatChanges_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InterruptAbilityServer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowPhysicsCasts_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearAbilityGroups_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilityGroupsSuggestion_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PersistenceDebuggingEnabled_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityGroup_Private_Void_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Respawn_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetCharacter_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllValidEvents_Private_Il2CppReferenceArray_1_Type_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCrappyEvents_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindFieldOfType_Private_Static_Boolean_Type_ptr_Byte_byref_ptr_TFieldType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintRespawnTimers_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetWallpaper_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowPlacement_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowTileCollisionHistory_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowTranslations_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowTranslationsLocalToWorldDiff_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowHeight_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowMapCollisionRadius_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowSunDamageRays_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowRoofDebug_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPrioritization_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowWorldPathfindingBounds_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowWorldTileCollisionBounds_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TeleportToPatrol_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TeleportToPatrolArgumentHandling_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_1_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSendServerAnnouncement_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSendServerIsRestartingAnnouncement_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPrintRespawnTimers_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetWallpaper_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetWallpaper_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650924, XrefRangeEnd = 1651348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1651413, RefRangeEnd = 1651414, XrefRangeStart = 1651348, XrefRangeEnd = 1651413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendUsers(
      World serverWorld,
      StringBuilder sb,
      bool includeDisconnected)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDisconnected;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_AppendUsers_Public_Static_Void_World_StringBuilder_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651414, XrefRangeEnd = 1651430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EquipBagSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipBagSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651430, XrefRangeEnd = 1651489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EquipBag(string itemParameter, int bagSlot)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(itemParameter);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bagSlot;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipBag_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651489, XrefRangeEnd = 1651505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EquipJewelSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipJewelSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651505, XrefRangeEnd = 1651521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EquipJewel(string itemParameter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(itemParameter);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipJewel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651521, XrefRangeEnd = 1651541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnequipJewel(string abilityName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_UnequipJewel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651541, XrefRangeEnd = 1651577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SpellModSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_SpellModSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651577, XrefRangeEnd = 1651592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AbilitiesWithSpellModsSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_AbilitiesWithSpellModsSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651592, XrefRangeEnd = 1651606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HardCoreTest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_HardCoreTest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651606, XrefRangeEnd = 1651666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TestCollecitonChecks(int mode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_TestCollecitonChecks_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651666, XrefRangeEnd = 1651683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendServerAnnouncement(string message)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(message);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_SendServerAnnouncement_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651683, XrefRangeEnd = 1651693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendServerIsRestartingAnnouncement(int timeInMinutes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &timeInMinutes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_SendServerIsRestartingAnnouncement_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651693, XrefRangeEnd = 1651694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetGameplayDebuggerState(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_SetGameplayDebuggerState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651694, XrefRangeEnd = 1651700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TestCollectionChecks()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_TestCollectionChecks_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1651706, RefRangeEnd = 1651707, XrefRangeStart = 1651700, XrefRangeEnd = 1651706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TestCollectionChecks2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_TestCollectionChecks2_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651707, XrefRangeEnd = 1651709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogStatChanges(bool enabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_LogStatChanges_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651709, XrefRangeEnd = 1651722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InterruptAbilityServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_InterruptAbilityServer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651722, XrefRangeEnd = 1651729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowPhysicsCasts(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowPhysicsCasts_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651729, XrefRangeEnd = 1651781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearAbilityGroups()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ClearAbilityGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651781, XrefRangeEnd = 1651806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAbilityGroupsSuggestion(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_GetAbilityGroupsSuggestion_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651806, XrefRangeEnd = 1651815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PersistenceDebuggingEnabled(bool enabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_PersistenceDebuggingEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651815, XrefRangeEnd = 1651876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilityGroup(int index, string ability)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(ability);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_SetAbilityGroup_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651876, XrefRangeEnd = 1651903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Respawn()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_Respawn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1651903, XrefRangeEnd = 1652147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetCharacter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ResetCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652147, XrefRangeEnd = 1652157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetAllValidEvents(bool logSkips)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &logSkips;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_GetAllValidEvents_Private_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652157, XrefRangeEnd = 1652281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateCrappyEvents(string type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_CreateCrappyEvents_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1652290, RefRangeEnd = 1652291, XrefRangeStart = 1652281, XrefRangeEnd = 1652290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindFieldOfType<TFieldType>(
      Il2CppSystem.Type type,
      byte* dataPtr,
      out TFieldType* modificationFieldPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) dataPtr;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TFieldType*& local1;
      if (!typeof (TFieldType).IsValueType)
      {
        zero = System.IntPtr.Zero;
        // ISSUE: explicit reference operation
        local1 = @(TFieldType*) zero;
      }
      else
        local1 = ref modificationFieldPtr;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.MethodInfoStoreGeneric_TryFindFieldOfType_Private_Static_Boolean_Type_ptr_Byte_byref_ptr_TFieldType_0<TFieldType>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (TFieldType).IsValueType)
      {
        ref TFieldType* local2 = ref modificationFieldPtr;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFieldType>(objectPointer, false, false);
        local2 = (TFieldType*) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652291, XrefRangeEnd = 1652323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintRespawnTimers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_PrintRespawnTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652323, XrefRangeEnd = 1652361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetWallpaper(int styleIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &styleIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_SetWallpaper_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652361, XrefRangeEnd = 1652374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowPlacement(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowPlacement_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652374, XrefRangeEnd = 1652385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowTileCollisionHistory(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowTileCollisionHistory_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652385, XrefRangeEnd = 1652396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowTranslations(int state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowTranslations_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652396, XrefRangeEnd = 1652417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowTranslationsLocalToWorldDiff(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowTranslationsLocalToWorldDiff_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652417, XrefRangeEnd = 1652430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowHeight(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowHeight_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652430, XrefRangeEnd = 1652443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowMapCollisionRadius(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowMapCollisionRadius_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652443, XrefRangeEnd = 1652456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowSunDamageRays(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowSunDamageRays_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652456, XrefRangeEnd = 1652477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowRoofDebug(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowRoofDebug_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652477, XrefRangeEnd = 1652493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogPrioritization(bool enable)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enable;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_LogPrioritization_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652493, XrefRangeEnd = 1652496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowWorldPathfindingBounds(int range)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &range;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowWorldPathfindingBounds_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1652506, RefRangeEnd = 1652507, XrefRangeStart = 1652496, XrefRangeEnd = 1652506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowWorldTileCollisionBounds<TDebugWorldTileBounds>(int range)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &range;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.MethodInfoStoreGeneric_ShowWorldTileCollisionBounds_Private_Void_Int32_0<TDebugWorldTileBounds>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652507, XrefRangeEnd = 1652550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportToPatrol(string patrolId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(patrolId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_TeleportToPatrol_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652550, XrefRangeEnd = 1652596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TeleportToPatrolArgumentHandling(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_TeleportToPatrolArgumentHandling_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerConsoleCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652596, XrefRangeEnd = 1652612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__1_0(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652612, XrefRangeEnd = 1652627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__1_1(bool includeDisconnected)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &includeDisconnected;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652627, XrefRangeEnd = 1652812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1652834, RefRangeEnd = 1652835, XrefRangeStart = 1652812, XrefRangeEnd = 1652834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652835, XrefRangeEnd = 1652854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSendServerAnnouncement_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendServerAnnouncement_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652854, XrefRangeEnd = 1652873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSendServerIsRestartingAnnouncement_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendServerIsRestartingAnnouncement_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1652895, RefRangeEnd = 1652896, XrefRangeStart = 1652873, XrefRangeEnd = 1652895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPrintRespawnTimers_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintRespawnTimers_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652896, XrefRangeEnd = 1652915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetWallpaper_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetWallpaper_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652915, XrefRangeEnd = 1652934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetWallpaper_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetWallpaper_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1652938, RefRangeEnd = 1652939, XrefRangeStart = 1652934, XrefRangeEnd = 1652938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1652943, RefRangeEnd = 1652944, XrefRangeStart = 1652939, XrefRangeEnd = 1652943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1652948, RefRangeEnd = 1652949, XrefRangeStart = 1652944, XrefRangeEnd = 1652948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerConsoleCommandSystem()
    {
      Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (ServerConsoleCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr);
      ServerConsoleCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___TestCollecitonChecks_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>TestCollecitonChecks_LambdaJob0_profilerMarker");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SendServerAnnouncement_LambdaJob0_entityQuery");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SendServerAnnouncement_LambdaJob0_profilerMarker");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SendServerIsRestartingAnnouncement_LambdaJob0_entityQuery");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SendServerIsRestartingAnnouncement_LambdaJob0_profilerMarker");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>PrintRespawnTimers_LambdaJob0_entityQuery");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>PrintRespawnTimers_LambdaJob0_profilerMarker");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SetWallpaper_LambdaJob0_entityQuery");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SetWallpaper_LambdaJob0_profilerMarker");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SetWallpaper_LambdaJob1_entityQuery");
      ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>SetWallpaper_LambdaJob1_profilerMarker");
      ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_1));
      ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_DebugShowPhysicsCasts_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DebugShowPhysicsCasts_2));
      ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_PersistenceDebuggingSingleton_3));
      ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_4));
      ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_5));
      ServerConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663874);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663875);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_AppendUsers_Public_Static_Void_World_StringBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663876);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipBagSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663877);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipBag_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663878);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipJewelSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663879);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_EquipJewel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663880);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_UnequipJewel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663881);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_SpellModSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663882);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_AbilitiesWithSpellModsSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663883);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_HardCoreTest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663884);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_TestCollecitonChecks_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663885);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_SendServerAnnouncement_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663886);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_SendServerIsRestartingAnnouncement_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663887);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_SetGameplayDebuggerState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663888);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_TestCollectionChecks_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663889);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_TestCollectionChecks2_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663890);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_LogStatChanges_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663891);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_InterruptAbilityServer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663892);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowPhysicsCasts_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663893);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ClearAbilityGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663894);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_GetAbilityGroupsSuggestion_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663895);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_PersistenceDebuggingEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663896);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_SetAbilityGroup_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663897);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_Respawn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663898);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ResetCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663899);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_GetAllValidEvents_Private_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663900);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_CreateCrappyEvents_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663901);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_TryFindFieldOfType_Private_Static_Boolean_Type_ptr_Byte_byref_ptr_TFieldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663902);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_PrintRespawnTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663903);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_SetWallpaper_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663904);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowPlacement_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663905);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowTileCollisionHistory_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663906);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowTranslations_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663907);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowTranslationsLocalToWorldDiff_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663908);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowHeight_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663909);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowMapCollisionRadius_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663910);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowSunDamageRays_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663911);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowRoofDebug_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663912);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_LogPrioritization_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663913);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowWorldPathfindingBounds_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663914);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowWorldTileCollisionBounds_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663915);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_TeleportToPatrol_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663916);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_TeleportToPatrolArgumentHandling_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663917);
      ServerConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663918);
      ServerConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663919);
      ServerConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663920);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663921);
      ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663922);
      ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendServerAnnouncement_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663923);
      ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendServerIsRestartingAnnouncement_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663924);
      ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintRespawnTimers_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663925);
      ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetWallpaper_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663926);
      ServerConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetWallpaper_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663927);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663928);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663929);
      ServerConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, 100663930);
    }

    public ServerConsoleCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __TestCollecitonChecks_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___TestCollecitonChecks_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___TestCollecitonChecks_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SendServerAnnouncement_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SendServerAnnouncement_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerAnnouncement_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SendServerIsRestartingAnnouncement_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SendServerIsRestartingAnnouncement_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SendServerIsRestartingAnnouncement_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __PrintRespawnTimers_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __PrintRespawnTimers_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___PrintRespawnTimers_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SetWallpaper_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetWallpaper_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SetWallpaper_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetWallpaper_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr___SetWallpaper_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_1
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DebugShowPhysicsCasts_2
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_DebugShowPhysicsCasts_2));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_DebugShowPhysicsCasts_2)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_PersistenceDebuggingSingleton_3
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_3));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_PersistenceDebuggingSingleton_3)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_4
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_4));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_4)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_5
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_5));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_5)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collection;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AbilitiesWithSpellModsSuggestions_b__0_Internal_Void_Entity_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AbilitiesWithSpellModsSuggestions_b__0(Entity entity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__AbilitiesWithSpellModsSuggestions_b__0_Internal_Void_Entity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (collection));
        ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663931);
        ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__AbilitiesWithSpellModsSuggestions_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663932);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass9_0>.NativeClassPtr, data));
      }

      public unsafe ArgumentSuggestionCollection collection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_collection));
          return pointer == System.IntPtr.Zero ? (ArgumentSuggestionCollection) null : new ArgumentSuggestionCollection(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/<>c__DisplayClass11_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass11_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mode;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_singletonEntityWithoutPrefabGuid;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TestCollecitonChecks_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public int mode;
      [FieldOffset(8)]
      public ComponentDataFromEntity<PrefabGUID> getPrefabGuid;
      [FieldOffset(40)]
      public Entity singletonEntityWithoutPrefabGuid;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TestCollecitonChecks_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__TestCollecitonChecks_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (mode));
        ServerConsoleCommandSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_getPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (getPrefabGuid));
        ServerConsoleCommandSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_singletonEntityWithoutPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (singletonEntityWithoutPrefabGuid));
        ServerConsoleCommandSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr, 100663933);
        ServerConsoleCommandSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__TestCollecitonChecks_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr, 100663934);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass11_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_message;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SendServerAnnouncement_b__0_Internal_Void_byref_User_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SendServerAnnouncement_b__0([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__SendServerAnnouncement_b__0_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (message));
        ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, 100663935);
        ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__SendServerAnnouncement_b__0_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, 100663936);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass12_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, data));
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string message
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_message)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/<>c__DisplayClass13_0")]
    public sealed class __c__DisplayClass13_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_evt;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SendServerIsRestartingAnnouncement_b__0_Internal_Void_byref_User_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SendServerIsRestartingAnnouncement_b__0([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__SendServerIsRestartingAnnouncement_b__0_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (evt));
        ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, 100663937);
        ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__SendServerIsRestartingAnnouncement_b__0_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, 100663938);
      }

      public __c__DisplayClass13_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass13_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, data));
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerIsRestartingServerEvent evt
      {
        get
        {
          return *(ServerIsRestartingServerEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_evt));
        }
        [param: In] set
        {
          *(ServerIsRestartingServerEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_evt)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/<>c__DisplayClass23_0")]
    public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ability;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetAbilityGroup_b__0_Internal_Boolean_KeyValuePair_2_String_PrefabGUID_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass23_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650285, XrefRangeEnd = 1650291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _SetAbilityGroup_b__0(KeyValuePair<string, PrefabGUID> nameAndGuid)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) nameAndGuid));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__SetAbilityGroup_b__0_Internal_Boolean_KeyValuePair_2_String_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass23_0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass23_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (ability));
        ServerConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, 100663939);
        ServerConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__SetAbilityGroup_b__0_Internal_Boolean_KeyValuePair_2_String_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, 100663940);
      }

      public __c__DisplayClass23_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string ability
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_ability)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_ability), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/<>c__DisplayClass29_0")]
    public sealed class __c__DisplayClass29_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintRespawnTimers_b__0_Internal_Void_Entity_byref_UnitCompositionSpawnerDebugName_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass29_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PrintRespawnTimers_b__0(
        Entity entity,
        [In] ref UnitCompositionSpawnerDebugName name,
        [In] ref UnitCompositionSpawner compositionSpawner,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__PrintRespawnTimers_b__0_Internal_Void_Entity_byref_UnitCompositionSpawnerDebugName_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass29_0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass29_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (prefabLookupMap));
        ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (dayNightCycle));
        ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (serverTime));
        ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, 100663941);
        ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__PrintRespawnTimers_b__0_Internal_Void_Entity_byref_UnitCompositionSpawnerDebugName_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, 100663942);
      }

      public __c__DisplayClass29_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass29_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass29_0>.NativeClassPtr, data));
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe DayNightCycle dayNightCycle
      {
        get
        {
          return *(DayNightCycle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_dayNightCycle));
        }
        [param: In] set
        {
          *(DayNightCycle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_dayNightCycle)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/<>c__DisplayClass30_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass30_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_styleIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetWallpaper_b__0_Internal_Void_byref_Wallpaper_FourSplits_byref_WallpaperStyles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetWallpaper_b__1_Internal_Void_byref_Wallpaper_TwoSplits_byref_WallpaperStyles_0;
      [FieldOffset(0)]
      public int styleIndex;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass30_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetWallpaper_b__0(
        ref Wallpaper_FourSplits wallpaper,
        [In] ref WallpaperStyles styles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref wallpaper;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref styles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__SetWallpaper_b__0_Internal_Void_byref_Wallpaper_FourSplits_byref_WallpaperStyles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetWallpaper_b__1(
        ref Wallpaper_TwoSplits wallpaper,
        [In] ref WallpaperStyles styles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref wallpaper;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref styles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__SetWallpaper_b__1_Internal_Void_byref_Wallpaper_TwoSplits_byref_WallpaperStyles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass30_0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass30_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass30_0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass30_0.NativeFieldInfoPtr_styleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass30_0>.NativeClassPtr, nameof (styleIndex));
        ServerConsoleCommandSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass30_0>.NativeClassPtr, 100663943);
        ServerConsoleCommandSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__SetWallpaper_b__0_Internal_Void_byref_Wallpaper_FourSplits_byref_WallpaperStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass30_0>.NativeClassPtr, 100663944);
        ServerConsoleCommandSystem.__c__DisplayClass30_0.NativeMethodInfoPtr__SetWallpaper_b__1_Internal_Void_byref_Wallpaper_TwoSplits_byref_WallpaperStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass30_0>.NativeClassPtr, 100663945);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass30_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0")]
    public sealed class __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collection;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650295, RefRangeEnd = 1650296, XrefRangeStart = 1650291, XrefRangeEnd = 1650295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 773407, RefRangeEnd = 773412, XrefRangeStart = 773407, XrefRangeEnd = 773412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 773414, RefRangeEnd = 773422, XrefRangeStart = 773414, XrefRangeEnd = 773422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650296, XrefRangeEnd = 1650298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650301, RefRangeEnd = 1650302, XrefRangeStart = 1650298, XrefRangeEnd = 1650301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650304, RefRangeEnd = 1650305, XrefRangeStart = 1650302, XrefRangeEnd = 1650304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerConsoleCommandSystem componentSystem,
        ref ServerConsoleCommandSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650305, XrefRangeEnd = 1650311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (collection));
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663946);
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663947);
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663948);
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663949);
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663950);
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663951);
        ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663952);
      }

      public __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ArgumentSuggestionCollection collection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection));
          return pointer == System.IntPtr.Zero ? (ArgumentSuggestionCollection) null : new ArgumentSuggestionCollection(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663953);
          ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663954);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_TestCollecitonChecks_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TestCollecitonChecks_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mode;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_singletonEntityWithoutPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public int mode;
      [FieldOffset(8)]
      public ComponentDataFromEntity<PrefabGUID> getPrefabGuid;
      [FieldOffset(40)]
      public Entity singletonEntityWithoutPrefabGuid;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650385, XrefRangeEnd = 1650405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650405, RefRangeEnd = 1650406, XrefRangeStart = 1650405, XrefRangeEnd = 1650405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650406, RefRangeEnd = 1650407, XrefRangeStart = 1650406, XrefRangeEnd = 1650406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650408, RefRangeEnd = 1650409, XrefRangeStart = 1650407, XrefRangeEnd = 1650408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650410, RefRangeEnd = 1650411, XrefRangeStart = 1650409, XrefRangeEnd = 1650410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerConsoleCommandSystem componentSystem,
        ref ServerConsoleCommandSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650411, XrefRangeEnd = 1650441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1650442, RefRangeEnd = 1650444, XrefRangeStart = 1650441, XrefRangeEnd = 1650442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TestCollecitonChecks_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_TestCollecitonChecks_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, nameof (mode));
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_getPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, nameof (getPrefabGuid));
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_singletonEntityWithoutPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, nameof (singletonEntityWithoutPrefabGuid));
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, 100663955);
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, 100663956);
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, 100663957);
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, 100663958);
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, 100663959);
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, 100663960);
        ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, 100663961);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_TestCollecitonChecks_LambdaJob0/ProjectM.RunWithoutJobSystem_00000265$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(11)]
        [CachedScanResults(RefRangeStart = 108813, RefRangeEnd = 108824, XrefRangeStart = 108813, XrefRangeEnd = 108824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000265$PostfixBurstDelegate");
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663962);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663963);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663964);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663965);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_TestCollecitonChecks_LambdaJob0/ProjectM.RunWithoutJobSystem_00000265$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650311, XrefRangeEnd = 1650325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650325, XrefRangeEnd = 1650343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650343, XrefRangeEnd = 1650358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650358, XrefRangeEnd = 1650385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000265$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663966);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663967);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663968);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663969);
          ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663971);
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
            IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_TestCollecitonChecks_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SendServerAnnouncement_LambdaJob0")]
    public sealed class __c__DisplayClass_SendServerAnnouncement_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_message;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass12_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650453, RefRangeEnd = 1650454, XrefRangeStart = 1650451, XrefRangeEnd = 1650453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 773407, RefRangeEnd = 773412, XrefRangeStart = 773407, XrefRangeEnd = 773412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass12_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 773414, RefRangeEnd = 773422, XrefRangeStart = 773414, XrefRangeEnd = 773422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass12_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650454, XrefRangeEnd = 1650464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650473, RefRangeEnd = 1650474, XrefRangeStart = 1650464, XrefRangeEnd = 1650473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1119866, RefRangeEnd = 1119869, XrefRangeStart = 1119866, XrefRangeEnd = 1119869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerConsoleCommandSystem componentSystem,
        ref ServerConsoleCommandSystem.__c__DisplayClass12_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass12_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SendServerAnnouncement_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_SendServerAnnouncement_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, nameof (message));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, 100663972);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, 100663973);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, 100663974);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, 100663976);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, 100663977);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, 100663978);
      }

      public __c__DisplayClass_SendServerAnnouncement_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SendServerAnnouncement_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string message
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr_message)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650444, XrefRangeEnd = 1650447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650447, XrefRangeEnd = 1650451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663979);
          ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663980);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0")]
    public sealed class __c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_evt;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass13_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650481, XrefRangeEnd = 1650486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 985874, RefRangeEnd = 985876, XrefRangeStart = 985874, XrefRangeEnd = 985876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650486, XrefRangeEnd = 1650499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650508, RefRangeEnd = 1650509, XrefRangeStart = 1650499, XrefRangeEnd = 1650508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 985897, RefRangeEnd = 985899, XrefRangeStart = 985897, XrefRangeEnd = 985899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerConsoleCommandSystem componentSystem,
        ref ServerConsoleCommandSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, nameof (evt));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, 100663981);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, 100663982);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, 100663983);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, 100663985);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, 100663986);
        ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, 100663987);
      }

      public __c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerIsRestartingServerEvent evt
      {
        get
        {
          return *(ServerIsRestartingServerEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr_evt));
        }
        [param: In] set
        {
          *(ServerIsRestartingServerEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr_evt)) = value;
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650474, XrefRangeEnd = 1650477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650477, XrefRangeEnd = 1650481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663988);
          ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663989);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SendServerIsRestartingAnnouncement_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_PrintRespawnTimers_LambdaJob0")]
    public sealed class __c__DisplayClass_PrintRespawnTimers_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_dayNightCycle;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_UnitUptimeSetting_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawnerDebugName_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650642, RefRangeEnd = 1650643, XrefRangeStart = 1650531, XrefRangeEnd = 1650642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref UnitCompositionSpawnerDebugName name,
        [In] ref UnitCompositionSpawner compositionSpawner,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref compositionSpawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawnerDebugName_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650644, RefRangeEnd = 1650645, XrefRangeStart = 1650643, XrefRangeEnd = 1650644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass29_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650646, RefRangeEnd = 1650647, XrefRangeStart = 1650645, XrefRangeEnd = 1650646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass29_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650647, XrefRangeEnd = 1650649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650661, RefRangeEnd = 1650662, XrefRangeStart = 1650649, XrefRangeEnd = 1650661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650667, RefRangeEnd = 1650668, XrefRangeStart = 1650662, XrefRangeEnd = 1650667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerConsoleCommandSystem componentSystem,
        ref ServerConsoleCommandSystem.__c__DisplayClass29_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass29_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650668, XrefRangeEnd = 1650674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PrintRespawnTimers_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_PrintRespawnTimers_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (prefabLookupMap));
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_dayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (dayNightCycle));
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (serverTime));
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, "<>4__this");
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitUptimeSetting_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_UnitUptimeSetting_0));
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitCompositionSpawnerDebugName_byref_UnitCompositionSpawner_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, 100663990);
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, 100663991);
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, 100663992);
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, 100663993);
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, 100663994);
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, 100663995);
        ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, 100663996);
      }

      public __c__DisplayClass_PrintRespawnTimers_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_PrintRespawnTimers_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe DayNightCycle dayNightCycle
      {
        get
        {
          return *(DayNightCycle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_dayNightCycle));
        }
        [param: In] set
        {
          *(DayNightCycle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_dayNightCycle)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe ServerConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerConsoleCommandSystem) null : new ServerConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentDataFromEntity<UnitUptimeSetting> _ComponentDataFromEntity_UnitUptimeSetting_0
      {
        get
        {
          return *(ComponentDataFromEntity<UnitUptimeSetting>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitUptimeSetting_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitUptimeSetting_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<UnitUptimeSetting>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_name;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_compositionSpawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawnerDebugName> forParameter_name;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_compositionSpawner;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1650519, RefRangeEnd = 1650520, XrefRangeStart = 1650509, XrefRangeEnd = 1650519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1650530, RefRangeEnd = 1650531, XrefRangeStart = 1650520, XrefRangeEnd = 1650530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_name));
          ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_compositionSpawner));
          ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663997);
          ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663998);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_name;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_compositionSpawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawnerDebugName>.Runtime runtime_name;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_compositionSpawner;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_name));
            ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_compositionSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_compositionSpawner));
            ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_PrintRespawnTimers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SetWallpaper_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetWallpaper_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_styleIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Wallpaper_FourSplits_byref_WallpaperStyles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int styleIndex;
      [FieldOffset(8)]
      public ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650761, XrefRangeEnd = 1650765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref Wallpaper_FourSplits wallpaper,
        [In] ref WallpaperStyles styles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref wallpaper;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref styles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Wallpaper_FourSplits_byref_WallpaperStyles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 979865, RefRangeEnd = 979889, XrefRangeStart = 979865, XrefRangeEnd = 979889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(21)]
      [CachedScanResults(RefRangeStart = 979889, RefRangeEnd = 979910, XrefRangeStart = 979889, XrefRangeEnd = 979910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650765, XrefRangeEnd = 1650772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650780, RefRangeEnd = 1650781, XrefRangeStart = 1650772, XrefRangeEnd = 1650780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650788, RefRangeEnd = 1650789, XrefRangeStart = 1650781, XrefRangeEnd = 1650788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerConsoleCommandSystem componentSystem,
        ref ServerConsoleCommandSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650789, XrefRangeEnd = 1650793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650793, XrefRangeEnd = 1650799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetWallpaper_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_SetWallpaper_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr_styleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, nameof (styleIndex));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Wallpaper_FourSplits_byref_WallpaperStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100663999);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100664000);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100664001);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100664002);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100664003);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100664004);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100664005);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, 100664006);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_wallpaper;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_styles;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Wallpaper_FourSplits> forParameter_wallpaper;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<WallpaperStyles> forParameter_styles;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650674, XrefRangeEnd = 1650680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650680, XrefRangeEnd = 1650686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_wallpaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_wallpaper));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_styles));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664007);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664008);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_wallpaper;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_styles;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Wallpaper_FourSplits>.Runtime runtime_wallpaper;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<WallpaperStyles>.Runtime runtime_styles;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_wallpaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_wallpaper));
            ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_styles));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SetWallpaper_LambdaJob0/ProjectM.RunWithoutJobSystem_00000287$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000287$PostfixBurstDelegate");
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664009);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664010);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664011);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664012);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SetWallpaper_LambdaJob0/ProjectM.RunWithoutJobSystem_00000287$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650686, XrefRangeEnd = 1650700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650700, XrefRangeEnd = 1650718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650718, XrefRangeEnd = 1650733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1650760, RefRangeEnd = 1650761, XrefRangeStart = 1650733, XrefRangeEnd = 1650760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000287$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664013);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664014);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664015);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664016);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664018);
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
            IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SetWallpaper_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetWallpaper_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_styleIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Wallpaper_TwoSplits_byref_WallpaperStyles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass30_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int styleIndex;
      [FieldOffset(8)]
      public ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650886, XrefRangeEnd = 1650890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref Wallpaper_TwoSplits wallpaper,
        [In] ref WallpaperStyles styles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref wallpaper;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref styles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Wallpaper_TwoSplits_byref_WallpaperStyles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 979865, RefRangeEnd = 979889, XrefRangeStart = 979865, XrefRangeEnd = 979889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(21)]
      [CachedScanResults(RefRangeStart = 979889, RefRangeEnd = 979910, XrefRangeStart = 979889, XrefRangeEnd = 979910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerConsoleCommandSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650890, XrefRangeEnd = 1650897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650905, RefRangeEnd = 1650906, XrefRangeStart = 1650897, XrefRangeEnd = 1650905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1650913, RefRangeEnd = 1650914, XrefRangeStart = 1650906, XrefRangeEnd = 1650913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerConsoleCommandSystem componentSystem,
        ref ServerConsoleCommandSystem.__c__DisplayClass30_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass30_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650914, XrefRangeEnd = 1650918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650918, XrefRangeEnd = 1650924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetWallpaper_LambdaJob1()
      {
        Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_SetWallpaper_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr_styleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, nameof (styleIndex));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Wallpaper_TwoSplits_byref_WallpaperStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664019);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664020);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664021);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664022);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664023);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_byref___c__DisplayClass30_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664024);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664025);
        ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, 100664026);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_wallpaper;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_styles;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Wallpaper_TwoSplits> forParameter_wallpaper;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<WallpaperStyles> forParameter_styles;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650799, XrefRangeEnd = 1650805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650805, XrefRangeEnd = 1650811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_wallpaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_wallpaper));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_styles));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100664027);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100664028);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_wallpaper;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_styles;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Wallpaper_TwoSplits>.Runtime runtime_wallpaper;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<WallpaperStyles>.Runtime runtime_styles;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_wallpaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_wallpaper));
            ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_styles));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SetWallpaper_LambdaJob1/ProjectM.RunWithoutJobSystem_00000290$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000290$PostfixBurstDelegate");
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664029);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664030);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664031);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664032);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ServerConsoleCommandSystem/ProjectM.<>c__DisplayClass_SetWallpaper_LambdaJob1/ProjectM.RunWithoutJobSystem_00000290$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650811, XrefRangeEnd = 1650825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650825, XrefRangeEnd = 1650843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1650843, XrefRangeEnd = 1650858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1650885, RefRangeEnd = 1650886, XrefRangeStart = 1650858, XrefRangeEnd = 1650885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000290$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664033);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664034);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664035);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664036);
          ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664038);
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
            IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServerConsoleCommandSystem.__c__DisplayClass_SetWallpaper_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_TryFindFieldOfType_Private_Static_Boolean_Type_ptr_Byte_byref_ptr_TFieldType_0<TFieldType>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerConsoleCommandSystem.NativeMethodInfoPtr_TryFindFieldOfType_Private_Static_Boolean_Type_ptr_Byte_byref_ptr_TFieldType_0, Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldType>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ShowWorldTileCollisionBounds_Private_Void_Int32_0<TDebugWorldTileBounds>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ServerConsoleCommandSystem.NativeMethodInfoPtr_ShowWorldTileCollisionBounds_Private_Void_Int32_0, Il2CppClassPointerStore<ServerConsoleCommandSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDebugWorldTileBounds>.NativeClassPtr))
      }))));
    }
  }
}
