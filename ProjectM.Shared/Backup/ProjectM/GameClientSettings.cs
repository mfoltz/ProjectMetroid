// Decompiled with JetBrains decompiler
// Type: ProjectM.GameClientSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class GameClientSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_SavedCharacterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecordClientReplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayLatestClientReplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableGameAnalytics;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalyticsEnvironment;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClearCompletedTutorialsOnCharacterCreate;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompletedTutorials;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaximumHandshakeAttempts;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionTimeout;
    private static readonly System.IntPtr NativeFieldInfoPtr_BetaInformationURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasSeenCinematic;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasCompletedFirstStartupV2;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableDebugLogsOverlayByDefault;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseEOSServerSearch;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerName;
    private static readonly System.IntPtr NativeFieldInfoPtr_DiscoverLocalPeers;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideWrongVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideFullServers;
    private static readonly System.IntPtr NativeFieldInfoPtr_PopupsShown;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableBacktraceANR;
    private static readonly System.IntPtr NativeFieldInfoPtr_Interpolation;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748712, RefRangeEnd = 748713, XrefRangeStart = 748693, XrefRangeEnd = 748712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameClientSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameClientSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameClientSettings()
    {
      Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameClientSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr);
      GameClientSettings.NativeFieldInfoPtr_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (UserName));
      GameClientSettings.NativeFieldInfoPtr_SavedCharacterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (SavedCharacterName));
      GameClientSettings.NativeFieldInfoPtr_RecordClientReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (RecordClientReplay));
      GameClientSettings.NativeFieldInfoPtr_PlayLatestClientReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (PlayLatestClientReplay));
      GameClientSettings.NativeFieldInfoPtr_EnableGameAnalytics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (EnableGameAnalytics));
      GameClientSettings.NativeFieldInfoPtr_AnalyticsEnvironment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (AnalyticsEnvironment));
      GameClientSettings.NativeFieldInfoPtr_ClearCompletedTutorialsOnCharacterCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (ClearCompletedTutorialsOnCharacterCreate));
      GameClientSettings.NativeFieldInfoPtr_CompletedTutorials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (CompletedTutorials));
      GameClientSettings.NativeFieldInfoPtr_MaximumHandshakeAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (MaximumHandshakeAttempts));
      GameClientSettings.NativeFieldInfoPtr_ConnectionTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (ConnectionTimeout));
      GameClientSettings.NativeFieldInfoPtr_BetaInformationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (BetaInformationURL));
      GameClientSettings.NativeFieldInfoPtr_ServerListURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (ServerListURL));
      GameClientSettings.NativeFieldInfoPtr_HasSeenCinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (HasSeenCinematic));
      GameClientSettings.NativeFieldInfoPtr_HasCompletedFirstStartupV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (HasCompletedFirstStartupV2));
      GameClientSettings.NativeFieldInfoPtr_EnableDebugLogsOverlayByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (EnableDebugLogsOverlayByDefault));
      GameClientSettings.NativeFieldInfoPtr_UseEOSServerSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (UseEOSServerSearch));
      GameClientSettings.NativeFieldInfoPtr_ServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (ServerName));
      GameClientSettings.NativeFieldInfoPtr_DiscoverLocalPeers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (DiscoverLocalPeers));
      GameClientSettings.NativeFieldInfoPtr_HideWrongVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (HideWrongVersion));
      GameClientSettings.NativeFieldInfoPtr_HideFullServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (HideFullServers));
      GameClientSettings.NativeFieldInfoPtr_PopupsShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (PopupsShown));
      GameClientSettings.NativeFieldInfoPtr_EnableBacktraceANR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (EnableBacktraceANR));
      GameClientSettings.NativeFieldInfoPtr_Interpolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (Interpolation));
      GameClientSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, 100665920);
    }

    public GameClientSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string UserName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_UserName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_UserName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string SavedCharacterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_SavedCharacterName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_SavedCharacterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool RecordClientReplay
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_RecordClientReplay));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_RecordClientReplay)) = value;
      }
    }

    public unsafe bool PlayLatestClientReplay
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_PlayLatestClientReplay));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_PlayLatestClientReplay)) = value;
      }
    }

    public unsafe bool EnableGameAnalytics
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_EnableGameAnalytics));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_EnableGameAnalytics)) = value;
      }
    }

    public unsafe string AnalyticsEnvironment
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_AnalyticsEnvironment)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_AnalyticsEnvironment), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool ClearCompletedTutorialsOnCharacterCreate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ClearCompletedTutorialsOnCharacterCreate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ClearCompletedTutorialsOnCharacterCreate)) = value;
      }
    }

    public unsafe int CompletedTutorials
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_CompletedTutorials));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_CompletedTutorials)) = value;
      }
    }

    public unsafe int MaximumHandshakeAttempts
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_MaximumHandshakeAttempts));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_MaximumHandshakeAttempts)) = value;
      }
    }

    public unsafe float ConnectionTimeout
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ConnectionTimeout));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ConnectionTimeout)) = value;
      }
    }

    public unsafe string BetaInformationURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_BetaInformationURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_BetaInformationURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ServerListURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ServerListURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ServerListURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool HasSeenCinematic
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HasSeenCinematic));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HasSeenCinematic)) = value;
      }
    }

    public unsafe bool HasCompletedFirstStartupV2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HasCompletedFirstStartupV2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HasCompletedFirstStartupV2)) = value;
      }
    }

    public unsafe bool EnableDebugLogsOverlayByDefault
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_EnableDebugLogsOverlayByDefault));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_EnableDebugLogsOverlayByDefault)) = value;
      }
    }

    public unsafe bool UseEOSServerSearch
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_UseEOSServerSearch));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_UseEOSServerSearch)) = value;
      }
    }

    public unsafe string ServerName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ServerName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_ServerName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool DiscoverLocalPeers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_DiscoverLocalPeers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_DiscoverLocalPeers)) = value;
      }
    }

    public unsafe bool HideWrongVersion
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HideWrongVersion));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HideWrongVersion)) = value;
      }
    }

    public unsafe bool HideFullServers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HideFullServers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_HideFullServers)) = value;
      }
    }

    public unsafe PopupsShownFlag PopupsShown
    {
      get
      {
        return *(PopupsShownFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_PopupsShown));
      }
      [param: In] set
      {
        *(PopupsShownFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_PopupsShown)) = value;
      }
    }

    public unsafe bool EnableBacktraceANR
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_EnableBacktraceANR));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_EnableBacktraceANR)) = value;
      }
    }

    public unsafe GameClientSettings.InterpolationSettings Interpolation
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_Interpolation));
        return pointer == System.IntPtr.Zero ? (GameClientSettings.InterpolationSettings) null : new GameClientSettings.InterpolationSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.NativeFieldInfoPtr_Interpolation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class InterpolationSettings : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DurationMs;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExtrapolateOnFail;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 748692, RefRangeEnd = 748693, XrefRangeStart = 748691, XrefRangeEnd = 748692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InterpolationSettings()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameClientSettings.InterpolationSettings>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameClientSettings.InterpolationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InterpolationSettings()
      {
        Il2CppClassPointerStore<GameClientSettings.InterpolationSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameClientSettings>.NativeClassPtr, nameof (InterpolationSettings));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameClientSettings.InterpolationSettings>.NativeClassPtr);
        GameClientSettings.InterpolationSettings.NativeFieldInfoPtr_DurationMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings.InterpolationSettings>.NativeClassPtr, nameof (DurationMs));
        GameClientSettings.InterpolationSettings.NativeFieldInfoPtr_ExtrapolateOnFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameClientSettings.InterpolationSettings>.NativeClassPtr, nameof (ExtrapolateOnFail));
        GameClientSettings.InterpolationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameClientSettings.InterpolationSettings>.NativeClassPtr, 100665921);
      }

      public InterpolationSettings(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int DurationMs
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.InterpolationSettings.NativeFieldInfoPtr_DurationMs));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.InterpolationSettings.NativeFieldInfoPtr_DurationMs)) = value;
        }
      }

      public unsafe bool ExtrapolateOnFail
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.InterpolationSettings.NativeFieldInfoPtr_ExtrapolateOnFail));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameClientSettings.InterpolationSettings.NativeFieldInfoPtr_ExtrapolateOnFail)) = value;
        }
      }
    }
  }
}
