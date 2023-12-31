// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerRuntimeSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerRuntimeSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConversionMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveDirectoryPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveToLoad;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoSaveIntervalSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoSaveCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FirstTimeSpawnSetting;
    private static readonly System.IntPtr NativeFieldInfoPtr_PersistenceDebugFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoSave;
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveOnExit;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeepAliveOnError;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostLAN;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompressSaveFiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdminOnlyDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableDangerousDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_EveryoneIsAdmin;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HadLoadFile_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveFilesInSaveDirectory_Public_Static_Il2CppReferenceArray_1_Save_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServersWithSaves_Public_Static_List_1_SaveFileData_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetServersWithSaves_Public_Static_List_1_SaveFileData_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedFullSavePath_Public_Static_String_String_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedFullSavePath_Public_Static_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindMostRecentSave_Public_Static_Boolean_String_byref_Save_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindMostRecentAutoSave_Public_Static_Boolean_String_byref_Int32_byref_Save_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStandardSaveRoot_Public_Static_String_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateAllSaves_Private_Static_IEnumerable_1_Save_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CountsAsSaveFile_Private_Static_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteSave_Public_Static_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanupAutoSaves_Public_Static_Void_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteOldSaves_Private_Static_Void_String_SaveCleanupData_0;
    [FieldOffset(0)]
    public PrefabConversionMethod ConversionMethod;
    [FieldOffset(4)]
    public FixedString512 SaveDirectoryPath;
    [FieldOffset(516)]
    public Nullable_Unboxed<FixedString512> SaveToLoad;
    [FieldOffset(1032)]
    public float AutoSaveIntervalSeconds;
    [FieldOffset(1036)]
    public int AutoSaveCount;
    [FieldOffset(1040)]
    public ServerStartupState StartupState;
    [FieldOffset(1048)]
    public FirstTimeSpawnServerSetting FirstTimeSpawnSetting;
    [FieldOffset(1052)]
    public PersistenceDebugFlags PersistenceDebugFlags;
    [FieldOffset(1053)]
    public bool AutoSave;
    [FieldOffset(1054)]
    public bool SaveOnExit;
    [FieldOffset(1055)]
    public bool KeepAliveOnError;
    [FieldOffset(1056)]
    public bool HostLAN;
    [FieldOffset(1057)]
    public bool CompressSaveFiles;
    [FieldOffset(1058)]
    public bool AllowDebugEvents;
    [FieldOffset(1059)]
    public bool AdminOnlyDebugEvents;
    [FieldOffset(1060)]
    public bool EnableDangerousDebugEvents;
    [FieldOffset(1061)]
    public bool EveryoneIsAdmin;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 735895, RefRangeEnd = 735897, XrefRangeStart = 735894, XrefRangeEnd = 735895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldSave()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 735898, RefRangeEnd = 735902, XrefRangeStart = 735897, XrefRangeEnd = 735898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HadLoadFile()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_HadLoadFile_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735902, XrefRangeEnd = 735916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppReferenceArray<ServerRuntimeSettings.Save> GetSaveFilesInSaveDirectory(
      string serverSavePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(serverSavePath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_GetSaveFilesInSaveDirectory_Public_Static_Il2CppReferenceArray_1_Save_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ServerRuntimeSettings.Save>) null : new Il2CppReferenceArray<ServerRuntimeSettings.Save>(nativeObject);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 735929, RefRangeEnd = 735932, XrefRangeStart = 735916, XrefRangeEnd = 735929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<SaveFileData> GetServersWithSaves(ulong platformId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &platformId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_GetServersWithSaves_Public_Static_List_1_SaveFileData_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<SaveFileData>) null : new List<SaveFileData>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 735999, RefRangeEnd = 736001, XrefRangeStart = 735932, XrefRangeEnd = 735999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<SaveFileData> _GetServersWithSaves(ulong platformId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &platformId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr__GetServersWithSaves_Public_Static_List_1_SaveFileData_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<SaveFileData>) null : new List<SaveFileData>(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 736006, RefRangeEnd = 736009, XrefRangeStart = 736001, XrefRangeEnd = 736006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetCombinedFullSavePath(string saveName, ulong platformId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &platformId;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_GetCombinedFullSavePath_Public_Static_String_String_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 736013, RefRangeEnd = 736015, XrefRangeStart = 736009, XrefRangeEnd = 736013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetCombinedFullSavePath(string saveDirectoryPath, string saveName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveName);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_GetCombinedFullSavePath_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 736045, RefRangeEnd = 736047, XrefRangeStart = 736015, XrefRangeEnd = 736045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindMostRecentSave(
      string saveDirectoryPath,
      out ServerRuntimeSettings.Save mostRecentSave)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_TryFindMostRecentSave_Public_Static_Boolean_String_byref_Save_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerRuntimeSettings.Save local = ref mostRecentSave;
      System.IntPtr pointer = zero;
      ServerRuntimeSettings.Save save = pointer == System.IntPtr.Zero ? (ServerRuntimeSettings.Save) null : new ServerRuntimeSettings.Save(pointer);
      local = save;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736075, RefRangeEnd = 736076, XrefRangeStart = 736047, XrefRangeEnd = 736075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindMostRecentAutoSave(
      string saveDirectoryPath,
      out int autoSaveIndex,
      out ServerRuntimeSettings.Save autoSaveData)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref autoSaveIndex;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_TryFindMostRecentAutoSave_Public_Static_Boolean_String_byref_Int32_byref_Save_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerRuntimeSettings.Save local = ref autoSaveData;
      System.IntPtr pointer = zero;
      ServerRuntimeSettings.Save save = pointer == System.IntPtr.Zero ? (ServerRuntimeSettings.Save) null : new ServerRuntimeSettings.Save(pointer);
      local = save;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 736109, RefRangeEnd = 736115, XrefRangeStart = 736076, XrefRangeEnd = 736109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetStandardSaveRoot(ulong platformId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &platformId;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_GetStandardSaveRoot_Public_Static_String_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 736121, RefRangeEnd = 736125, XrefRangeStart = 736115, XrefRangeEnd = 736121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IEnumerable<ServerRuntimeSettings.Save> IterateAllSaves(
      string saveDirectoryPath,
      string searchPattern)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_IterateAllSaves_Private_Static_IEnumerable_1_Save_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<ServerRuntimeSettings.Save>) null : new IEnumerable<ServerRuntimeSettings.Save>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736136, RefRangeEnd = 736137, XrefRangeStart = 736125, XrefRangeEnd = 736136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CountsAsSaveFile(string saveInstancePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveInstancePath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_CountsAsSaveFile_Private_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736138, RefRangeEnd = 736139, XrefRangeStart = 736137, XrefRangeEnd = 736138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeleteSave(string savePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(savePath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_DeleteSave_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 736235, RefRangeEnd = 736237, XrefRangeStart = 736139, XrefRangeEnd = 736235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CleanupAutoSaves(string saveDirectoryPath, int autoSaveCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &autoSaveCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_CleanupAutoSaves_Public_Static_Void_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736323, RefRangeEnd = 736324, XrefRangeStart = 736237, XrefRangeEnd = 736323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeleteOldSaves(string saveDirectoryPath, SaveCleanupData cleanupData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cleanupData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.NativeMethodInfoPtr_DeleteOldSaves_Private_Static_Void_String_SaveCleanupData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerRuntimeSettings()
    {
      Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerRuntimeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr);
      ServerRuntimeSettings.NativeFieldInfoPtr_ConversionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (ConversionMethod));
      ServerRuntimeSettings.NativeFieldInfoPtr_SaveDirectoryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (SaveDirectoryPath));
      ServerRuntimeSettings.NativeFieldInfoPtr_SaveToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (SaveToLoad));
      ServerRuntimeSettings.NativeFieldInfoPtr_AutoSaveIntervalSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (AutoSaveIntervalSeconds));
      ServerRuntimeSettings.NativeFieldInfoPtr_AutoSaveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (AutoSaveCount));
      ServerRuntimeSettings.NativeFieldInfoPtr_StartupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (StartupState));
      ServerRuntimeSettings.NativeFieldInfoPtr_FirstTimeSpawnSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (FirstTimeSpawnSetting));
      ServerRuntimeSettings.NativeFieldInfoPtr_PersistenceDebugFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (PersistenceDebugFlags));
      ServerRuntimeSettings.NativeFieldInfoPtr_AutoSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (AutoSave));
      ServerRuntimeSettings.NativeFieldInfoPtr_SaveOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (SaveOnExit));
      ServerRuntimeSettings.NativeFieldInfoPtr_KeepAliveOnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (KeepAliveOnError));
      ServerRuntimeSettings.NativeFieldInfoPtr_HostLAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (HostLAN));
      ServerRuntimeSettings.NativeFieldInfoPtr_CompressSaveFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (CompressSaveFiles));
      ServerRuntimeSettings.NativeFieldInfoPtr_AllowDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (AllowDebugEvents));
      ServerRuntimeSettings.NativeFieldInfoPtr_AdminOnlyDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (AdminOnlyDebugEvents));
      ServerRuntimeSettings.NativeFieldInfoPtr_EnableDangerousDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (EnableDangerousDebugEvents));
      ServerRuntimeSettings.NativeFieldInfoPtr_EveryoneIsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (EveryoneIsAdmin));
      ServerRuntimeSettings.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664971);
      ServerRuntimeSettings.NativeMethodInfoPtr_HadLoadFile_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664972);
      ServerRuntimeSettings.NativeMethodInfoPtr_GetSaveFilesInSaveDirectory_Public_Static_Il2CppReferenceArray_1_Save_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664973);
      ServerRuntimeSettings.NativeMethodInfoPtr_GetServersWithSaves_Public_Static_List_1_SaveFileData_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664974);
      ServerRuntimeSettings.NativeMethodInfoPtr__GetServersWithSaves_Public_Static_List_1_SaveFileData_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664975);
      ServerRuntimeSettings.NativeMethodInfoPtr_GetCombinedFullSavePath_Public_Static_String_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664976);
      ServerRuntimeSettings.NativeMethodInfoPtr_GetCombinedFullSavePath_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664977);
      ServerRuntimeSettings.NativeMethodInfoPtr_TryFindMostRecentSave_Public_Static_Boolean_String_byref_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664978);
      ServerRuntimeSettings.NativeMethodInfoPtr_TryFindMostRecentAutoSave_Public_Static_Boolean_String_byref_Int32_byref_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664979);
      ServerRuntimeSettings.NativeMethodInfoPtr_GetStandardSaveRoot_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664980);
      ServerRuntimeSettings.NativeMethodInfoPtr_IterateAllSaves_Private_Static_IEnumerable_1_Save_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664981);
      ServerRuntimeSettings.NativeMethodInfoPtr_CountsAsSaveFile_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664982);
      ServerRuntimeSettings.NativeMethodInfoPtr_DeleteSave_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664983);
      ServerRuntimeSettings.NativeMethodInfoPtr_CleanupAutoSaves_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664984);
      ServerRuntimeSettings.NativeMethodInfoPtr_DeleteOldSaves_Private_Static_Void_String_SaveCleanupData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, 100664985);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public sealed class Save : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_FullPath;
      private static readonly System.IntPtr NativeFieldInfoPtr_SaveName;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastWriteTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAutoSaveIndex_Public_Boolean_byref_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AgeInSeconds_Public_Int32_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735847, RefRangeEnd = 735848, XrefRangeStart = 735835, XrefRangeEnd = 735847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetAutoSaveIndex(out int autoSaveIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref autoSaveIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.Save.NativeMethodInfoPtr_TryGetAutoSaveIndex_Public_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735848, XrefRangeEnd = 735854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int AgeInSeconds()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.Save.NativeMethodInfoPtr_AgeInSeconds_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Save()
      {
        Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, nameof (Save));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr);
        ServerRuntimeSettings.Save.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, nameof (Type));
        ServerRuntimeSettings.Save.NativeFieldInfoPtr_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, nameof (FullPath));
        ServerRuntimeSettings.Save.NativeFieldInfoPtr_SaveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, nameof (SaveName));
        ServerRuntimeSettings.Save.NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, nameof (LastWriteTime));
        ServerRuntimeSettings.Save.NativeMethodInfoPtr_TryGetAutoSaveIndex_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, 100664986);
        ServerRuntimeSettings.Save.NativeMethodInfoPtr_AgeInSeconds_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, 100664987);
      }

      public Save(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Save()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, data));
      }

      public unsafe ServerRuntimeSettings.Save.SaveType Type
      {
        get
        {
          return *(ServerRuntimeSettings.Save.SaveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(ServerRuntimeSettings.Save.SaveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public unsafe string FullPath
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_FullPath)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_FullPath), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string SaveName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_SaveName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_SaveName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Il2CppSystem.DateTime LastWriteTime
      {
        get
        {
          return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_LastWriteTime));
        }
        [param: In] set
        {
          *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.Save.NativeFieldInfoPtr_LastWriteTime)) = value;
        }
      }

      public enum SaveType
      {
        File,
      }
    }

    [ObfuscatedName("ProjectM.ServerRuntimeSettings/<IterateAllSaves>d__28")]
    public sealed class _IterateAllSaves_d__28 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;
      private static readonly System.IntPtr NativeFieldInfoPtr_saveDirectoryPath;
      private static readonly System.IntPtr NativeFieldInfoPtr___3__saveDirectoryPath;
      private static readonly System.IntPtr NativeFieldInfoPtr_searchPattern;
      private static readonly System.IntPtr NativeFieldInfoPtr___3__searchPattern;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_ServerRuntimeSettings_Save__get_Current_Private_Virtual_Final_New_get_Save_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_ServerRuntimeSettings_Save__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Save_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 735856, RefRangeEnd = 735858, XrefRangeStart = 735854, XrefRangeEnd = 735856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _IterateAllSaves_d__28(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_param1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735858, XrefRangeEnd = 735872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe ServerRuntimeSettings.Save System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CProjectM\u002EServerRuntimeSettings\u002ESave\u003E\u002ECurrent
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_ServerRuntimeSettings_Save__get_Current_Private_Virtual_Final_New_get_Save_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new ServerRuntimeSettings.Save(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735872, XrefRangeEnd = 735877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735877, XrefRangeEnd = 735880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735880, XrefRangeEnd = 735889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<ServerRuntimeSettings.Save> System_Collections_Generic_IEnumerable_ProjectM_ServerRuntimeSettings_Save__GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_ServerRuntimeSettings_Save__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Save_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<ServerRuntimeSettings.Save>) null : new IEnumerator<ServerRuntimeSettings.Save>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static _IterateAllSaves_d__28()
      {
        Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, "<IterateAllSaves>d__28");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, "<>1__state");
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, "<>2__current");
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, "<>l__initialThreadId");
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr_saveDirectoryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, nameof (saveDirectoryPath));
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___3__saveDirectoryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, "<>3__saveDirectoryPath");
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr_searchPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, nameof (searchPattern));
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___3__searchPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, "<>3__searchPattern");
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, "<>7__wrap1");
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, "<>7__wrap2");
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664988);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664989);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664990);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_ProjectM_ServerRuntimeSettings_Save__get_Current_Private_Virtual_Final_New_get_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664991);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664992);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664993);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_ServerRuntimeSettings_Save__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664994);
        ServerRuntimeSettings._IterateAllSaves_d__28.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings._IterateAllSaves_d__28>.NativeClassPtr, 100664995);
      }

      public _IterateAllSaves_d__28(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public ServerRuntimeSettings.Save __2__current
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___2__current);
          return new ServerRuntimeSettings.Save(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerRuntimeSettings.Save>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe int __l__initialThreadId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___l__initialThreadId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___l__initialThreadId)) = value;
        }
      }

      public unsafe string saveDirectoryPath
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr_saveDirectoryPath)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr_saveDirectoryPath), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string __3__saveDirectoryPath
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___3__saveDirectoryPath)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___3__saveDirectoryPath), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string searchPattern
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr_searchPattern)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr_searchPattern), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string __3__searchPattern
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___3__searchPattern)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___3__searchPattern), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Il2CppStringArray __7__wrap1
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___7__wrap1));
          return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int __7__wrap2
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___7__wrap2));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings._IterateAllSaves_d__28.NativeFieldInfoPtr___7__wrap2)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerRuntimeSettings/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__31_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__32_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__32_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CleanupAutoSaves_b__31_0_Internal_Int32_Save_Save_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DeleteOldSaves_b__32_1_Internal_DateTime_Save_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DeleteOldSaves_b__32_2_Internal_DateTime_Save_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735889, XrefRangeEnd = 735890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _CleanupAutoSaves_b__31_0(
        ServerRuntimeSettings.Save a,
        ServerRuntimeSettings.Save b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.__c.NativeMethodInfoPtr__CleanupAutoSaves_b__31_0_Internal_Int32_Save_Save_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe Il2CppSystem.DateTime _DeleteOldSaves_b__32_1(ServerRuntimeSettings.Save save)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) save));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.__c.NativeMethodInfoPtr__DeleteOldSaves_b__32_1_Internal_DateTime_Save_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe Il2CppSystem.DateTime _DeleteOldSaves_b__32_2(ServerRuntimeSettings.Save save)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) save));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.__c.NativeMethodInfoPtr__DeleteOldSaves_b__32_2_Internal_DateTime_Save_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr);
        ServerRuntimeSettings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, "<>9");
        ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, "<>9__31_0");
        ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, "<>9__32_1");
        ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, "<>9__32_2");
        ServerRuntimeSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, 100664997);
        ServerRuntimeSettings.__c.NativeMethodInfoPtr__CleanupAutoSaves_b__31_0_Internal_Int32_Save_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, 100664998);
        ServerRuntimeSettings.__c.NativeMethodInfoPtr__DeleteOldSaves_b__32_1_Internal_DateTime_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, 100664999);
        ServerRuntimeSettings.__c.NativeMethodInfoPtr__DeleteOldSaves_b__32_2_Internal_DateTime_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.__c>.NativeClassPtr, 100665000);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServerRuntimeSettings.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServerRuntimeSettings.__c) null : new ServerRuntimeSettings.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<ServerRuntimeSettings.Save> __9__31_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__31_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<ServerRuntimeSettings.Save>) null : new Il2CppSystem.Comparison<ServerRuntimeSettings.Save>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__31_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ServerRuntimeSettings.Save, Il2CppSystem.DateTime> __9__32_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__32_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ServerRuntimeSettings.Save, Il2CppSystem.DateTime>) null : new Il2CppSystem.Func<ServerRuntimeSettings.Save, Il2CppSystem.DateTime>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__32_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ServerRuntimeSettings.Save, Il2CppSystem.DateTime> __9__32_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__32_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ServerRuntimeSettings.Save, Il2CppSystem.DateTime>) null : new Il2CppSystem.Func<ServerRuntimeSettings.Save, Il2CppSystem.DateTime>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerRuntimeSettings.__c.NativeFieldInfoPtr___9__32_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerRuntimeSettings/<>c__DisplayClass32_0")]
    public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_cleanupData;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DeleteOldSaves_b__0_Internal_Boolean_Save_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass32_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerRuntimeSettings.__c__DisplayClass32_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735890, XrefRangeEnd = 735894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _DeleteOldSaves_b__0(ServerRuntimeSettings.Save save)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) save));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerRuntimeSettings.__c__DisplayClass32_0.NativeMethodInfoPtr__DeleteOldSaves_b__0_Internal_Boolean_Save_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass32_0()
      {
        Il2CppClassPointerStore<ServerRuntimeSettings.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerRuntimeSettings>.NativeClassPtr, "<>c__DisplayClass32_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerRuntimeSettings.__c__DisplayClass32_0>.NativeClassPtr);
        ServerRuntimeSettings.__c__DisplayClass32_0.NativeFieldInfoPtr_cleanupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerRuntimeSettings.__c__DisplayClass32_0>.NativeClassPtr, nameof (cleanupData));
        ServerRuntimeSettings.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.__c__DisplayClass32_0>.NativeClassPtr, 100665001);
        ServerRuntimeSettings.__c__DisplayClass32_0.NativeMethodInfoPtr__DeleteOldSaves_b__0_Internal_Boolean_Save_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerRuntimeSettings.__c__DisplayClass32_0>.NativeClassPtr, 100665002);
      }

      public __c__DisplayClass32_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SaveCleanupData cleanupData
      {
        get
        {
          return *(SaveCleanupData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.__c__DisplayClass32_0.NativeFieldInfoPtr_cleanupData));
        }
        [param: In] set
        {
          *(SaveCleanupData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerRuntimeSettings.__c__DisplayClass32_0.NativeFieldInfoPtr_cleanupData)) = value;
        }
      }
    }
  }
}
