// Decompiled with JetBrains decompiler
// Type: ProjectM.GiveInventoryItemCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class GiveInventoryItemCommandSystem : GameplayConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupArgumentSuggestions_Items_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupArgumentSuggestions_ItemSets_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GiveSet_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Give_Private_Void_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateJewel_Private_Void_String_String_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndEquipJewel_Private_Void_String_String_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCreateJewelParameters_Private_Boolean_String_String_Int32_Single_byref_PrefabGUID_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AbilitiesWithSpellModsSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LegendaryWeaponsSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpellModSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TierSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateJewelAtUnitLevel_Private_Void_Int32_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateJewel_Private_Void_String_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateLegendaryWeapon_Private_Void_String_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForLegendaryWeaponsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644541, XrefRangeEnd = 1644551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GiveInventoryItemCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644551, XrefRangeEnd = 1644786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GiveInventoryItemCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GiveInventoryItemCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644786, XrefRangeEnd = 1644882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupArgumentSuggestions_Items(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_SetupArgumentSuggestions_Items_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644882, XrefRangeEnd = 1644911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupArgumentSuggestions_ItemSets(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_SetupArgumentSuggestions_ItemSets_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644911, XrefRangeEnd = 1644995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GiveSet(string itemSet)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(itemSet);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GiveSet_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644995, XrefRangeEnd = 1645010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Give(string item, int giveAmount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(item);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &giveAmount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_Give_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645010, XrefRangeEnd = 1645015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateJewel(string abilityName, string spellMod, int tier, float power)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(spellMod);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &power;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_CreateJewel_Private_Void_String_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645015, XrefRangeEnd = 1645020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateAndEquipJewel(
      string abilityName,
      string spellMod,
      int tier,
      float power)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(spellMod);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &power;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_CreateAndEquipJewel_Private_Void_String_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1645051, RefRangeEnd = 1645053, XrefRangeStart = 1645020, XrefRangeEnd = 1645051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckCreateJewelParameters(
      string abilityName,
      string spellMod,
      int tier,
      float power,
      out PrefabGUID abilityPrefabGuid,
      out PrefabGUID spellModGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(spellMod);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &power;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellModGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_CheckCreateJewelParameters_Private_Boolean_String_String_Int32_Single_byref_PrefabGUID_byref_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645053, XrefRangeEnd = 1645072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AbilitiesWithSpellModsSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_AbilitiesWithSpellModsSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645072, XrefRangeEnd = 1645091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LegendaryWeaponsSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_LegendaryWeaponsSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645091, XrefRangeEnd = 1645127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SpellModSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_SpellModSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645127, XrefRangeEnd = 1645143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TierSuggestions(ArgumentSuggestionCollection collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_TierSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645143, XrefRangeEnd = 1645152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateJewelAtUnitLevel(
      int unitLevel,
      Nullable_Unboxed<float> overridePower = default (Nullable_Unboxed<float>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &unitLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &overridePower;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GenerateJewelAtUnitLevel_Private_Void_Int32_Nullable_Unboxed_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645152, XrefRangeEnd = 1645176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateJewel(
      string abilityName,
      Nullable_Unboxed<int> tier = default (Nullable_Unboxed<int>),
      Nullable_Unboxed<float> overridePower = default (Nullable_Unboxed<float>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(abilityName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &overridePower;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GenerateJewel_Private_Void_String_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645176, XrefRangeEnd = 1645196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateLegendaryWeapon(
      string itemName,
      Nullable_Unboxed<float> overridePower = default (Nullable_Unboxed<float>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(itemName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &overridePower;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GenerateLegendaryWeapon_Private_Void_String_Nullable_Unboxed_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GiveInventoryItemCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645196, XrefRangeEnd = 1645222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GiveInventoryItemCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1645247, RefRangeEnd = 1645248, XrefRangeStart = 1645222, XrefRangeEnd = 1645247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1645270, RefRangeEnd = 1645271, XrefRangeStart = 1645248, XrefRangeEnd = 1645270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForLegendaryWeaponsSuggestions_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForLegendaryWeaponsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GiveInventoryItemCommandSystem()
    {
      Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (GiveInventoryItemCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr);
      GiveInventoryItemCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      GiveInventoryItemCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      GiveInventoryItemCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery");
      GiveInventoryItemCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker");
      GiveInventoryItemCommandSystem.NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>LegendaryWeaponsSuggestions_LambdaJob0_entityQuery");
      GiveInventoryItemCommandSystem.NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>LegendaryWeaponsSuggestions_LambdaJob0_profilerMarker");
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663631);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663632);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663633);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_SetupArgumentSuggestions_Items_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663634);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_SetupArgumentSuggestions_ItemSets_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663635);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GiveSet_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663636);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_Give_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663637);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_CreateJewel_Private_Void_String_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663638);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_CreateAndEquipJewel_Private_Void_String_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663639);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_CheckCreateJewelParameters_Private_Boolean_String_String_Int32_Single_byref_PrefabGUID_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663640);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_AbilitiesWithSpellModsSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663641);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_LegendaryWeaponsSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663642);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_SpellModSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663643);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_TierSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663644);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GenerateJewelAtUnitLevel_Private_Void_Int32_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663645);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GenerateJewel_Private_Void_String_Nullable_Unboxed_1_Int32_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663646);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_GenerateLegendaryWeapon_Private_Void_String_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663647);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663648);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663649);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForAbilitiesWithSpellModsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663650);
      GiveInventoryItemCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForLegendaryWeaponsSuggestions_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, 100663651);
    }

    public GiveInventoryItemCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___AbilitiesWithSpellModsSuggestions_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __LegendaryWeaponsSuggestions_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __LegendaryWeaponsSuggestions_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.NativeFieldInfoPtr___LegendaryWeaponsSuggestions_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.GiveInventoryItemCommandSystem/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_name;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GiveSet_b__0_Internal_Boolean_KeyValuePair_2_String_PrefabGUID_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644435, XrefRangeEnd = 1644445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _GiveSet_b__0(KeyValuePair<string, PrefabGUID> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__GiveSet_b__0_Internal_Boolean_KeyValuePair_2_String_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass7_0>.NativeClassPtr);
        GiveInventoryItemCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (name));
        GiveInventoryItemCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, 100663652);
        GiveInventoryItemCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__GiveSet_b__0_Internal_Boolean_KeyValuePair_2_String_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, 100663653);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.GiveInventoryItemCommandSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GiveSet_b__7_1_Internal_PrefabGUID_KeyValuePair_2_String_PrefabGUID_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644445, XrefRangeEnd = 1644446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabGUID _GiveSet_b__7_1(KeyValuePair<string, PrefabGUID> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c.NativeMethodInfoPtr__GiveSet_b__7_1_Internal_PrefabGUID_KeyValuePair_2_String_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c>.NativeClassPtr);
        GiveInventoryItemCommandSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c>.NativeClassPtr, "<>9");
        GiveInventoryItemCommandSystem.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c>.NativeClassPtr, "<>9__7_1");
        GiveInventoryItemCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c>.NativeClassPtr, 100663655);
        GiveInventoryItemCommandSystem.__c.NativeMethodInfoPtr__GiveSet_b__7_1_Internal_PrefabGUID_KeyValuePair_2_String_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c>.NativeClassPtr, 100663656);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GiveInventoryItemCommandSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GiveInventoryItemCommandSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (GiveInventoryItemCommandSystem.__c) null : new GiveInventoryItemCommandSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GiveInventoryItemCommandSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair<string, PrefabGUID>, PrefabGUID> __9__7_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GiveInventoryItemCommandSystem.__c.NativeFieldInfoPtr___9__7_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, PrefabGUID>, PrefabGUID>) null : new Il2CppSystem.Func<KeyValuePair<string, PrefabGUID>, PrefabGUID>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GiveInventoryItemCommandSystem.__c.NativeFieldInfoPtr___9__7_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.GiveInventoryItemCommandSystem/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_collection;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AbilitiesWithSpellModsSuggestions_b__0_Internal_Void_Entity_byref_PrefabGUID_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AbilitiesWithSpellModsSuggestions_b__0(
        Entity entity,
        [In] ref PrefabGUID prefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__AbilitiesWithSpellModsSuggestions_b__0_Internal_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr);
        GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (collection));
        GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, 100663657);
        GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__AbilitiesWithSpellModsSuggestions_b__0_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, 100663658);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass12_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass12_0>.NativeClassPtr, data));
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ArgumentSuggestionCollection collection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collection));
          return pointer == System.IntPtr.Zero ? (ArgumentSuggestionCollection) null : new ArgumentSuggestionCollection(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.GiveInventoryItemCommandSystem/<>c__DisplayClass13_0")]
    public sealed class __c__DisplayClass13_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_collection;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__LegendaryWeaponsSuggestions_b__0_Internal_Void_Entity_byref_PrefabGUID_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _LegendaryWeaponsSuggestions_b__0(Entity entity, [In] ref PrefabGUID prefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__LegendaryWeaponsSuggestions_b__0_Internal_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr);
        GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (collection));
        GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, 100663659);
        GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__LegendaryWeaponsSuggestions_b__0_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, 100663660);
      }

      public __c__DisplayClass13_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass13_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass13_0>.NativeClassPtr, data));
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ArgumentSuggestionCollection collection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_collection));
          return pointer == System.IntPtr.Zero ? (ArgumentSuggestionCollection) null : new ArgumentSuggestionCollection(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.GiveInventoryItemCommandSystem/ProjectM.<>c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0")]
    public sealed class __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_collection;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1644474, RefRangeEnd = 1644475, XrefRangeStart = 1644456, XrefRangeEnd = 1644474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref PrefabGUID prefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 773407, RefRangeEnd = 773412, XrefRangeStart = 773407, XrefRangeEnd = 773412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GiveInventoryItemCommandSystem.__c__DisplayClass12_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 773414, RefRangeEnd = 773422, XrefRangeStart = 773414, XrefRangeEnd = 773422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GiveInventoryItemCommandSystem.__c__DisplayClass12_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1644477, RefRangeEnd = 1644478, XrefRangeStart = 1644475, XrefRangeEnd = 1644477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1644484, RefRangeEnd = 1644485, XrefRangeStart = 1644478, XrefRangeEnd = 1644484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1644487, RefRangeEnd = 1644488, XrefRangeStart = 1644485, XrefRangeEnd = 1644487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GiveInventoryItemCommandSystem componentSystem,
        ref GiveInventoryItemCommandSystem.__c__DisplayClass12_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_byref___c__DisplayClass12_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644488, XrefRangeEnd = 1644494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0()
      {
        Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr);
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (prefabCollectionSystem));
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (collection));
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663661);
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663662);
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663663);
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663664);
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663665);
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663666);
        GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, 100663667);
      }

      public __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ArgumentSuggestionCollection collection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection));
          return pointer == System.IntPtr.Zero ? (ArgumentSuggestionCollection) null : new ArgumentSuggestionCollection(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1644450, RefRangeEnd = 1644451, XrefRangeStart = 1644446, XrefRangeEnd = 1644450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GiveInventoryItemCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1644455, RefRangeEnd = 1644456, XrefRangeStart = 1644451, XrefRangeEnd = 1644455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefab));
          GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663668);
          GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663669);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_AbilitiesWithSpellModsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GiveInventoryItemCommandSystem/ProjectM.<>c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0")]
    public sealed class __c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_collection;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1644522, RefRangeEnd = 1644523, XrefRangeStart = 1644504, XrefRangeEnd = 1644522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref PrefabGUID prefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 773407, RefRangeEnd = 773412, XrefRangeStart = 773407, XrefRangeEnd = 773412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GiveInventoryItemCommandSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 773414, RefRangeEnd = 773422, XrefRangeStart = 773414, XrefRangeEnd = 773422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GiveInventoryItemCommandSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644523, XrefRangeEnd = 1644525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1644531, RefRangeEnd = 1644532, XrefRangeStart = 1644525, XrefRangeEnd = 1644531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1644534, RefRangeEnd = 1644535, XrefRangeStart = 1644532, XrefRangeEnd = 1644534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GiveInventoryItemCommandSystem componentSystem,
        ref GiveInventoryItemCommandSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644535, XrefRangeEnd = 1644541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0()
      {
        Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem>.NativeClassPtr, "<>c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr);
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, nameof (prefabCollectionSystem));
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, nameof (collection));
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, 100663670);
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, 100663671);
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, 100663672);
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, 100663673);
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, 100663674);
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, 100663675);
        GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, 100663676);
      }

      public __c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ArgumentSuggestionCollection collection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection));
          return pointer == System.IntPtr.Zero ? (ArgumentSuggestionCollection) null : new ArgumentSuggestionCollection(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1644498, RefRangeEnd = 1644499, XrefRangeStart = 1644494, XrefRangeEnd = 1644498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GiveInventoryItemCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1644503, RefRangeEnd = 1644504, XrefRangeStart = 1644499, XrefRangeEnd = 1644503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefab));
          GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GiveInventoryItemCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663677);
          GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663678);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GiveInventoryItemCommandSystem.__c__DisplayClass_LegendaryWeaponsSuggestions_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
