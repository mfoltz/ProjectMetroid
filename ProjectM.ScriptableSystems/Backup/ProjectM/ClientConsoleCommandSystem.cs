// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientConsoleCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using ProjectM.Network;
using ProjectM.Terrain;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM
{
  public class ClientConsoleCommandSystem : GameplayConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientWorldManager;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintSequences_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintSequences_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Interpolation_SetDuration_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Interpolation_ExtrapolateOnFail_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideCursor_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdminAuth_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintActiveSequences_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintSequences_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintActiveSounds_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpCameraValues_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFSRQualityModeSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUpscaleFilterModeSuggestions_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentMipBias_Private_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DetermineFSRQualityMode_Private_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAntialiasingData_Private_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFilterName_Private_String_DynamicResUpscaleFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintDynamicResSettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DepthOfField_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MotionBlur_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UseHybridModelStreaming_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPositionDump_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyDebugDump_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveSequencesLogPublicVersion_Private_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClientBuildingDebugging_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintSunVFXStatePublicVersion_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildClientGraphicsSettingsLog_Private_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogVFXInstanceDebugData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDebugDump_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugDump_Private_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePerformanceDump_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceDump_Private_ValueTuple_2_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpVersionInfo_Private_Void_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpSettings_Private_Void_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpPlayerInfo_Private_Void_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityName_Private_String_PrefabCollectionSystem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpNetworkInfo_Private_Void_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpWorldInfo_Private_Void_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendTranslation_Private_Void_StringBuilder_String_Entity_TerrainManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InvitePlayer_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AcceptClanInvite_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeclineClanInvite_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LeaveClan_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disconnect_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OcclusionCulling_Enable_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OcclusionCullingDebug_Enable_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Private_Void_ArgumentSuggestionCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPrintActiveSequences_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPrintSequences_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetActiveSequencesLogPublicVersion_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPrintSunVFXStatePublicVersion_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetPerformanceDump_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAcceptClanInvite_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDeclineClanInvite_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641230, XrefRangeEnd = 1641584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641584, XrefRangeEnd = 1641585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Interpolation_SetDuration(int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_Interpolation_SetDuration_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641585, XrefRangeEnd = 1641586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Interpolation_ExtrapolateOnFail(bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_Interpolation_ExtrapolateOnFail_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641586, XrefRangeEnd = 1641588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetHideCursor(bool hideCursor)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hideCursor;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_SetHideCursor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641588, XrefRangeEnd = 1641592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AdminAuth()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_AdminAuth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1641622, RefRangeEnd = 1641623, XrefRangeStart = 1641592, XrefRangeEnd = 1641622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintActiveSequences()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintActiveSequences_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641623, XrefRangeEnd = 1641653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintSequences()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintSequences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1641659, RefRangeEnd = 1641660, XrefRangeStart = 1641653, XrefRangeEnd = 1641659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintActiveSounds()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintActiveSounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641660, XrefRangeEnd = 1641672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpCameraValues()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpCameraValues_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641672, XrefRangeEnd = 1641696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetFSRQualityModeSuggestions(ArgumentSuggestionCollection argCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) argCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetFSRQualityModeSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641696, XrefRangeEnd = 1641714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetUpscaleFilterModeSuggestions(ArgumentSuggestionCollection argCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) argCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetUpscaleFilterModeSuggestions_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641714, XrefRangeEnd = 1641718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCurrentMipBias(float factor)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &factor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetCurrentMipBias_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641718, XrefRangeEnd = 1641740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string DetermineFSRQualityMode(float factor)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &factor;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DetermineFSRQualityMode_Private_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641740, XrefRangeEnd = 1641761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetAntialiasingData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetAntialiasingData_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641761, XrefRangeEnd = 1641768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetFilterName(DynamicResUpscaleFilter filter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &filter;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetFilterName_Private_String_DynamicResUpscaleFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641768, XrefRangeEnd = 1641913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintDynamicResSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintDynamicResSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641913, XrefRangeEnd = 1641917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DepthOfField(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DepthOfField_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641917, XrefRangeEnd = 1641921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MotionBlur(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_MotionBlur_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641921, XrefRangeEnd = 1641922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UseHybridModelStreaming(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_UseHybridModelStreaming_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641922, XrefRangeEnd = 1641963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyPositionDump()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_CopyPositionDump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641963, XrefRangeEnd = 1641974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyDebugDump()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_CopyDebugDump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1641999, RefRangeEnd = 1642000, XrefRangeStart = 1641974, XrefRangeEnd = 1641999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetActiveSequencesLogPublicVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetActiveSequencesLogPublicVersion_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642000, XrefRangeEnd = 1642033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClientBuildingDebugging(bool enable)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enable;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_ClientBuildingDebugging_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642033, XrefRangeEnd = 1642191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintSunVFXStatePublicVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintSunVFXStatePublicVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642191, XrefRangeEnd = 1642322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string BuildClientGraphicsSettingsLog()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_BuildClientGraphicsSettingsLog_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642322, XrefRangeEnd = 1642332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogVFXInstanceDebugData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_LogVFXInstanceDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642332, XrefRangeEnd = 1642355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDebugDump()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_CreateDebugDump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1642403, RefRangeEnd = 1642405, XrefRangeStart = 1642355, XrefRangeEnd = 1642403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetDebugDump()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetDebugDump_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642405, XrefRangeEnd = 1642433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreatePerformanceDump()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_CreatePerformanceDump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1642503, RefRangeEnd = 1642504, XrefRangeStart = 1642433, XrefRangeEnd = 1642503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.ValueTuple<string, string> GetPerformanceDump()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetPerformanceDump_Private_ValueTuple_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.ValueTuple<string, string>(pointer);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpVersionInfo(StringBuilder sb)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpVersionInfo_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1642573, RefRangeEnd = 1642574, XrefRangeStart = 1642504, XrefRangeEnd = 1642573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpSettings(StringBuilder sb)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpSettings_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1642701, RefRangeEnd = 1642702, XrefRangeStart = 1642574, XrefRangeEnd = 1642701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpPlayerInfo(StringBuilder sb)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpPlayerInfo_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1642730, RefRangeEnd = 1642733, XrefRangeStart = 1642702, XrefRangeEnd = 1642730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetEntityName(PrefabCollectionSystem prefabCollectionSystem, Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_GetEntityName_Private_String_PrefabCollectionSystem_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1642790, RefRangeEnd = 1642791, XrefRangeStart = 1642733, XrefRangeEnd = 1642790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpNetworkInfo(StringBuilder sb)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpNetworkInfo_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1642920, RefRangeEnd = 1642921, XrefRangeStart = 1642791, XrefRangeEnd = 1642920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpWorldInfo(StringBuilder sb)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpWorldInfo_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1642995, RefRangeEnd = 1642997, XrefRangeStart = 1642921, XrefRangeEnd = 1642995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AppendTranslation(
      StringBuilder sb,
      string header,
      Entity entity,
      TerrainManager terrainManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(header);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_AppendTranslation_Private_Void_StringBuilder_String_Entity_TerrainManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642997, XrefRangeEnd = 1643002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InvitePlayer(string player)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(player);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_InvitePlayer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643002, XrefRangeEnd = 1643013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AcceptClanInvite()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_AcceptClanInvite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643013, XrefRangeEnd = 1643024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeclineClanInvite()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_DeclineClanInvite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643024, XrefRangeEnd = 1643037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LeaveClan()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_LeaveClan_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643037, XrefRangeEnd = 1643052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Disconnect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_Disconnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1643089, RefRangeEnd = 1643090, XrefRangeStart = 1643052, XrefRangeEnd = 1643089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Kill(string whoString, string whoFilter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whoString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(whoFilter);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_Kill_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643090, XrefRangeEnd = 1643111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Kill()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_Kill_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643111, XrefRangeEnd = 1643116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OcclusionCulling_Enable(bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_OcclusionCulling_Enable_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643116, XrefRangeEnd = 1643121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OcclusionCullingDebug_Enable(bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_OcclusionCullingDebug_Enable_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643121, XrefRangeEnd = 1643122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientConsoleCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643122, XrefRangeEnd = 1643159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreateConsoleCommands_b__1_0(ArgumentSuggestionCollection suggestions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Private_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643159, XrefRangeEnd = 1643293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1643315, RefRangeEnd = 1643316, XrefRangeStart = 1643293, XrefRangeEnd = 1643315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPrintActiveSequences_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintActiveSequences_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1643338, RefRangeEnd = 1643339, XrefRangeStart = 1643316, XrefRangeEnd = 1643338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPrintSequences_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintSequences_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1643361, RefRangeEnd = 1643362, XrefRangeStart = 1643339, XrefRangeEnd = 1643361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetActiveSequencesLogPublicVersion_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetActiveSequencesLogPublicVersion_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643362, XrefRangeEnd = 1643378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPrintSunVFXStatePublicVersion_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintSunVFXStatePublicVersion_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643378, XrefRangeEnd = 1643394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetPerformanceDump_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetPerformanceDump_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643394, XrefRangeEnd = 1643410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAcceptClanInvite_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForAcceptClanInvite_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643410, XrefRangeEnd = 1643426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDeclineClanInvite_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForDeclineClanInvite_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643426, XrefRangeEnd = 1643430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientConsoleCommandSystem()
    {
      Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (ClientConsoleCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr);
      ClientConsoleCommandSystem.NativeFieldInfoPtr__ClientWorldManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, nameof (_ClientWorldManager));
      ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>PrintActiveSequences_LambdaJob0_entityQuery");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>PrintActiveSequences_LambdaJob0_profilerMarker");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSequences_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>PrintSequences_LambdaJob0_entityQuery");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSequences_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>PrintSequences_LambdaJob0_profilerMarker");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>GetActiveSequencesLogPublicVersion_LambdaJob0_entityQuery");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>GetActiveSequencesLogPublicVersion_LambdaJob0_profilerMarker");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>PrintSunVFXStatePublicVersion_LambdaJob0_entityQuery");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>PrintSunVFXStatePublicVersion_LambdaJob0_profilerMarker");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>GetPerformanceDump_LambdaJob0_entityQuery");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>GetPerformanceDump_LambdaJob0_profilerMarker");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>AcceptClanInvite_LambdaJob0_entityQuery");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>AcceptClanInvite_LambdaJob0_profilerMarker");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>DeclineClanInvite_LambdaJob0_entityQuery");
      ClientConsoleCommandSystem.NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>DeclineClanInvite_LambdaJob0_profilerMarker");
      ClientConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663445);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663446);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_Interpolation_SetDuration_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663447);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_Interpolation_ExtrapolateOnFail_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663448);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_SetHideCursor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663449);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_AdminAuth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663450);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintActiveSequences_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663451);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintSequences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663452);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintActiveSounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663453);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpCameraValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663454);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetFSRQualityModeSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663455);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetUpscaleFilterModeSuggestions_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663456);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetCurrentMipBias_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663457);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DetermineFSRQualityMode_Private_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663458);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetAntialiasingData_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663459);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetFilterName_Private_String_DynamicResUpscaleFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663460);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintDynamicResSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663461);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DepthOfField_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663462);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_MotionBlur_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663463);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_UseHybridModelStreaming_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663464);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_CopyPositionDump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663465);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_CopyDebugDump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663466);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetActiveSequencesLogPublicVersion_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663467);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_ClientBuildingDebugging_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663468);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_PrintSunVFXStatePublicVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663469);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_BuildClientGraphicsSettingsLog_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663470);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_LogVFXInstanceDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663471);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_CreateDebugDump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663472);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetDebugDump_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663473);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_CreatePerformanceDump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663474);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetPerformanceDump_Private_ValueTuple_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663475);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpVersionInfo_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663476);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpSettings_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663477);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpPlayerInfo_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663478);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_GetEntityName_Private_String_PrefabCollectionSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663479);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpNetworkInfo_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663480);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DumpWorldInfo_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663481);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_AppendTranslation_Private_Void_StringBuilder_String_Entity_TerrainManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663482);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_InvitePlayer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663483);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_AcceptClanInvite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663484);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_DeclineClanInvite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663485);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_LeaveClan_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663486);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_Disconnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663487);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_Kill_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663488);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_Kill_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663489);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_OcclusionCulling_Enable_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663490);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_OcclusionCullingDebug_Enable_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663491);
      ClientConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663492);
      ClientConsoleCommandSystem.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Private_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663493);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663494);
      ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintActiveSequences_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663495);
      ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintSequences_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663496);
      ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetActiveSequencesLogPublicVersion_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663497);
      ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrintSunVFXStatePublicVersion_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663498);
      ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetPerformanceDump_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663499);
      ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForAcceptClanInvite_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663500);
      ClientConsoleCommandSystem.NativeMethodInfoPtr___GetEntityQuery_ForDeclineClanInvite_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663501);
      ClientConsoleCommandSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, 100663502);
    }

    public ClientConsoleCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClientWorldManager _ClientWorldManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr__ClientWorldManager));
        return pointer == System.IntPtr.Zero ? (ClientWorldManager) null : new ClientWorldManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr__ClientWorldManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __PrintActiveSequences_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __PrintActiveSequences_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintActiveSequences_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __PrintSequences_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSequences_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSequences_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __PrintSequences_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSequences_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSequences_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GetActiveSequencesLogPublicVersion_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetActiveSequencesLogPublicVersion_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetActiveSequencesLogPublicVersion_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __PrintSunVFXStatePublicVersion_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __PrintSunVFXStatePublicVersion_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___PrintSunVFXStatePublicVersion_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GetPerformanceDump_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetPerformanceDump_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___GetPerformanceDump_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __AcceptClanInvite_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AcceptClanInvite_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___AcceptClanInvite_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DeclineClanInvite_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DeclineClanInvite_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.NativeFieldInfoPtr___DeclineClanInvite_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sb;
      private static readonly System.IntPtr NativeFieldInfoPtr_count;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintActiveSequences_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceInstance_byref_SequenceAsset_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PrintActiveSequences_b__0(
        Entity entity,
        ref DynamicBuffer<EventStateElement> eventStateBuffer,
        [In] ref SequenceInstance sequenceInstance,
        [In] ref SequenceAsset sequenceAsset)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStateBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__PrintActiveSequences_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceInstance_byref_SequenceAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (sb));
        ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (count));
        ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, 100663503);
        ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__PrintActiveSequences_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceInstance_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, 100663504);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder sb
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_sb));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_count)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sb;
      private static readonly System.IntPtr NativeFieldInfoPtr_count;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSequences_b__0_Internal_Void_Entity_byref_PrefabGUID_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PrintSequences_b__0(Entity entity, [In] ref PrefabGUID prefabGuid)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__PrintSequences_b__0_Internal_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (sb));
        ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (count));
        ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr, 100663505);
        ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__PrintSequences_b__0_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr, 100663506);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder sb
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_sb));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_count)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/<>c__DisplayClass23_0")]
    public sealed class __c__DisplayClass23_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sb;
      private static readonly System.IntPtr NativeFieldInfoPtr_count;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetActiveSequencesLogPublicVersion_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceAsset_byref_SequenceInstance_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass23_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GetActiveSequencesLogPublicVersion_b__0(
        Entity entity,
        ref DynamicBuffer<EventStateElement> eventStateBuffer,
        [In] ref SequenceAsset sequenceAsset,
        [In] ref SequenceInstance sequenceInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStateBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__GetActiveSequencesLogPublicVersion_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceAsset_byref_SequenceInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass23_0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass23_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (sb));
        ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (count));
        ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, 100663507);
        ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__GetActiveSequencesLogPublicVersion_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceAsset_byref_SequenceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, 100663508);
      }

      public __c__DisplayClass23_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass23_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass23_0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder sb
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_sb));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_count)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/<>c__DisplayClass25_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass25_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_foundLocalPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintSunVFXStatePublicVersion_b__0_Internal_Void_Entity_byref_LocalCharacter_0;
      [FieldOffset(0)]
      public bool foundLocalPlayer;
      [FieldOffset(4)]
      public Entity localPlayer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass25_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _PrintSunVFXStatePublicVersion_b__0(
        Entity entity,
        [In] ref LocalCharacter localCharacter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__PrintSunVFXStatePublicVersion_b__0_Internal_Void_Entity_byref_LocalCharacter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass25_0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass25_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass25_0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_foundLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass25_0>.NativeClassPtr, nameof (foundLocalPlayer));
        ClientConsoleCommandSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass25_0>.NativeClassPtr, nameof (localPlayer));
        ClientConsoleCommandSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass25_0>.NativeClassPtr, 100663509);
        ClientConsoleCommandSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__PrintSunVFXStatePublicVersion_b__0_Internal_Void_Entity_byref_LocalCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass25_0>.NativeClassPtr, 100663510);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass25_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/<>c__DisplayClass31_0")]
    public sealed class __c__DisplayClass31_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dumpBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkMetadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetPerformanceDump_b__0_Internal_Void_Entity_DynamicBuffer_1_PerformanceSummaryElement_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass31_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GetPerformanceDump_b__0(
        Entity entity,
        DynamicBuffer<PerformanceSummaryElement> buffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__GetPerformanceDump_b__0_Internal_Void_Entity_DynamicBuffer_1_PerformanceSummaryElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass31_0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass31_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_dumpBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (dumpBuilder));
        ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_chunkMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, nameof (chunkMetadatas));
        ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, 100663511);
        ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeMethodInfoPtr__GetPerformanceDump_b__0_Internal_Void_Entity_DynamicBuffer_1_PerformanceSummaryElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, 100663512);
      }

      public __c__DisplayClass31_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass31_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass31_0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder dumpBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_dumpBuilder));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_dumpBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<TerrainChunk, Entity> chunkMetadatas
      {
        get
        {
          return *(NativeHashMap<TerrainChunk, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_chunkMetadatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr_chunkMetadatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/<>c__DisplayClass40_0")]
    public sealed class __c__DisplayClass40_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AcceptClanInvite_b__0_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass40_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AcceptClanInvite_b__0(
        Entity entity,
        [In] ref ClanInviteRequest_Shared inviteRequest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inviteRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__AcceptClanInvite_b__0_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass40_0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass40_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, nameof (localUserEntity));
        ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, 100663513);
        ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__AcceptClanInvite_b__0_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, 100663514);
      }

      public __c__DisplayClass40_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass40_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass40_0>.NativeClassPtr, data));
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/<>c__DisplayClass41_0")]
    public sealed class __c__DisplayClass41_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DeclineClanInvite_b__0_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass41_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _DeclineClanInvite_b__0(
        Entity entity,
        [In] ref ClanInviteRequest_Shared inviteRequest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inviteRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__DeclineClanInvite_b__0_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass41_0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass41_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, nameof (localUserEntity));
        ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, 100663515);
        ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeMethodInfoPtr__DeclineClanInvite_b__0_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, 100663516);
      }

      public __c__DisplayClass41_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass41_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass41_0>.NativeClassPtr, data));
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass41_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_PrintActiveSequences_LambdaJob0")]
    public sealed class __c__DisplayClass_PrintActiveSequences_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sb;
      private static readonly System.IntPtr NativeFieldInfoPtr_count;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceInstance_byref_SequenceAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640861, RefRangeEnd = 1640862, XrefRangeStart = 1640851, XrefRangeEnd = 1640861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<EventStateElement> eventStateBuffer,
        [In] ref SequenceInstance sequenceInstance,
        [In] ref SequenceAsset sequenceAsset)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStateBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceInstance_byref_SequenceAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1123118, RefRangeEnd = 1123121, XrefRangeStart = 1123118, XrefRangeEnd = 1123121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1640864, RefRangeEnd = 1640867, XrefRangeStart = 1640862, XrefRangeEnd = 1640864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640867, XrefRangeEnd = 1640869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640881, RefRangeEnd = 1640882, XrefRangeStart = 1640869, XrefRangeEnd = 1640881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640884, RefRangeEnd = 1640885, XrefRangeStart = 1640882, XrefRangeEnd = 1640884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientConsoleCommandSystem componentSystem,
        ref ClientConsoleCommandSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640885, XrefRangeEnd = 1640891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PrintActiveSequences_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_PrintActiveSequences_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, nameof (sb));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, nameof (count));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceInstance_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, 100663517);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, 100663518);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, 100663519);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, 100663520);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, 100663521);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, 100663522);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, 100663523);
      }

      public __c__DisplayClass_PrintActiveSequences_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_PrintActiveSequences_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder sb
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_sb));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_count)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventStateBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceInstance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceAsset;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<EventStateElement> forParameter_eventStateBuffer;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<SequenceInstance> forParameter_sequenceInstance;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<SequenceAsset> forParameter_sequenceAsset;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640839, RefRangeEnd = 1640840, XrefRangeStart = 1640829, XrefRangeEnd = 1640839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640850, RefRangeEnd = 1640851, XrefRangeStart = 1640840, XrefRangeEnd = 1640850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventStateBuffer));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceInstance));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceAsset));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663524);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663525);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventStateBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceInstance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceAsset;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<EventStateElement>.Runtime runtime_eventStateBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<SequenceInstance>.Runtime runtime_sequenceInstance;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<SequenceAsset>.Runtime runtime_sequenceAsset;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventStateBuffer));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceInstance));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceAsset));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintActiveSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_PrintSequences_LambdaJob0")]
    public sealed class __c__DisplayClass_PrintSequences_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sb;
      private static readonly System.IntPtr NativeFieldInfoPtr_count;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640913, RefRangeEnd = 1640914, XrefRangeStart = 1640901, XrefRangeEnd = 1640913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref PrefabGUID prefabGuid)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1123118, RefRangeEnd = 1123121, XrefRangeStart = 1123118, XrefRangeEnd = 1123121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1640864, RefRangeEnd = 1640867, XrefRangeStart = 1640864, XrefRangeEnd = 1640867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640914, XrefRangeEnd = 1640916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640922, RefRangeEnd = 1640923, XrefRangeStart = 1640916, XrefRangeEnd = 1640922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640925, RefRangeEnd = 1640926, XrefRangeStart = 1640923, XrefRangeEnd = 1640925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientConsoleCommandSystem componentSystem,
        ref ClientConsoleCommandSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640926, XrefRangeEnd = 1640932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PrintSequences_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_PrintSequences_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, nameof (sb));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, nameof (count));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, 100663526);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, 100663527);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, 100663528);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, 100663529);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, 100663530);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, 100663531);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, 100663532);
      }

      public __c__DisplayClass_PrintSequences_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_PrintSequences_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder sb
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_sb));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_count)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGuid;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGuid;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640895, RefRangeEnd = 1640896, XrefRangeStart = 1640891, XrefRangeEnd = 1640895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640900, RefRangeEnd = 1640901, XrefRangeStart = 1640896, XrefRangeEnd = 1640900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGuid));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663533);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663534);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGuid;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGuid;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGuid));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSequences_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0")]
    public sealed class __c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sb;
      private static readonly System.IntPtr NativeFieldInfoPtr_count;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceAsset_byref_SequenceInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640964, RefRangeEnd = 1640965, XrefRangeStart = 1640954, XrefRangeEnd = 1640964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<EventStateElement> eventStateBuffer,
        [In] ref SequenceAsset sequenceAsset,
        [In] ref SequenceInstance sequenceInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStateBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceAsset_byref_SequenceInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1123118, RefRangeEnd = 1123121, XrefRangeStart = 1123118, XrefRangeEnd = 1123121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass23_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1640864, RefRangeEnd = 1640867, XrefRangeStart = 1640864, XrefRangeEnd = 1640867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass23_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640965, XrefRangeEnd = 1640967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640979, RefRangeEnd = 1640980, XrefRangeStart = 1640967, XrefRangeEnd = 1640979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1640982, RefRangeEnd = 1640983, XrefRangeStart = 1640980, XrefRangeEnd = 1640982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientConsoleCommandSystem componentSystem,
        ref ClientConsoleCommandSystem.__c__DisplayClass23_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass23_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640983, XrefRangeEnd = 1640989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, nameof (sb));
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, nameof (count));
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EventStateElement_byref_SequenceAsset_byref_SequenceInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, 100663535);
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, 100663536);
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, 100663537);
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, 100663538);
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, 100663539);
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, 100663540);
        ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, 100663541);
      }

      public __c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder sb
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_sb));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int count
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_count));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_count)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventStateBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceAsset;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<EventStateElement> forParameter_eventStateBuffer;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<SequenceAsset> forParameter_sequenceAsset;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<SequenceInstance> forParameter_sequenceInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640942, RefRangeEnd = 1640943, XrefRangeStart = 1640932, XrefRangeEnd = 1640942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640953, RefRangeEnd = 1640954, XrefRangeStart = 1640943, XrefRangeEnd = 1640953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventStateBuffer));
          ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceAsset));
          ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceInstance));
          ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663542);
          ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663543);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventStateBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceAsset;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<EventStateElement>.Runtime runtime_eventStateBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<SequenceAsset>.Runtime runtime_sequenceAsset;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<SequenceInstance>.Runtime runtime_sequenceInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventStateBuffer));
            ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceAsset));
            ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetActiveSequencesLogPublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_foundLocalPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass25_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass25_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass25_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool foundLocalPlayer;
      [FieldOffset(4)]
      public Entity localPlayer;
      [FieldOffset(12)]
      public ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641074, RefRangeEnd = 1641075, XrefRangeStart = 1641074, XrefRangeEnd = 1641074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref LocalCharacter localCharacter)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalCharacter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1125434, RefRangeEnd = 1125436, XrefRangeStart = 1125434, XrefRangeEnd = 1125436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass25_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass25_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1125436, RefRangeEnd = 1125438, XrefRangeStart = 1125436, XrefRangeEnd = 1125438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass25_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass25_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641075, XrefRangeEnd = 1641077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641083, RefRangeEnd = 1641084, XrefRangeStart = 1641077, XrefRangeEnd = 1641083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641086, RefRangeEnd = 1641087, XrefRangeStart = 1641084, XrefRangeEnd = 1641086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientConsoleCommandSystem componentSystem,
        ref ClientConsoleCommandSystem.__c__DisplayClass25_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass25_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641087, XrefRangeEnd = 1641091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641091, XrefRangeEnd = 1641097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_foundLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, nameof (foundLocalPlayer));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, nameof (localPlayer));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LocalCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663544);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass25_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663545);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass25_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663546);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663547);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663548);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass25_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663549);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663550);
        ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, 100663551);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<LocalCharacter> forParameter_localCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640993, RefRangeEnd = 1640994, XrefRangeStart = 1640989, XrefRangeEnd = 1640993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1640998, RefRangeEnd = 1640999, XrefRangeStart = 1640994, XrefRangeEnd = 1640998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localCharacter));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663552);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663553);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData_Tag<LocalCharacter>.Runtime runtime_localCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0/ProjectM.RunWithoutJobSystem_000000D9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000D9$PostfixBurstDelegate");
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663554);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663555);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663556);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663557);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0/ProjectM.RunWithoutJobSystem_000000D9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1640999, XrefRangeEnd = 1641013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641013, XrefRangeEnd = 1641031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641031, XrefRangeEnd = 1641046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1641073, RefRangeEnd = 1641074, XrefRangeStart = 1641046, XrefRangeEnd = 1641073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000D9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663558);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663559);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663560);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663561);
          ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663563);
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
            IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_PrintSunVFXStatePublicVersion_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_GetPerformanceDump_LambdaJob0")]
    public sealed class __c__DisplayClass_GetPerformanceDump_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dumpBuilder;
      private static readonly System.IntPtr NativeFieldInfoPtr_chunkMetadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_PerformanceSummaryElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass31_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641129, RefRangeEnd = 1641130, XrefRangeStart = 1641107, XrefRangeEnd = 1641129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        DynamicBuffer<PerformanceSummaryElement> buffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_PerformanceSummaryElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641132, RefRangeEnd = 1641133, XrefRangeStart = 1641130, XrefRangeEnd = 1641132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass31_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641135, RefRangeEnd = 1641136, XrefRangeStart = 1641133, XrefRangeEnd = 1641135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass31_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641136, XrefRangeEnd = 1641138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641144, RefRangeEnd = 1641145, XrefRangeStart = 1641138, XrefRangeEnd = 1641144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641147, RefRangeEnd = 1641148, XrefRangeStart = 1641145, XrefRangeEnd = 1641147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientConsoleCommandSystem componentSystem,
        ref ClientConsoleCommandSystem.__c__DisplayClass31_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass31_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641148, XrefRangeEnd = 1641154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetPerformanceDump_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_GetPerformanceDump_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_dumpBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, nameof (dumpBuilder));
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_chunkMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, nameof (chunkMetadatas));
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_PerformanceSummaryElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, 100663564);
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, 100663565);
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, 100663566);
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, 100663567);
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, 100663568);
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass31_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, 100663569);
        ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, 100663570);
      }

      public __c__DisplayClass_GetPerformanceDump_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_GetPerformanceDump_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder dumpBuilder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_dumpBuilder));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_dumpBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<TerrainChunk, Entity> chunkMetadatas
      {
        get
        {
          return *(NativeHashMap<TerrainChunk, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_chunkMetadatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_chunkMetadatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<TerrainChunk, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<PerformanceSummaryElement> forParameter_buffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1641101, RefRangeEnd = 1641102, XrefRangeStart = 1641097, XrefRangeEnd = 1641101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1641106, RefRangeEnd = 1641107, XrefRangeStart = 1641102, XrefRangeEnd = 1641106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffer));
          ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663571);
          ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663572);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<PerformanceSummaryElement>.Runtime runtime_buffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_GetPerformanceDump_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_AcceptClanInvite_LambdaJob0")]
    public sealed class __c__DisplayClass_AcceptClanInvite_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass40_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass40_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass40_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641172, RefRangeEnd = 1641173, XrefRangeStart = 1641164, XrefRangeEnd = 1641172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ClanInviteRequest_Shared inviteRequest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inviteRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 975279, RefRangeEnd = 975282, XrefRangeStart = 975279, XrefRangeEnd = 975282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass40_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass40_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 975283, RefRangeEnd = 975294, XrefRangeStart = 975283, XrefRangeEnd = 975294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass40_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass40_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641173, XrefRangeEnd = 1641185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641191, RefRangeEnd = 1641192, XrefRangeStart = 1641185, XrefRangeEnd = 1641191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 977780, RefRangeEnd = 977788, XrefRangeStart = 977780, XrefRangeEnd = 977788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientConsoleCommandSystem componentSystem,
        ref ClientConsoleCommandSystem.__c__DisplayClass40_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass40_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AcceptClanInvite_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_AcceptClanInvite_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, nameof (localUserEntity));
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, 100663573);
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass40_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, 100663574);
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass40_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, 100663575);
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, 100663577);
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, 100663578);
        ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass40_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, 100663579);
      }

      public __c__DisplayClass_AcceptClanInvite_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_AcceptClanInvite_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inviteRequest;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ClanInviteRequest_Shared> forParameter_inviteRequest;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641154, XrefRangeEnd = 1641158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1641163, RefRangeEnd = 1641164, XrefRangeStart = 1641158, XrefRangeEnd = 1641163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inviteRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inviteRequest));
          ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663580);
          ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663581);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inviteRequest;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<ClanInviteRequest_Shared>.StructuralChangeRuntime runtime_inviteRequest;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inviteRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inviteRequest));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_AcceptClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientConsoleCommandSystem/ProjectM.<>c__DisplayClass_DeclineClanInvite_LambdaJob0")]
    public sealed class __c__DisplayClass_DeclineClanInvite_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass41_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641210, RefRangeEnd = 1641211, XrefRangeStart = 1641202, XrefRangeEnd = 1641210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ClanInviteRequest_Shared inviteRequest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inviteRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 975279, RefRangeEnd = 975282, XrefRangeStart = 975279, XrefRangeEnd = 975282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass41_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 975283, RefRangeEnd = 975294, XrefRangeStart = 975283, XrefRangeEnd = 975294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientConsoleCommandSystem.__c__DisplayClass41_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641211, XrefRangeEnd = 1641223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1641229, RefRangeEnd = 1641230, XrefRangeStart = 1641223, XrefRangeEnd = 1641229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 977780, RefRangeEnd = 977788, XrefRangeStart = 977780, XrefRangeEnd = 977788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientConsoleCommandSystem componentSystem,
        ref ClientConsoleCommandSystem.__c__DisplayClass41_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass41_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DeclineClanInvite_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass_DeclineClanInvite_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr);
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, nameof (localUserEntity));
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ClanInviteRequest_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, 100663582);
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, 100663583);
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, 100663584);
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, 100663586);
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, 100663587);
        ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_byref___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, 100663588);
      }

      public __c__DisplayClass_DeclineClanInvite_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_DeclineClanInvite_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ClientConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientConsoleCommandSystem) null : new ClientConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inviteRequest;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ClanInviteRequest_Shared> forParameter_inviteRequest;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1641192, XrefRangeEnd = 1641196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientConsoleCommandSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1641201, RefRangeEnd = 1641202, XrefRangeStart = 1641196, XrefRangeEnd = 1641201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inviteRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inviteRequest));
          ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientConsoleCommandSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663589);
          ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663590);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inviteRequest;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<ClanInviteRequest_Shared>.StructuralChangeRuntime runtime_inviteRequest;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inviteRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inviteRequest));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConsoleCommandSystem.__c__DisplayClass_DeclineClanInvite_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
