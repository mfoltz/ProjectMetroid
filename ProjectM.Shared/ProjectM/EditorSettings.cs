// Decompiled with JetBrains decompiler
// Type: ProjectM.EditorSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class EditorSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_CreateServer;
    private static readonly IntPtr NativeFieldInfoPtr_CreateClient;
    private static readonly IntPtr NativeFieldInfoPtr_AutoConnect;
    private static readonly IntPtr NativeFieldInfoPtr_Address;
    private static readonly IntPtr NativeFieldInfoPtr_UseLidgrenNetwork;
    private static readonly IntPtr NativeFieldInfoPtr_FallbackToLidgrenOnFailure;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreSteamInitializationFailure;
    private static readonly IntPtr NativeFieldInfoPtr_AllowSkipAuth;
    private static readonly IntPtr NativeFieldInfoPtr_ConnectPassword;
    private static readonly IntPtr NativeFieldInfoPtr_FakePlatformId;
    private static readonly IntPtr NativeFieldInfoPtr_RunSteamInitialization;
    private static readonly IntPtr NativeFieldInfoPtr_RunVivoxInitialization;
    private static readonly IntPtr NativeFieldInfoPtr_RunEOSInitialization;
    private static readonly IntPtr NativeFieldInfoPtr_SimulatedLatencyMs;
    private static readonly IntPtr NativeFieldInfoPtr_SimulatedVariationMs;
    private static readonly IntPtr NativeFieldInfoPtr_SimulatedLossPercent;
    private static readonly IntPtr NativeFieldInfoPtr_SimulatedDuplicatePercent;
    private static readonly IntPtr NativeFieldInfoPtr_ClientWorldToView;
    private static readonly IntPtr NativeFieldInfoPtr_ClientCount;
    private static readonly IntPtr NativeFieldInfoPtr_GlobalSystemVersionStartValue;
    private static readonly IntPtr NativeFieldInfoPtr_ApplicationConversionTarget;
    private static readonly IntPtr NativeFieldInfoPtr_ClearTutorialObjectives;
    private static readonly IntPtr NativeFieldInfoPtr_RandomizeGenderAtStartup;
    private static readonly IntPtr NativeFieldInfoPtr_SkipIntroAnimations;
    private static readonly IntPtr NativeFieldInfoPtr_SkipLoadingScreen;
    private static readonly IntPtr NativeFieldInfoPtr_SkipCharacterCreation;
    private static readonly IntPtr NativeFieldInfoPtr_SetServerLauncherAsOwner;
    private static readonly IntPtr NativeFieldInfoPtr_AutoSave;
    private static readonly IntPtr NativeFieldInfoPtr_SaveOnExit;
    private static readonly IntPtr NativeFieldInfoPtr_LoadSaveOnStart;
    private static readonly IntPtr NativeFieldInfoPtr_LoadAllChunksOnStartup;
    private static readonly IntPtr NativeFieldInfoPtr_WaitForAllChunksToLoad;
    private static readonly IntPtr NativeFieldInfoPtr_LoadInitialChunksSynchronously;
    private static readonly IntPtr NativeFieldInfoPtr_AIDebugEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_AIForceFrameSkip;
    private static readonly IntPtr NativeFieldInfoPtr_SkipNewVBloodRevealMotions;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ServerConnectAddress_Public_get_String_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 751007, RefRangeEnd = 751009, XrefRangeStart = 750992, XrefRangeEnd = 751007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EditorSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EditorSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe string ServerConnectAddress
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 751014, RefRangeEnd = 751015, XrefRangeStart = 751009, XrefRangeEnd = 751014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EditorSettings.NativeMethodInfoPtr_get_ServerConnectAddress_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    static EditorSettings()
    {
      Il2CppClassPointerStore<EditorSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EditorSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr);
      EditorSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (DefaultPath));
      EditorSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (LocalPath));
      EditorSettings.NativeFieldInfoPtr_CreateServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (CreateServer));
      EditorSettings.NativeFieldInfoPtr_CreateClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (CreateClient));
      EditorSettings.NativeFieldInfoPtr_AutoConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (AutoConnect));
      EditorSettings.NativeFieldInfoPtr_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (Address));
      EditorSettings.NativeFieldInfoPtr_UseLidgrenNetwork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (UseLidgrenNetwork));
      EditorSettings.NativeFieldInfoPtr_FallbackToLidgrenOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (FallbackToLidgrenOnFailure));
      EditorSettings.NativeFieldInfoPtr_IgnoreSteamInitializationFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (IgnoreSteamInitializationFailure));
      EditorSettings.NativeFieldInfoPtr_AllowSkipAuth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (AllowSkipAuth));
      EditorSettings.NativeFieldInfoPtr_ConnectPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (ConnectPassword));
      EditorSettings.NativeFieldInfoPtr_FakePlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (FakePlatformId));
      EditorSettings.NativeFieldInfoPtr_RunSteamInitialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (RunSteamInitialization));
      EditorSettings.NativeFieldInfoPtr_RunVivoxInitialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (RunVivoxInitialization));
      EditorSettings.NativeFieldInfoPtr_RunEOSInitialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (RunEOSInitialization));
      EditorSettings.NativeFieldInfoPtr_SimulatedLatencyMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SimulatedLatencyMs));
      EditorSettings.NativeFieldInfoPtr_SimulatedVariationMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SimulatedVariationMs));
      EditorSettings.NativeFieldInfoPtr_SimulatedLossPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SimulatedLossPercent));
      EditorSettings.NativeFieldInfoPtr_SimulatedDuplicatePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SimulatedDuplicatePercent));
      EditorSettings.NativeFieldInfoPtr_ClientWorldToView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (ClientWorldToView));
      EditorSettings.NativeFieldInfoPtr_ClientCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (ClientCount));
      EditorSettings.NativeFieldInfoPtr_GlobalSystemVersionStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (GlobalSystemVersionStartValue));
      EditorSettings.NativeFieldInfoPtr_ApplicationConversionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (ApplicationConversionTarget));
      EditorSettings.NativeFieldInfoPtr_ClearTutorialObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (ClearTutorialObjectives));
      EditorSettings.NativeFieldInfoPtr_RandomizeGenderAtStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (RandomizeGenderAtStartup));
      EditorSettings.NativeFieldInfoPtr_SkipIntroAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SkipIntroAnimations));
      EditorSettings.NativeFieldInfoPtr_SkipLoadingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SkipLoadingScreen));
      EditorSettings.NativeFieldInfoPtr_SkipCharacterCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SkipCharacterCreation));
      EditorSettings.NativeFieldInfoPtr_SetServerLauncherAsOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SetServerLauncherAsOwner));
      EditorSettings.NativeFieldInfoPtr_AutoSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (AutoSave));
      EditorSettings.NativeFieldInfoPtr_SaveOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SaveOnExit));
      EditorSettings.NativeFieldInfoPtr_LoadSaveOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (LoadSaveOnStart));
      EditorSettings.NativeFieldInfoPtr_LoadAllChunksOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (LoadAllChunksOnStartup));
      EditorSettings.NativeFieldInfoPtr_WaitForAllChunksToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (WaitForAllChunksToLoad));
      EditorSettings.NativeFieldInfoPtr_LoadInitialChunksSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (LoadInitialChunksSynchronously));
      EditorSettings.NativeFieldInfoPtr_AIDebugEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (AIDebugEnabled));
      EditorSettings.NativeFieldInfoPtr_AIForceFrameSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (AIForceFrameSkip));
      EditorSettings.NativeFieldInfoPtr_SkipNewVBloodRevealMotions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, nameof (SkipNewVBloodRevealMotions));
      EditorSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, 100666127);
      EditorSettings.NativeMethodInfoPtr_get_ServerConnectAddress_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSettings>.NativeClassPtr, 100666128);
    }

    public EditorSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EditorSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EditorSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EditorSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EditorSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool CreateServer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_CreateServer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_CreateServer)) = value;
      }
    }

    public unsafe bool CreateClient
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_CreateClient));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_CreateClient)) = value;
      }
    }

    public unsafe bool AutoConnect
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AutoConnect));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AutoConnect)) = value;
      }
    }

    public unsafe string Address
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_Address)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_Address), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool UseLidgrenNetwork
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_UseLidgrenNetwork));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_UseLidgrenNetwork)) = value;
      }
    }

    public unsafe bool FallbackToLidgrenOnFailure
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_FallbackToLidgrenOnFailure));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_FallbackToLidgrenOnFailure)) = value;
      }
    }

    public unsafe bool IgnoreSteamInitializationFailure
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_IgnoreSteamInitializationFailure));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_IgnoreSteamInitializationFailure)) = value;
      }
    }

    public unsafe bool AllowSkipAuth
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AllowSkipAuth));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AllowSkipAuth)) = value;
      }
    }

    public unsafe string ConnectPassword
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ConnectPassword)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ConnectPassword), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ulong FakePlatformId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_FakePlatformId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_FakePlatformId)) = value;
      }
    }

    public unsafe bool RunSteamInitialization
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RunSteamInitialization));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RunSteamInitialization)) = value;
      }
    }

    public unsafe bool RunVivoxInitialization
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RunVivoxInitialization));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RunVivoxInitialization)) = value;
      }
    }

    public unsafe bool RunEOSInitialization
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RunEOSInitialization));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RunEOSInitialization)) = value;
      }
    }

    public unsafe int SimulatedLatencyMs
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedLatencyMs));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedLatencyMs)) = value;
      }
    }

    public unsafe int SimulatedVariationMs
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedVariationMs));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedVariationMs)) = value;
      }
    }

    public unsafe int SimulatedLossPercent
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedLossPercent));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedLossPercent)) = value;
      }
    }

    public unsafe int SimulatedDuplicatePercent
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedDuplicatePercent));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SimulatedDuplicatePercent)) = value;
      }
    }

    public unsafe int ClientWorldToView
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ClientWorldToView));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ClientWorldToView)) = value;
      }
    }

    public unsafe int ClientCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ClientCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ClientCount)) = value;
      }
    }

    public unsafe long GlobalSystemVersionStartValue
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_GlobalSystemVersionStartValue));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_GlobalSystemVersionStartValue)) = value;
      }
    }

    public unsafe ApplicationConversionTarget ApplicationConversionTarget
    {
      get
      {
        return *(ApplicationConversionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ApplicationConversionTarget));
      }
      [param: In] set
      {
        *(ApplicationConversionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ApplicationConversionTarget)) = value;
      }
    }

    public unsafe bool ClearTutorialObjectives
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ClearTutorialObjectives));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_ClearTutorialObjectives)) = value;
      }
    }

    public unsafe bool RandomizeGenderAtStartup
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RandomizeGenderAtStartup));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_RandomizeGenderAtStartup)) = value;
      }
    }

    public unsafe bool SkipIntroAnimations
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipIntroAnimations));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipIntroAnimations)) = value;
      }
    }

    public unsafe bool SkipLoadingScreen
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipLoadingScreen));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipLoadingScreen)) = value;
      }
    }

    public unsafe bool SkipCharacterCreation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipCharacterCreation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipCharacterCreation)) = value;
      }
    }

    public unsafe bool SetServerLauncherAsOwner
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SetServerLauncherAsOwner));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SetServerLauncherAsOwner)) = value;
      }
    }

    public unsafe bool AutoSave
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AutoSave));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AutoSave)) = value;
      }
    }

    public unsafe bool SaveOnExit
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SaveOnExit));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SaveOnExit)) = value;
      }
    }

    public unsafe bool LoadSaveOnStart
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_LoadSaveOnStart));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_LoadSaveOnStart)) = value;
      }
    }

    public unsafe bool LoadAllChunksOnStartup
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_LoadAllChunksOnStartup));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_LoadAllChunksOnStartup)) = value;
      }
    }

    public unsafe bool WaitForAllChunksToLoad
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_WaitForAllChunksToLoad));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_WaitForAllChunksToLoad)) = value;
      }
    }

    public unsafe bool LoadInitialChunksSynchronously
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_LoadInitialChunksSynchronously));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_LoadInitialChunksSynchronously)) = value;
      }
    }

    public unsafe bool AIDebugEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AIDebugEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AIDebugEnabled)) = value;
      }
    }

    public unsafe int AIForceFrameSkip
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AIForceFrameSkip));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_AIForceFrameSkip)) = value;
      }
    }

    public unsafe bool SkipNewVBloodRevealMotions
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipNewVBloodRevealMotions));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EditorSettings.NativeFieldInfoPtr_SkipNewVBloodRevealMotions)) = value;
      }
    }
  }
}
