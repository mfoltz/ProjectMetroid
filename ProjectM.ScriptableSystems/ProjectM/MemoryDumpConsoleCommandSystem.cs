// Decompiled with JetBrains decompiler
// Type: ProjectM.MemoryDumpConsoleCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class MemoryDumpConsoleCommandSystem : ConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddWorldArgumentSuggestions_Private_Static_Void_DefaultConsoleCommand_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetWorlds_Private_IEnumerable_1_World_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpArchetypeInformationCommand_Private_Void_String_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpDynamicBufferMemoryFootprintsCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpDynamicBufferMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpBlobAssetMemoryFootprintsCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpBlobAssetMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpComponentMemoryFootprintsCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpComponentMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpChunkFragmentationCommand_Private_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpNativeMemorySummaryCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteNativeMemorySummary_Private_Static_Void_World_MemorySummarizer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSameLengthSumStrings_Private_Static_Il2CppStringArray_IEnumerable_1_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HumanReadableSize_Private_Static_String_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpEverything_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpAssetStreamingState_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpSystemMemory_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpSystemCollectionsMemory_Private_Void_World_OutputType_MemorySummarizer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenDumpFolderIfWroteFile_Private_Void_OutputType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpEntityQueries_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpEntityQueries_Private_Void_World_OutputType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpQueryArchetypes_Private_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpQueryArchetypes_Private_Void_World_Boolean_OutputType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpArchetypeInformation_Private_Static_Void_World_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpComponentTypes_Private_Static_Void_World_Int32_Boolean_byref_StringBuilder_Dictionary_2_ComponentType_List_1_List_1_TypeWithInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpChunkAnalysis_Private_Static_Void_World_OutputType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteTXTDump_Private_Static_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteCSVDump_Private_Static_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SummarizeUnusedChunkSpacePerArchetypeAnalysis_Private_Static_Void_World_MemorySummarizer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpEntity_Private_Void_String_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParseEntityAndWorld_Private_Boolean_String_String_byref_World_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParseEntity_Private_Boolean_String_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpPrefabGUIDEntities_Private_Void_String_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpEntitySummaryForWorld_Private_Static_Void_String_Boolean_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintData_Private_Static_Void_World_StringBuilder_String_List_1_PrefabGUIDEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ListToStringWithColumns_Public_Static_String_List_1_T_String_Il2CppReferenceArray_1_Func_2_T_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindCategory_Private_Static_PrefabDumpCategory_World_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_List_1_QueryArchetypeData_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645676, XrefRangeEnd = 1645939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1645962, RefRangeEnd = 1645973, XrefRangeStart = 1645939, XrefRangeEnd = 1645962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddWorldArgumentSuggestions(
      DefaultConsoleCommand command,
      int argumentIndex,
      bool includeBoth)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) command);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &argumentIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includeBoth;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_AddWorldArgumentSuggestions_Private_Static_Void_DefaultConsoleCommand_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1645979, RefRangeEnd = 1645989, XrefRangeStart = 1645973, XrefRangeEnd = 1645979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerable<World> GetTargetWorlds(string whichWorld)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whichWorld);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_GetTargetWorlds_Private_IEnumerable_1_World_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<World>) null : new IEnumerable<World>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645989, XrefRangeEnd = 1646011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpArchetypeInformationCommand(
      string whichWorld,
      int numToPrint,
      bool fullInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whichWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numToPrint;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullInfo;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpArchetypeInformationCommand_Private_Void_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1646011, XrefRangeEnd = 1646032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpDynamicBufferMemoryFootprintsCommand(string which)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpDynamicBufferMemoryFootprintsCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1646186, RefRangeEnd = 1646189, XrefRangeStart = 1646032, XrefRangeEnd = 1646186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpDynamicBufferMemoryFootprints(
      World world,
      MemoryDumpConsoleCommandSystem.OutputType outputTypes,
      MemoryDumpConsoleCommandSystem.MemorySummarizer summarizer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outputTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summarizer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpDynamicBufferMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1646189, XrefRangeEnd = 1646206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpBlobAssetMemoryFootprintsCommand(string which)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpBlobAssetMemoryFootprintsCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1646357, RefRangeEnd = 1646360, XrefRangeStart = 1646206, XrefRangeEnd = 1646357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpBlobAssetMemoryFootprints(
      World world,
      MemoryDumpConsoleCommandSystem.OutputType outputTypes,
      MemoryDumpConsoleCommandSystem.MemorySummarizer summarizer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outputTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summarizer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpBlobAssetMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1646360, XrefRangeEnd = 1646377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpComponentMemoryFootprintsCommand(string which)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpComponentMemoryFootprintsCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1646532, RefRangeEnd = 1646535, XrefRangeStart = 1646377, XrefRangeEnd = 1646532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpComponentMemoryFootprints(
      World world,
      MemoryDumpConsoleCommandSystem.OutputType outputTypes,
      MemoryDumpConsoleCommandSystem.MemorySummarizer summarizer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outputTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summarizer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpComponentMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1646535, XrefRangeEnd = 1646553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpChunkFragmentationCommand(string whichWorld, bool extraDebugging)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whichWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &extraDebugging;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpChunkFragmentationCommand_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1646579, RefRangeEnd = 1646580, XrefRangeStart = 1646553, XrefRangeEnd = 1646579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpNativeMemorySummaryCommand(string whichWorld)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whichWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpNativeMemorySummaryCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1646710, RefRangeEnd = 1646711, XrefRangeStart = 1646580, XrefRangeEnd = 1646710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteNativeMemorySummary(
      World world,
      MemoryDumpConsoleCommandSystem.MemorySummarizer memorySummarizer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) memorySummarizer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_WriteNativeMemorySummary_Private_Static_Void_World_MemorySummarizer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1646748, RefRangeEnd = 1646752, XrefRangeStart = 1646711, XrefRangeEnd = 1646748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStringArray GetSameLengthSumStrings(IEnumerable<long> sumBytes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sumBytes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_GetSameLengthSumStrings_Private_Static_Il2CppStringArray_IEnumerable_1_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1646760, RefRangeEnd = 1646764, XrefRangeStart = 1646752, XrefRangeEnd = 1646760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string HumanReadableSize(long size)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &size;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_HumanReadableSize_Private_Static_String_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1646764, XrefRangeEnd = 1646815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpEverything(string which)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEverything_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1646815, XrefRangeEnd = 1646834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpAssetStreamingState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpAssetStreamingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1646834, XrefRangeEnd = 1646855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpSystemMemory(string whichWorld)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whichWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpSystemMemory_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1647067, RefRangeEnd = 1647070, XrefRangeStart = 1646855, XrefRangeEnd = 1647067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpSystemCollectionsMemory(
      World world,
      MemoryDumpConsoleCommandSystem.OutputType outputTypes,
      MemoryDumpConsoleCommandSystem.MemorySummarizer memorySummarizer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outputTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) memorySummarizer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpSystemCollectionsMemory_Private_Void_World_OutputType_MemorySummarizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1647082, RefRangeEnd = 1647088, XrefRangeStart = 1647070, XrefRangeEnd = 1647082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenDumpFolderIfWroteFile(
      MemoryDumpConsoleCommandSystem.OutputType outputTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &outputTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_OpenDumpFolderIfWroteFile_Private_Void_OutputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1647088, XrefRangeEnd = 1647109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpEntityQueries(string whichWorld)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whichWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntityQueries_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1647227, RefRangeEnd = 1647229, XrefRangeStart = 1647109, XrefRangeEnd = 1647227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpEntityQueries(
      World world,
      MemoryDumpConsoleCommandSystem.OutputType outputTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outputTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntityQueries_Private_Void_World_OutputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1647229, XrefRangeEnd = 1647250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpQueryArchetypes(string whichWorld, bool onlyRequired)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(whichWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyRequired;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpQueryArchetypes_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1647373, RefRangeEnd = 1647374, XrefRangeStart = 1647250, XrefRangeEnd = 1647373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpQueryArchetypes(
      World world,
      bool onlyRequired,
      MemoryDumpConsoleCommandSystem.OutputType outputTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyRequired;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &outputTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpQueryArchetypes_Private_Void_World_Boolean_OutputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1647590, RefRangeEnd = 1647592, XrefRangeStart = 1647374, XrefRangeEnd = 1647590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpArchetypeInformation(World world, int numToPrint = 0, bool fullInfo = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numToPrint;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullInfo;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpArchetypeInformation_Private_Static_Void_World_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1647698, RefRangeEnd = 1647699, XrefRangeStart = 1647592, XrefRangeEnd = 1647698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpComponentTypes(
      World world,
      int numToPrint,
      bool fullInfo,
      out StringBuilder sb,
      Dictionary<ComponentType, List<List<MemoryDumpConsoleCommandSystem.TypeWithInfo>>> componentTypeDictionary)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numToPrint;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullInfo;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypeDictionary);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpComponentTypes_Private_Static_Void_World_Int32_Boolean_byref_StringBuilder_Dictionary_2_ComponentType_List_1_List_1_TypeWithInfo_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref StringBuilder local = ref sb;
      System.IntPtr pointer = zero;
      StringBuilder stringBuilder = pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
      local = stringBuilder;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1648042, RefRangeEnd = 1648044, XrefRangeStart = 1647699, XrefRangeEnd = 1648042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpChunkAnalysis(
      World world,
      MemoryDumpConsoleCommandSystem.OutputType outputTypes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outputTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpChunkAnalysis_Private_Static_Void_World_OutputType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1648054, RefRangeEnd = 1648064, XrefRangeStart = 1648044, XrefRangeEnd = 1648054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteTXTDump(string fileName, string text)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_WriteTXTDump_Private_Static_Void_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1648074, RefRangeEnd = 1648080, XrefRangeStart = 1648064, XrefRangeEnd = 1648074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteCSVDump(string fileName, string text)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_WriteCSVDump_Private_Static_Void_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1648291, RefRangeEnd = 1648292, XrefRangeStart = 1648080, XrefRangeEnd = 1648291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SummarizeUnusedChunkSpacePerArchetypeAnalysis(
      World world,
      MemoryDumpConsoleCommandSystem.MemorySummarizer summarizer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summarizer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_SummarizeUnusedChunkSpacePerArchetypeAnalysis_Private_Static_Void_World_MemorySummarizer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648292, XrefRangeEnd = 1648294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpEntity(string worldStr, string entityStr, bool fullDump)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(worldStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(entityStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullDump;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntity_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1648344, RefRangeEnd = 1648345, XrefRangeStart = 1648294, XrefRangeEnd = 1648344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryParseEntityAndWorld(
      string worldStr,
      string entityStr,
      out World world,
      out Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(worldStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(entityStr);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_TryParseEntityAndWorld_Private_Boolean_String_String_byref_World_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref World local = ref world;
      System.IntPtr pointer = zero;
      World world1 = pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      local = world1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648345, XrefRangeEnd = 1648354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryParseEntity(string entityStr, out Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(entityStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_TryParseEntity_Private_Boolean_String_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648354, XrefRangeEnd = 1648384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpPrefabGUIDEntities(
      string worldStr,
      string componentStr,
      bool includeDisabled,
      bool includePrefabs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(worldStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(componentStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDisabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &includePrefabs;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpPrefabGUIDEntities_Private_Void_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1648469, RefRangeEnd = 1648470, XrefRangeStart = 1648384, XrefRangeEnd = 1648469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpEntitySummaryForWorld(
      string componentStr,
      bool includeDisabled,
      bool includePrefabs,
      World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(componentStr);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeDisabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includePrefabs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntitySummaryForWorld_Private_Static_Void_String_Boolean_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648470, XrefRangeEnd = 1648572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PrintData(
      World world,
      StringBuilder sb,
      string category,
      List<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry> sortedList)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(category);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sortedList);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_PrintData_Private_Static_Void_World_StringBuilder_String_List_1_PrefabGUIDEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648572, XrefRangeEnd = 1648601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ListToStringWithColumns(
      List<M0> list,
      string columnSeparator,
      [Optional] Il2CppReferenceArray<Il2CppSystem.Func<M0, string>> columnToString)
    {
      if (columnToString == null)
        columnToString = new Il2CppReferenceArray<Il2CppSystem.Func<M0, string>>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(columnSeparator);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) columnToString);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.MethodInfoStoreGeneric_ListToStringWithColumns_Public_Static_String_List_1_T_String_Il2CppReferenceArray_1_Func_2_T_String_0<M0>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648601, XrefRangeEnd = 1648638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MemoryDumpConsoleCommandSystem.PrefabDumpCategory FindCategory(
      World world,
      Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_FindCategory_Private_Static_PrefabDumpCategory_World_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MemoryDumpConsoleCommandSystem.PrefabDumpCategory*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 732837, RefRangeEnd = 732840, XrefRangeStart = 732837, XrefRangeEnd = 732840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MemoryDumpConsoleCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1648658, RefRangeEnd = 1648660, XrefRangeStart = 1648638, XrefRangeEnd = 1648658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Internal_Static_Void_List_1_QueryArchetypeData_StringBuilder_0(
      List<MemoryDumpConsoleCommandSystem.QueryArchetypeData> systemDatas,
      StringBuilder builder)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemDatas);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builder);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_Method_Internal_Static_Void_List_1_QueryArchetypeData_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public static string ListToStringWithColumns<T, T>(
      List<T> list,
      string columnSeparator,
      params Il2CppSystem.Func<,>[] columnToString)
    {
      return MemoryDumpConsoleCommandSystem.ListToStringWithColumns(list, columnSeparator, (Il2CppReferenceArray<Il2CppSystem.Func<M0, string>>) new Il2CppReferenceArray<Il2CppSystem.Func<,>>(columnToString));
    }

    static MemoryDumpConsoleCommandSystem()
    {
      Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (MemoryDumpConsoleCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663697);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663698);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_AddWorldArgumentSuggestions_Private_Static_Void_DefaultConsoleCommand_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663699);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_GetTargetWorlds_Private_IEnumerable_1_World_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663700);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpArchetypeInformationCommand_Private_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663701);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpDynamicBufferMemoryFootprintsCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663702);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpDynamicBufferMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663703);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpBlobAssetMemoryFootprintsCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663704);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpBlobAssetMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663705);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpComponentMemoryFootprintsCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663706);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpComponentMemoryFootprints_Private_Void_World_OutputType_MemorySummarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663707);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpChunkFragmentationCommand_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663708);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpNativeMemorySummaryCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663709);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_WriteNativeMemorySummary_Private_Static_Void_World_MemorySummarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663710);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_GetSameLengthSumStrings_Private_Static_Il2CppStringArray_IEnumerable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663711);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_HumanReadableSize_Private_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663712);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEverything_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663713);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpAssetStreamingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663714);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpSystemMemory_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663715);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpSystemCollectionsMemory_Private_Void_World_OutputType_MemorySummarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663716);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_OpenDumpFolderIfWroteFile_Private_Void_OutputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663717);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntityQueries_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663718);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntityQueries_Private_Void_World_OutputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663719);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpQueryArchetypes_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663720);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpQueryArchetypes_Private_Void_World_Boolean_OutputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663721);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpArchetypeInformation_Private_Static_Void_World_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663722);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpComponentTypes_Private_Static_Void_World_Int32_Boolean_byref_StringBuilder_Dictionary_2_ComponentType_List_1_List_1_TypeWithInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663723);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpChunkAnalysis_Private_Static_Void_World_OutputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663724);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_WriteTXTDump_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663725);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_WriteCSVDump_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663726);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_SummarizeUnusedChunkSpacePerArchetypeAnalysis_Private_Static_Void_World_MemorySummarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663727);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntity_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663728);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_TryParseEntityAndWorld_Private_Boolean_String_String_byref_World_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663729);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_TryParseEntity_Private_Boolean_String_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663730);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpPrefabGUIDEntities_Private_Void_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663731);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_DumpEntitySummaryForWorld_Private_Static_Void_String_Boolean_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663732);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_PrintData_Private_Static_Void_World_StringBuilder_String_List_1_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663733);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_ListToStringWithColumns_Public_Static_String_List_1_T_String_Il2CppReferenceArray_1_Func_2_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663734);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_FindCategory_Private_Static_PrefabDumpCategory_World_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663735);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663736);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_Method_Internal_Static_Void_List_1_QueryArchetypeData_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663737);
      MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, 100663738);
    }

    public MemoryDumpConsoleCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public class MemorySummarizer : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Groups;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddGroup_Public_MemoryGroup_String_Int64_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1645482, RefRangeEnd = 1645487, XrefRangeStart = 1645478, XrefRangeEnd = 1645482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup AddGroup(
        string name,
        long sumBytes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sumBytes;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.MemorySummarizer.NativeMethodInfoPtr_AddGroup_Public_MemoryGroup_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup(pointer);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1645495, RefRangeEnd = 1645496, XrefRangeStart = 1645487, XrefRangeEnd = 1645495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MemorySummarizer()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.MemorySummarizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MemorySummarizer()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (MemorySummarizer));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.MemorySummarizer.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr, nameof (Groups));
        MemoryDumpConsoleCommandSystem.MemorySummarizer.NativeMethodInfoPtr_AddGroup_Public_MemoryGroup_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr, 100663739);
        MemoryDumpConsoleCommandSystem.MemorySummarizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr, 100663740);
      }

      public MemorySummarizer(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup> Groups
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.NativeFieldInfoPtr_Groups));
          return pointer == System.IntPtr.Zero ? (List<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>) null : new List<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.NativeFieldInfoPtr_Groups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public sealed class Contributor : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_SumBytes;
        private static readonly System.IntPtr NativeFieldInfoPtr_Name;

        static Contributor()
        {
          Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr, nameof (Contributor));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>.NativeClassPtr);
          MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor.NativeFieldInfoPtr_SumBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>.NativeClassPtr, nameof (SumBytes));
          MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>.NativeClassPtr, nameof (Name));
        }

        public Contributor(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public Contributor()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>.NativeClassPtr, data));
        }

        public unsafe long SumBytes
        {
          get
          {
            return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor.NativeFieldInfoPtr_SumBytes));
          }
          [param: In] set
          {
            *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor.NativeFieldInfoPtr_SumBytes)) = value;
          }
        }

        public unsafe string Name
        {
          get
          {
            return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor.NativeFieldInfoPtr_Name)));
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
          }
        }
      }

      public sealed class MemoryGroup : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Name;
        private static readonly System.IntPtr NativeFieldInfoPtr_SumBytes;
        private static readonly System.IntPtr NativeFieldInfoPtr_TopFiveContributors;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1645477, RefRangeEnd = 1645478, XrefRangeStart = 1645469, XrefRangeEnd = 1645477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MemoryGroup(string name, long sumBytes)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sumBytes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MemoryGroup()
        {
          Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer>.NativeClassPtr, nameof (MemoryGroup));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr);
          MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr, nameof (Name));
          MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_SumBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr, nameof (SumBytes));
          MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_TopFiveContributors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr, nameof (TopFiveContributors));
          MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr, 100663741);
        }

        public MemoryGroup(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public MemoryGroup()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup>.NativeClassPtr, data));
        }

        public unsafe string Name
        {
          get
          {
            return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_Name)));
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
          }
        }

        public unsafe long SumBytes
        {
          get
          {
            return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_SumBytes));
          }
          [param: In] set
          {
            *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_SumBytes)) = value;
          }
        }

        public unsafe List<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor> TopFiveContributors
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_TopFiveContributors));
            return pointer == System.IntPtr.Zero ? (List<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>) null : new List<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor>(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup.NativeFieldInfoPtr_TopFiveContributors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }
    }

    [Flags]
    public enum OutputType
    {
      None = 0,
      TXT = 1,
      CSV = 2,
      All = CSV | TXT, // 0x00000003
    }

    public sealed class SystemEntityQuery : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_System;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCount;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SystemEntityQuery_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645496, XrefRangeEnd = 1645498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        MemoryDumpConsoleCommandSystem.SystemEntityQuery other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SystemEntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SystemEntityQuery()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.SystemEntityQuery>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (SystemEntityQuery));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.SystemEntityQuery>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeFieldInfoPtr_System = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.SystemEntityQuery>.NativeClassPtr, nameof (System));
        MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeFieldInfoPtr_ChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.SystemEntityQuery>.NativeClassPtr, nameof (ChunkCount));
        MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SystemEntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.SystemEntityQuery>.NativeClassPtr, 100663742);
      }

      public SystemEntityQuery(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SystemEntityQuery()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.SystemEntityQuery>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.SystemEntityQuery>.NativeClassPtr, data));
      }

      public unsafe string System
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeFieldInfoPtr_System)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeFieldInfoPtr_System), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int ChunkCount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeFieldInfoPtr_ChunkCount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.SystemEntityQuery.NativeFieldInfoPtr_ChunkCount)) = value;
        }
      }
    }

    public sealed class QueryArchetypeData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
      private static readonly System.IntPtr NativeFieldInfoPtr_Children;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_QueryArchetypeData_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        MemoryDumpConsoleCommandSystem.QueryArchetypeData other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_QueryArchetypeData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static QueryArchetypeData()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (QueryArchetypeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr, nameof (Name));
        MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr, nameof (Amount));
        MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr, nameof (Children));
        MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_QueryArchetypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr, 100663743);
      }

      public QueryArchetypeData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public QueryArchetypeData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.QueryArchetypeData>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Amount)) = value;
        }
      }

      public unsafe List<MemoryDumpConsoleCommandSystem.QueryArchetypeData> Children
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Children));
          return pointer == System.IntPtr.Zero ? (List<MemoryDumpConsoleCommandSystem.QueryArchetypeData>) null : new List<MemoryDumpConsoleCommandSystem.QueryArchetypeData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.QueryArchetypeData.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TypeWithInfo
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_TypeInfo;
      [FieldOffset(0)]
      public ComponentType Type;
      [FieldOffset(8)]
      public TypeManager.TypeInfo TypeInfo;

      static TypeWithInfo()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.TypeWithInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (TypeWithInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.TypeWithInfo>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.TypeWithInfo.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.TypeWithInfo>.NativeClassPtr, nameof (Type));
        MemoryDumpConsoleCommandSystem.TypeWithInfo.NativeFieldInfoPtr_TypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.TypeWithInfo>.NativeClassPtr, nameof (TypeInfo));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.TypeWithInfo>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class ArchetypeInfo : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentInfos;

      static ArchetypeInfo()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ArchetypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (ArchetypeInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ArchetypeInfo>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.ArchetypeInfo.NativeFieldInfoPtr_EntityArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ArchetypeInfo>.NativeClassPtr, nameof (EntityArchetype));
        MemoryDumpConsoleCommandSystem.ArchetypeInfo.NativeFieldInfoPtr_ComponentInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ArchetypeInfo>.NativeClassPtr, nameof (ComponentInfos));
      }

      public ArchetypeInfo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ArchetypeInfo()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ArchetypeInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ArchetypeInfo>.NativeClassPtr, data));
      }

      public unsafe EntityArchetype EntityArchetype
      {
        get
        {
          return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.ArchetypeInfo.NativeFieldInfoPtr_EntityArchetype));
        }
        [param: In] set
        {
          *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.ArchetypeInfo.NativeFieldInfoPtr_EntityArchetype)) = value;
        }
      }

      public unsafe List<MemoryDumpConsoleCommandSystem.TypeWithInfo> ComponentInfos
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.ArchetypeInfo.NativeFieldInfoPtr_ComponentInfos));
          return pointer == System.IntPtr.Zero ? (List<MemoryDumpConsoleCommandSystem.TypeWithInfo>) null : new List<MemoryDumpConsoleCommandSystem.TypeWithInfo>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.ArchetypeInfo.NativeFieldInfoPtr_ComponentInfos), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ChunkContentCount
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
      private static readonly System.IntPtr NativeFieldInfoPtr_Chunks;
      [FieldOffset(0)]
      public int Entities;
      [FieldOffset(4)]
      public int Chunks;

      static ChunkContentCount()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ChunkContentCount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (ChunkContentCount));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ChunkContentCount>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.ChunkContentCount.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ChunkContentCount>.NativeClassPtr, nameof (Entities));
        MemoryDumpConsoleCommandSystem.ChunkContentCount.NativeFieldInfoPtr_Chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ChunkContentCount>.NativeClassPtr, nameof (Chunks));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.ChunkContentCount>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum PrefabDumpCategory
    {
      SpawnChainChild = 1,
      AIsAndAIAbilities = 2,
      PlayerAbilities = 3,
      MapIcons = 4,
      PlayerBuiltObjects = 5,
      OtherPlayerRelated = 6,
      Other = 7,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PrefabGUIDKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_DumpCategory;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabGUIDKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(4)]
      public MemoryDumpConsoleCommandSystem.PrefabDumpCategory DumpCategory;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(MemoryDumpConsoleCommandSystem.PrefabGUIDKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabGUIDKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645498, XrefRangeEnd = 1645501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645501, XrefRangeEnd = 1645502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static PrefabGUIDKey()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (PrefabGUIDKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr, nameof (PrefabGUID));
        MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeFieldInfoPtr_DumpCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr, nameof (DumpCategory));
        MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabGUIDKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr, 100663744);
        MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr, 100663745);
        MemoryDumpConsoleCommandSystem.PrefabGUIDKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr, 100663746);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PrefabGUIDEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_DumpCategory;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PrefabGUIDEntry_0;
      [FieldOffset(0)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(4)]
      public MemoryDumpConsoleCommandSystem.PrefabDumpCategory DumpCategory;
      [FieldOffset(8)]
      public int Amount;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645502, XrefRangeEnd = 1645504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.PrefabGUIDEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PrefabGUIDEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static PrefabGUIDEntry()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (PrefabGUIDEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry>.NativeClassPtr, nameof (PrefabGUID));
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry.NativeFieldInfoPtr_DumpCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry>.NativeClassPtr, nameof (DumpCategory));
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry>.NativeClassPtr, nameof (Amount));
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry>.NativeClassPtr, 100663747);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class CSVBuilder : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      private static readonly System.IntPtr NativeFieldInfoPtr__GoogleDocsPasteCompatible;
      private static readonly System.IntPtr NativeFieldInfoPtr__HasActiveRow;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_NewRow_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_NextColumn_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeCSV_Public_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeActiveRow_Private_Void_0;

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1645510, RefRangeEnd = 1645516, XrefRangeStart = 1645504, XrefRangeEnd = 1645510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CSVBuilder()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 1645524, RefRangeEnd = 1645536, XrefRangeStart = 1645516, XrefRangeEnd = 1645524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void NewRow()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_NewRow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(40)]
      [CachedScanResults(RefRangeStart = 1645540, RefRangeEnd = 1645580, XrefRangeStart = 1645536, XrefRangeEnd = 1645540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void NextColumn()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_NextColumn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1645585, RefRangeEnd = 1645591, XrefRangeStart = 1645580, XrefRangeEnd = 1645585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string FinalizeCSV()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_FinalizeCSV_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645591, XrefRangeEnd = 1645595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void FinalizeActiveRow()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_FinalizeActiveRow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CSVBuilder()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, nameof (CSVBuilder));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, nameof (Text));
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr__GoogleDocsPasteCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, nameof (_GoogleDocsPasteCompatible));
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr__HasActiveRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, nameof (_HasActiveRow));
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, 100663748);
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_NewRow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, 100663749);
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_NextColumn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, 100663750);
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_FinalizeCSV_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, 100663751);
        MemoryDumpConsoleCommandSystem.CSVBuilder.NativeMethodInfoPtr_FinalizeActiveRow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.CSVBuilder>.NativeClassPtr, 100663752);
      }

      public CSVBuilder(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe StringBuilder Text
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr_Text));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool _GoogleDocsPasteCompatible
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr__GoogleDocsPasteCompatible));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr__GoogleDocsPasteCompatible)) = value;
        }
      }

      public unsafe bool _HasActiveRow
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr__HasActiveRow));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.CSVBuilder.NativeFieldInfoPtr__HasActiveRow)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.MemoryDumpConsoleCommandSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__14_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__14_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__14_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__21_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__21_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__28_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__31_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__31_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__31_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__31_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__32_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_6;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_7;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__37_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__37_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__37_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__37_5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__37_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__37_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__42_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__42_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__42_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__42_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__42_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__42_5;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__42_6;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__43_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__43_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__43_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__43_4;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Internal_Void_ArgumentSuggestionCollection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpBlobAssetMemoryFootprints_b__8_0_Internal_Int64_BlobMemoryData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_0_Internal_Int64_MemoryGroup_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_1_Internal_Int64_MemoryGroup_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_2_Internal_Int64_MemoryGroup_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_3_Internal_Int64_Contributor_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetSameLengthSumStrings_b__15_0_Internal_Int32_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_0_Internal_Int32_Item_Item_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_1_Internal_Int32_Item_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_2_Internal_Int64_Item_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpQueryArchetypes_b__28_0_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpArchetypeInformation_b__31_0_Internal_Int32_ArchetypeInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpArchetypeInformation_b__31_1_Internal_Int32_TypeWithInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpArchetypeInformation_b__31_2_Internal_Int32_TypeWithInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpArchetypeInformation_b__31_3_Internal_Int32_TypeWithInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpComponentTypes_b__32_0_Internal_Int32_KeyValuePair_2_ComponentType_List_1_List_1_TypeWithInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_0_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_1_Internal_Int32_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_2_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_3_Internal_String_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_4_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_5_Internal_Int32_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_6_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpChunkAnalysis_b__34_7_Internal_String_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_2_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_3_Internal_Int32_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_4_Internal_String_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_5_Internal_String_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_0_Internal_Int64_ValueTuple_2_Int64_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_1_Internal_Int64_ValueTuple_2_Int64_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_0_Internal_Boolean_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_1_Internal_Boolean_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_2_Internal_Boolean_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_3_Internal_Boolean_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_4_Internal_Boolean_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_5_Internal_Boolean_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_6_Internal_Boolean_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintData_b__43_0_Internal_String_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintData_b__43_1_Internal_String_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintData_b__43_2_Internal_String_PrefabGUIDEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintData_b__43_4_Internal_Int32_PrefabGUIDEntry_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645595, XrefRangeEnd = 1645606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__1_0(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe long _DumpBlobAssetMemoryFootprints_b__8_0(NativeMemoryAnalysis.BlobMemoryData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpBlobAssetMemoryFootprints_b__8_0_Internal_Int64_BlobMemoryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe long _WriteNativeMemorySummary_b__14_0(
        MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_0_Internal_Int64_MemoryGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe long _WriteNativeMemorySummary_b__14_1(
        MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_1_Internal_Int64_MemoryGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe long _WriteNativeMemorySummary_b__14_2(
        MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_2_Internal_Int64_MemoryGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe long _WriteNativeMemorySummary_b__14_3(
        MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_3_Internal_Int64_Contributor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _GetSameLengthSumStrings_b__15_0(string x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__GetSameLengthSumStrings_b__15_0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645606, XrefRangeEnd = 1645608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _DumpSystemCollectionsMemory_b__21_0(
        NativeMemoryAnalysis.Item a,
        NativeMemoryAnalysis.Item b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_0_Internal_Int32_Item_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _DumpSystemCollectionsMemory_b__21_1(NativeMemoryAnalysis.Item x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_1_Internal_Int32_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe long _DumpSystemCollectionsMemory_b__21_2(NativeMemoryAnalysis.Item x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_2_Internal_Int64_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _DumpQueryArchetypes_b__28_0(ComponentType q)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &q;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpQueryArchetypes_b__28_0_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645608, XrefRangeEnd = 1645627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _DumpArchetypeInformation_b__31_0(
        MemoryDumpConsoleCommandSystem.ArchetypeInfo a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_0_Internal_Int32_ArchetypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _DumpArchetypeInformation_b__31_1(
        MemoryDumpConsoleCommandSystem.TypeWithInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_1_Internal_Int32_TypeWithInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _DumpArchetypeInformation_b__31_2(
        MemoryDumpConsoleCommandSystem.TypeWithInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_2_Internal_Int32_TypeWithInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _DumpArchetypeInformation_b__31_3(
        MemoryDumpConsoleCommandSystem.TypeWithInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_3_Internal_Int32_TypeWithInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645627, XrefRangeEnd = 1645629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _DumpComponentTypes_b__32_0(
        KeyValuePair<ComponentType, List<List<MemoryDumpConsoleCommandSystem.TypeWithInfo>>> kvp)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) kvp));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpComponentTypes_b__32_0_Internal_Int32_KeyValuePair_2_ComponentType_List_1_List_1_TypeWithInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645629, XrefRangeEnd = 1645630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _DumpChunkAnalysis_b__34_0(
        KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_0_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645630, XrefRangeEnd = 1645634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _DumpChunkAnalysis_b__34_1(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_1_Internal_Int32_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _DumpChunkAnalysis_b__34_2(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_2_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(231)]
      [CachedScanResults(RefRangeStart = 76210, RefRangeEnd = 76441, XrefRangeStart = 76210, XrefRangeEnd = 76441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _DumpChunkAnalysis_b__34_3(string x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(x);
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645634, XrefRangeEnd = 1645635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _DumpChunkAnalysis_b__34_4(
        KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_4_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645635, XrefRangeEnd = 1645639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _DumpChunkAnalysis_b__34_5(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_5_Internal_Int32_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _DumpChunkAnalysis_b__34_6(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_6_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(231)]
      [CachedScanResults(RefRangeStart = 76210, RefRangeEnd = 76441, XrefRangeStart = 76210, XrefRangeEnd = 76441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _DumpChunkAnalysis_b__34_7(string x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(x);
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_7_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645639, XrefRangeEnd = 1645640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_2(
        KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_2_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645640, XrefRangeEnd = 1645644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_3(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_3_Internal_Int32_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_4(ComponentType x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_4_Internal_String_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(231)]
      [CachedScanResults(RefRangeStart = 76210, RefRangeEnd = 76441, XrefRangeStart = 76210, XrefRangeEnd = 76441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_5(string x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(x);
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_5_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      public unsafe long _SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_0(
        Il2CppSystem.ValueTuple<long, string> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_0_Internal_Int64_ValueTuple_2_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe long _SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_1(
        Il2CppSystem.ValueTuple<long, string> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_1_Internal_Int64_ValueTuple_2_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _DumpEntitySummaryForWorld_b__42_0(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_0_Internal_Boolean_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _DumpEntitySummaryForWorld_b__42_1(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_1_Internal_Boolean_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _DumpEntitySummaryForWorld_b__42_2(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_2_Internal_Boolean_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _DumpEntitySummaryForWorld_b__42_3(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_3_Internal_Boolean_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _DumpEntitySummaryForWorld_b__42_4(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_4_Internal_Boolean_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _DumpEntitySummaryForWorld_b__42_5(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_5_Internal_Boolean_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _DumpEntitySummaryForWorld_b__42_6(
        MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_6_Internal_Boolean_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645644, XrefRangeEnd = 1645645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintData_b__43_0(MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_0_Internal_String_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645645, XrefRangeEnd = 1645649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintData_b__43_1(MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_1_Internal_String_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645649, XrefRangeEnd = 1645650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintData_b__43_2(MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_2_Internal_String_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      public unsafe int _PrintData_b__43_4(MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_4_Internal_Int32_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__1_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__8_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__14_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__14_1");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__14_2");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__14_3");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__15_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__21_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__21_1");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__21_2");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__28_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__31_1");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__31_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__31_2");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__31_3");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__32_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_1");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_2");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_3");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_4");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_5");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_6");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__34_7");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__37_2");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__37_3");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__37_4");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__37_5");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__37_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__37_1");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__42_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__42_1");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__42_2");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__42_3");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__42_4");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__42_5");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__42_6");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__43_0");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__43_1");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__43_2");
        MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, "<>9__43_4");
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663754);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663755);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpBlobAssetMemoryFootprints_b__8_0_Internal_Int64_BlobMemoryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663756);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_0_Internal_Int64_MemoryGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663757);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_1_Internal_Int64_MemoryGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663758);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_2_Internal_Int64_MemoryGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663759);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__WriteNativeMemorySummary_b__14_3_Internal_Int64_Contributor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663760);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__GetSameLengthSumStrings_b__15_0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663761);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_0_Internal_Int32_Item_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663762);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_1_Internal_Int32_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663763);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpSystemCollectionsMemory_b__21_2_Internal_Int64_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663764);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpQueryArchetypes_b__28_0_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663765);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_0_Internal_Int32_ArchetypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663766);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_1_Internal_Int32_TypeWithInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663767);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_2_Internal_Int32_TypeWithInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663768);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpArchetypeInformation_b__31_3_Internal_Int32_TypeWithInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663769);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpComponentTypes_b__32_0_Internal_Int32_KeyValuePair_2_ComponentType_List_1_List_1_TypeWithInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663770);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_0_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663771);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_1_Internal_Int32_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663772);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_2_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663773);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663774);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_4_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663775);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_5_Internal_Int32_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663776);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_6_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663777);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpChunkAnalysis_b__34_7_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663778);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_2_Internal_Int32_KeyValuePair_Unboxed_2_EntityArchetype_ChunkContentCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663779);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_3_Internal_Int32_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663780);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_4_Internal_String_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663781);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_5_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663782);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_0_Internal_Int64_ValueTuple_2_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663783);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__SummarizeUnusedChunkSpacePerArchetypeAnalysis_b__37_1_Internal_Int64_ValueTuple_2_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663784);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_0_Internal_Boolean_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663785);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_1_Internal_Boolean_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663786);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_2_Internal_Boolean_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663787);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_3_Internal_Boolean_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663788);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_4_Internal_Boolean_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663789);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_5_Internal_Boolean_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663790);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__DumpEntitySummaryForWorld_b__42_6_Internal_Boolean_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663791);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_0_Internal_String_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663792);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_1_Internal_String_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663793);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_2_Internal_String_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663794);
        MemoryDumpConsoleCommandSystem.__c.NativeMethodInfoPtr__PrintData_b__43_4_Internal_Int32_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c>.NativeClassPtr, 100663795);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe MemoryDumpConsoleCommandSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (MemoryDumpConsoleCommandSystem.__c) null : new MemoryDumpConsoleCommandSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__1_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__1_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<NativeMemoryAnalysis.BlobMemoryData, long> __9__8_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<NativeMemoryAnalysis.BlobMemoryData, long>) null : new Il2CppSystem.Func<NativeMemoryAnalysis.BlobMemoryData, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long> __9__14_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long> __9__14_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long> __9__14_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.MemoryGroup, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor, long> __9__14_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor, long>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.MemorySummarizer.Contributor, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__14_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<string, int> __9__15_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, int>) null : new Il2CppSystem.Func<string, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<NativeMemoryAnalysis.Item> __9__21_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<NativeMemoryAnalysis.Item>) null : new Il2CppSystem.Comparison<NativeMemoryAnalysis.Item>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<NativeMemoryAnalysis.Item, int> __9__21_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<NativeMemoryAnalysis.Item, int>) null : new Il2CppSystem.Func<NativeMemoryAnalysis.Item, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<NativeMemoryAnalysis.Item, long> __9__21_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<NativeMemoryAnalysis.Item, long>) null : new Il2CppSystem.Func<NativeMemoryAnalysis.Item, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__21_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__28_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__28_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__28_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int> __9__31_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.ArchetypeInfo, int> __9__31_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.ArchetypeInfo, int>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.ArchetypeInfo, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int> __9__31_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int> __9__31_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.TypeWithInfo, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__31_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair<ComponentType, List<List<MemoryDumpConsoleCommandSystem.TypeWithInfo>>>, int> __9__32_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__32_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<ComponentType, List<List<MemoryDumpConsoleCommandSystem.TypeWithInfo>>>, int>) null : new Il2CppSystem.Func<KeyValuePair<ComponentType, List<List<MemoryDumpConsoleCommandSystem.TypeWithInfo>>>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__32_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int> __9__34_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int>) null : new Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, int> __9__34_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, int>) null : new Il2CppSystem.Func<ComponentType, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__34_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<string, string> __9__34_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, string>) null : new Il2CppSystem.Func<string, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int> __9__34_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int>) null : new Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, int> __9__34_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, int>) null : new Il2CppSystem.Func<ComponentType, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__34_6
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_6, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<string, string> __9__34_7
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_7, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, string>) null : new Il2CppSystem.Func<string, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__34_7, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int> __9__37_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int>) null : new Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, MemoryDumpConsoleCommandSystem.ChunkContentCount>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, int> __9__37_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, int>) null : new Il2CppSystem.Func<ComponentType, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ComponentType, string> __9__37_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, string>) null : new Il2CppSystem.Func<ComponentType, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<string, string> __9__37_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, string>) null : new Il2CppSystem.Func<string, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Il2CppSystem.ValueTuple<long, string>, long> __9__37_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.ValueTuple<long, string>, long>) null : new Il2CppSystem.Func<Il2CppSystem.ValueTuple<long, string>, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Il2CppSystem.ValueTuple<long, string>, long> __9__37_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.ValueTuple<long, string>, long>) null : new Il2CppSystem.Func<Il2CppSystem.ValueTuple<long, string>, long>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__37_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool> __9__42_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool> __9__42_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool> __9__42_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool> __9__42_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool> __9__42_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool> __9__42_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool> __9__42_6
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_6, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__42_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string> __9__43_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string> __9__43_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string> __9__43_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, int> __9__43_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, int>) null : new Il2CppSystem.Func<MemoryDumpConsoleCommandSystem.PrefabGUIDEntry, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MemoryDumpConsoleCommandSystem.__c.NativeFieldInfoPtr___9__43_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.MemoryDumpConsoleCommandSystem/<GetTargetWorlds>d__3")]
    public sealed class _GetTargetWorlds_d__3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_whichWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr___3__whichWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr__serverWorld_5__2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Unity_Entities_World__get_Current_Private_Virtual_Final_New_get_World_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Entities_World__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_World_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 181226, RefRangeEnd = 181236, XrefRangeStart = 181226, XrefRangeEnd = 181236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _GetTargetWorlds_d__3(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_param1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645650, XrefRangeEnd = 1645658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe World System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CUnity\u002EEntities\u002EWorld\u003E\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Unity_Entities_World__get_Current_Private_Virtual_Final_New_get_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645658, XrefRangeEnd = 1645663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645663, XrefRangeEnd = 1645672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<World> System_Collections_Generic_IEnumerable_Unity_Entities_World__GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Entities_World__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<World>) null : new IEnumerator<World>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static _GetTargetWorlds_d__3()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, "<GetTargetWorlds>d__3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, "<>1__state");
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, "<>2__current");
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, "<>l__initialThreadId");
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, "<>4__this");
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr_whichWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, nameof (whichWorld));
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___3__whichWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, "<>3__whichWorld");
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr__serverWorld_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, "<serverWorld>5__2");
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663796);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663797);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663798);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Unity_Entities_World__get_Current_Private_Virtual_Final_New_get_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663799);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663800);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663801);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Entities_World__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663802);
        MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3>.NativeClassPtr, 100663803);
      }

      public _GetTargetWorlds_d__3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe World __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int __l__initialThreadId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___l__initialThreadId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
        }
      }

      public unsafe MemoryDumpConsoleCommandSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MemoryDumpConsoleCommandSystem) null : new MemoryDumpConsoleCommandSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string whichWorld
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr_whichWorld)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr_whichWorld), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string __3__whichWorld
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___3__whichWorld)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr___3__whichWorld), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe World _serverWorld_5__2
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr__serverWorld_5__2));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem._GetTargetWorlds_d__3.NativeFieldInfoPtr__serverWorld_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.MemoryDumpConsoleCommandSystem/<>c__DisplayClass43_0")]
    public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PrintData_b__3_Internal_String_PrefabGUIDEntry_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass43_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645672, XrefRangeEnd = 1645676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PrintData_b__3(MemoryDumpConsoleCommandSystem.PrefabGUIDEntry x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__PrintData_b__3_Internal_String_PrefabGUIDEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c__DisplayClass43_0()
      {
        Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr, "<>c__DisplayClass43_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0>.NativeClassPtr);
        MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0>.NativeClassPtr, 100663804);
        MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0.NativeMethodInfoPtr__PrintData_b__3_Internal_String_PrefabGUIDEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0>.NativeClassPtr, 100663805);
      }

      public __c__DisplayClass43_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoryDumpConsoleCommandSystem.__c__DisplayClass43_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_ListToStringWithColumns_Public_Static_String_List_1_T_String_Il2CppReferenceArray_1_Func_2_T_String_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryDumpConsoleCommandSystem.NativeMethodInfoPtr_ListToStringWithColumns_Public_Static_String_List_1_T_String_Il2CppReferenceArray_1_Func_2_T_String_0, Il2CppClassPointerStore<MemoryDumpConsoleCommandSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
