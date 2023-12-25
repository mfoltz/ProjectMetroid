// Decompiled with JetBrains decompiler
// Type: ProjectM.DefaultWorldConsoleCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DefaultWorldConsoleCommandSystem : ConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientWorldManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogsFolderPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorLogsFolderPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_CrashDumpFolderPath;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ArchetypeCreationTrackingCommand_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BurstEnabled_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JobCompilerEnabled_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MaxQueuedFrames_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalAppDataPath_Public_Static_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenLogsFolder_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenLogsFolder_Public_Static_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenCrashDumpFolder_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenEditorLogsFolder_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetShouldPreWarmShaders_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVideoPlayMode_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LimitFPSClient_Private_Void_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoConnect_Private_Void_String_UInt16_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoConnect_Private_Void_String_UInt16_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoConnectLAN_Private_Void_String_UInt16_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoConnect_Private_Void_ConnectAddress_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reconnect_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JobThreads_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PerformChunkDefragmentationCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintDestroyEventsCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogDestroyEventsCommand_Private_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetOptimizedQueryStateCommand_Private_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MeasureSystemPerformance_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GCCollect_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogSceneLoadDurations_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDisableSystemDisabled_Private_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GarbageCollectArchetypesCommand_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFixCrash_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindWorld_Private_World_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_DefaultConsoleCommand_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643469, XrefRangeEnd = 1643974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1644020, RefRangeEnd = 1644021, XrefRangeStart = 1643974, XrefRangeEnd = 1644020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ArchetypeCreationTrackingCommand(string action, string worldName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(action);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(worldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_ArchetypeCreationTrackingCommand_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644021, XrefRangeEnd = 1644027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BurstEnabled(bool enabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_BurstEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644027, XrefRangeEnd = 1644028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JobCompilerEnabled(bool enabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_JobCompilerEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644028, XrefRangeEnd = 1644040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MaxQueuedFrames(string input)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_MaxQueuedFrames_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644040, XrefRangeEnd = 1644041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetLocalAppDataPath()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_GetLocalAppDataPath_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644041, XrefRangeEnd = 1644050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OpenLogsFolder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenLogsFolder_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644050, XrefRangeEnd = 1644055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OpenLogsFolder(string fileToSelect)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileToSelect);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenLogsFolder_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644055, XrefRangeEnd = 1644060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OpenCrashDumpFolder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenCrashDumpFolder_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644060, XrefRangeEnd = 1644065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OpenEditorLogsFolder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenEditorLogsFolder_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644065, XrefRangeEnd = 1644082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetShouldPreWarmShaders(bool prewarmShaders)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prewarmShaders;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetShouldPreWarmShaders_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644082, XrefRangeEnd = 1644126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetVideoPlayMode(string mode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(mode);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetVideoPlayMode_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644126, XrefRangeEnd = 1644132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LimitFPSClient(bool state, int maxFPS)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &state;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxFPS;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_LimitFPSClient_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1644183, RefRangeEnd = 1644185, XrefRangeStart = 1644132, XrefRangeEnd = 1644183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoConnect(string address, ushort port, string password, bool isLan)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(address);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(password);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isLan;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnect_Private_Void_String_UInt16_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644185, XrefRangeEnd = 1644186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoConnect(string address, ushort port, string password)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(address);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(password);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnect_Private_Void_String_UInt16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644186, XrefRangeEnd = 1644187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoConnectLAN(string address, ushort port, string password)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(address);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(password);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnectLAN_Private_Void_String_UInt16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1644202, RefRangeEnd = 1644204, XrefRangeStart = 1644187, XrefRangeEnd = 1644202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoConnect(ConnectAddress connectAddress, string password)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &connectAddress;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(password);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnect_Private_Void_ConnectAddress_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1644214, RefRangeEnd = 1644215, XrefRangeStart = 1644204, XrefRangeEnd = 1644214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reconnect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_Reconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644215, XrefRangeEnd = 1644232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JobThreads(int threads)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &threads;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_JobThreads_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644232, XrefRangeEnd = 1644252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PerformChunkDefragmentationCommand(string which)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_PerformChunkDefragmentationCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1644277, RefRangeEnd = 1644278, XrefRangeStart = 1644252, XrefRangeEnd = 1644277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintDestroyEventsCommand(string which)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_PrintDestroyEventsCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1644304, RefRangeEnd = 1644305, XrefRangeStart = 1644278, XrefRangeEnd = 1644304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogDestroyEventsCommand(string which, bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_LogDestroyEventsCommand_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644305, XrefRangeEnd = 1644321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetOptimizedQueryStateCommand(string which, bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetOptimizedQueryStateCommand_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644321, XrefRangeEnd = 1644322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MeasureSystemPerformance(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_MeasureSystemPerformance_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644322, XrefRangeEnd = 1644345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnloadUnusedAssets()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_UnloadUnusedAssets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644345, XrefRangeEnd = 1644349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GCCollect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_GCCollect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644349, XrefRangeEnd = 1644351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogSceneLoadDurations(bool enabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_LogSceneLoadDurations_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1644375, RefRangeEnd = 1644377, XrefRangeStart = 1644351, XrefRangeEnd = 1644375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDisableSystemDisabled(string which, bool disabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &disabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetDisableSystemDisabled_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644377, XrefRangeEnd = 1644393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GarbageCollectArchetypesCommand(string which)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(which);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_GarbageCollectArchetypesCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644393, XrefRangeEnd = 1644397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryFixCrash(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_TryFixCrash_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644397, XrefRangeEnd = 1644415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe World FindWorld(string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_FindWorld_Private_World_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 732837, RefRangeEnd = 732840, XrefRangeStart = 732837, XrefRangeEnd = 732840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DefaultWorldConsoleCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1644433, RefRangeEnd = 1644435, XrefRangeStart = 1644415, XrefRangeEnd = 1644433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Internal_Static_Void_DefaultConsoleCommand_Int32_0(
      DefaultConsoleCommand command,
      int argumentIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) command);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &argumentIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_Method_Internal_Static_Void_DefaultConsoleCommand_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DefaultWorldConsoleCommandSystem()
    {
      Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (DefaultWorldConsoleCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr);
      DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr__ClientWorldManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, nameof (_ClientWorldManager));
      DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_LogsFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, nameof (LogsFolderPath));
      DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_EditorLogsFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, nameof (EditorLogsFolderPath));
      DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_CrashDumpFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, nameof (CrashDumpFolderPath));
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663591);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_ArchetypeCreationTrackingCommand_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663592);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_BurstEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663593);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_JobCompilerEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663594);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_MaxQueuedFrames_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663595);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663596);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_GetLocalAppDataPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663597);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenLogsFolder_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663598);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenLogsFolder_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663599);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenCrashDumpFolder_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663600);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OpenEditorLogsFolder_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663601);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetShouldPreWarmShaders_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663602);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetVideoPlayMode_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663603);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_LimitFPSClient_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663604);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnect_Private_Void_String_UInt16_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663605);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnect_Private_Void_String_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663606);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnectLAN_Private_Void_String_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663607);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_DoConnect_Private_Void_ConnectAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663608);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_Reconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663609);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_JobThreads_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663610);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_PerformChunkDefragmentationCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663611);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_PrintDestroyEventsCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663612);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_LogDestroyEventsCommand_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663613);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetOptimizedQueryStateCommand_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663614);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_MeasureSystemPerformance_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663615);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_UnloadUnusedAssets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663616);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_GCCollect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663617);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_LogSceneLoadDurations_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663618);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_SetDisableSystemDisabled_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663619);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_GarbageCollectArchetypesCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663620);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_TryFixCrash_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663621);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_FindWorld_Private_World_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663622);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663623);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_Method_Internal_Static_Void_DefaultConsoleCommand_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663625);
      DefaultWorldConsoleCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, 100663626);
    }

    public DefaultWorldConsoleCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClientWorldManager _ClientWorldManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr__ClientWorldManager));
        return pointer == System.IntPtr.Zero ? (ClientWorldManager) null : new ClientWorldManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr__ClientWorldManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe string LogsFolderPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_LogsFolderPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_LogsFolderPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string EditorLogsFolderPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_EditorLogsFolderPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_EditorLogsFolderPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CrashDumpFolderPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_CrashDumpFolderPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DefaultWorldConsoleCommandSystem.NativeFieldInfoPtr_CrashDumpFolderPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [ObfuscatedName("ProjectM.DefaultWorldConsoleCommandSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_0_Internal_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_1_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643430, XrefRangeEnd = 1643433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_0(int x, int y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_0_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1643433, XrefRangeEnd = 1643469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__4_1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultWorldConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr);
        DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr, "<>9");
        DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_0");
        DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr, "<>9__4_1");
        DefaultWorldConsoleCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr, 100663628);
        DefaultWorldConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_0_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr, 100663629);
        DefaultWorldConsoleCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__4_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWorldConsoleCommandSystem.__c>.NativeClassPtr, 100663630);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DefaultWorldConsoleCommandSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DefaultWorldConsoleCommandSystem.__c) null : new DefaultWorldConsoleCommandSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<int, int> __9__4_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int, int>) null : new Il2CppSystem.Action<int, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action __9__4_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DefaultWorldConsoleCommandSystem.__c.NativeFieldInfoPtr___9__4_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
