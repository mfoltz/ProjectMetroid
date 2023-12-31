// Decompiled with JetBrains decompiler
// Type: ProjectM.SettingsManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class SettingsManager : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedVersionDataSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedClientSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedServerSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedEditorSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedGameDataSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedServerGameSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedVoipSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__VersionData;
    private static readonly System.IntPtr NativeFieldInfoPtr__EditorSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerHostSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerVoipSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VersionData_Public_Static_get_VersionDataSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EditorSettings_Public_Static_get_EditorSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientSettings_Public_Static_get_ClientSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerHostSettings_Public_Static_get_ServerHostSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerVoipSettings_Public_Static_get_ServerVoipSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameDataSettings_Public_Static_get_GameDataSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerGameSettings_Public_Static_get_ServerGameSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCopyLatestSettings_Public_Static_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadAllSettings_Public_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TagEverythingForReload_Private_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadVersionDataSettings_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadClientSettings_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadServerSettings_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadVoipSettings_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadGameDataSettings_Public_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReloadEditorSettings_Public_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyVersionDataSettings_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyClientSettings_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyServerSettings_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyVoipSettings_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyGameDataSettings_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyServerGameSettings_Private_Static_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyEditorSettings_Private_Static_Void_Boolean_0;

    public static unsafe VersionDataSettings VersionData
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 749538, RefRangeEnd = 749543, XrefRangeStart = 749535, XrefRangeEnd = 749538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_get_VersionData_Public_Static_get_VersionDataSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (VersionDataSettings) null : new VersionDataSettings(pointer);
      }
    }

    public static unsafe EditorSettings EditorSettings
    {
      [CallerCount(31), CachedScanResults(RefRangeStart = 749546, RefRangeEnd = 749577, XrefRangeStart = 749543, XrefRangeEnd = 749546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_get_EditorSettings_Public_Static_get_EditorSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EditorSettings) null : new EditorSettings(pointer);
      }
    }

    public static unsafe ClientSettings ClientSettings
    {
      [CallerCount(218), CachedScanResults(RefRangeStart = 749580, RefRangeEnd = 749798, XrefRangeStart = 749577, XrefRangeEnd = 749580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_get_ClientSettings_Public_Static_get_ClientSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ClientSettings) null : new ClientSettings(pointer);
      }
    }

    public static unsafe ServerHostSettings ServerHostSettings
    {
      [CallerCount(61), CachedScanResults(RefRangeStart = 749801, RefRangeEnd = 749862, XrefRangeStart = 749798, XrefRangeEnd = 749801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_get_ServerHostSettings_Public_Static_get_ServerHostSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerHostSettings) null : new ServerHostSettings(pointer);
      }
    }

    public static unsafe ServerVoipSettings ServerVoipSettings
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 749865, RefRangeEnd = 749874, XrefRangeStart = 749862, XrefRangeEnd = 749865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_get_ServerVoipSettings_Public_Static_get_ServerVoipSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerVoipSettings) null : new ServerVoipSettings(pointer);
      }
    }

    public static unsafe GameDataSettings GameDataSettings
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 749877, RefRangeEnd = 749889, XrefRangeStart = 749874, XrefRangeEnd = 749877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_get_GameDataSettings_Public_Static_get_GameDataSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GameDataSettings) null : new GameDataSettings(pointer);
      }
    }

    public static unsafe ServerGameSettings ServerGameSettings
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 749892, RefRangeEnd = 749903, XrefRangeStart = 749889, XrefRangeEnd = 749892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_get_ServerGameSettings_Public_Static_get_ServerGameSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 749980, RefRangeEnd = 749985, XrefRangeStart = 749903, XrefRangeEnd = 749980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryCopyLatestSettings(string fileName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_TryCopyLatestSettings_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749985, XrefRangeEnd = 749999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReloadAllSettings(bool silentInitialize = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_ReloadAllSettings_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749999, XrefRangeEnd = 750006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TagEverythingForReload()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_TagEverythingForReload_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750006, XrefRangeEnd = 750009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReloadVersionDataSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_ReloadVersionDataSettings_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750009, XrefRangeEnd = 750012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReloadClientSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_ReloadClientSettings_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 750015, RefRangeEnd = 750016, XrefRangeStart = 750012, XrefRangeEnd = 750015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReloadServerSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_ReloadServerSettings_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750016, XrefRangeEnd = 750019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReloadVoipSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_ReloadVoipSettings_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750019, XrefRangeEnd = 750022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReloadGameDataSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_ReloadGameDataSettings_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750022, XrefRangeEnd = 750025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReloadEditorSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_ReloadEditorSettings_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 750045, RefRangeEnd = 750048, XrefRangeStart = 750025, XrefRangeEnd = 750045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void VerifyVersionDataSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_VerifyVersionDataSettings_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 750087, RefRangeEnd = 750090, XrefRangeStart = 750048, XrefRangeEnd = 750087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void VerifyClientSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_VerifyClientSettings_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 750236, RefRangeEnd = 750240, XrefRangeStart = 750090, XrefRangeEnd = 750236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void VerifyServerSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_VerifyServerSettings_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 750266, RefRangeEnd = 750269, XrefRangeStart = 750240, XrefRangeEnd = 750266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void VerifyVoipSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_VerifyVoipSettings_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 750280, RefRangeEnd = 750283, XrefRangeStart = 750269, XrefRangeEnd = 750280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void VerifyGameDataSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_VerifyGameDataSettings_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 750308, RefRangeEnd = 750310, XrefRangeStart = 750283, XrefRangeEnd = 750308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void VerifyServerGameSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_VerifyServerGameSettings_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 750321, RefRangeEnd = 750324, XrefRangeStart = 750310, XrefRangeEnd = 750321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void VerifyEditorSettings(bool silentInitialize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &silentInitialize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsManager.NativeMethodInfoPtr_VerifyEditorSettings_Private_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SettingsManager()
    {
      Il2CppClassPointerStore<SettingsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SettingsManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr);
      SettingsManager.NativeFieldInfoPtr__InitializedVersionDataSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_InitializedVersionDataSettings));
      SettingsManager.NativeFieldInfoPtr__InitializedClientSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_InitializedClientSettings));
      SettingsManager.NativeFieldInfoPtr__InitializedServerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_InitializedServerSettings));
      SettingsManager.NativeFieldInfoPtr__InitializedEditorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_InitializedEditorSettings));
      SettingsManager.NativeFieldInfoPtr__InitializedGameDataSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_InitializedGameDataSettings));
      SettingsManager.NativeFieldInfoPtr__InitializedServerGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_InitializedServerGameSettings));
      SettingsManager.NativeFieldInfoPtr__InitializedVoipSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_InitializedVoipSettings));
      SettingsManager.NativeFieldInfoPtr__VersionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_VersionData));
      SettingsManager.NativeFieldInfoPtr__EditorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_EditorSettings));
      SettingsManager.NativeFieldInfoPtr__ClientSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_ClientSettings));
      SettingsManager.NativeFieldInfoPtr__ServerHostSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_ServerHostSettings));
      SettingsManager.NativeFieldInfoPtr__ServerVoipSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_ServerVoipSettings));
      SettingsManager.NativeFieldInfoPtr__GameDataSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_GameDataSettings));
      SettingsManager.NativeFieldInfoPtr__ServerGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, nameof (_ServerGameSettings));
      SettingsManager.NativeMethodInfoPtr_get_VersionData_Public_Static_get_VersionDataSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666025);
      SettingsManager.NativeMethodInfoPtr_get_EditorSettings_Public_Static_get_EditorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666026);
      SettingsManager.NativeMethodInfoPtr_get_ClientSettings_Public_Static_get_ClientSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666027);
      SettingsManager.NativeMethodInfoPtr_get_ServerHostSettings_Public_Static_get_ServerHostSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666028);
      SettingsManager.NativeMethodInfoPtr_get_ServerVoipSettings_Public_Static_get_ServerVoipSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666029);
      SettingsManager.NativeMethodInfoPtr_get_GameDataSettings_Public_Static_get_GameDataSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666030);
      SettingsManager.NativeMethodInfoPtr_get_ServerGameSettings_Public_Static_get_ServerGameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666031);
      SettingsManager.NativeMethodInfoPtr_TryCopyLatestSettings_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666032);
      SettingsManager.NativeMethodInfoPtr_ReloadAllSettings_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666033);
      SettingsManager.NativeMethodInfoPtr_TagEverythingForReload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666034);
      SettingsManager.NativeMethodInfoPtr_ReloadVersionDataSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666035);
      SettingsManager.NativeMethodInfoPtr_ReloadClientSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666036);
      SettingsManager.NativeMethodInfoPtr_ReloadServerSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666037);
      SettingsManager.NativeMethodInfoPtr_ReloadVoipSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666038);
      SettingsManager.NativeMethodInfoPtr_ReloadGameDataSettings_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666039);
      SettingsManager.NativeMethodInfoPtr_ReloadEditorSettings_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666040);
      SettingsManager.NativeMethodInfoPtr_VerifyVersionDataSettings_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666041);
      SettingsManager.NativeMethodInfoPtr_VerifyClientSettings_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666042);
      SettingsManager.NativeMethodInfoPtr_VerifyServerSettings_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666043);
      SettingsManager.NativeMethodInfoPtr_VerifyVoipSettings_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666044);
      SettingsManager.NativeMethodInfoPtr_VerifyGameDataSettings_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666045);
      SettingsManager.NativeMethodInfoPtr_VerifyServerGameSettings_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666046);
      SettingsManager.NativeMethodInfoPtr_VerifyEditorSettings_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100666047);
    }

    public SettingsManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool _InitializedVersionDataSettings
    {
      get
      {
        bool versionDataSettings;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__InitializedVersionDataSettings, (void*) &versionDataSettings);
        return versionDataSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__InitializedVersionDataSettings, (void*) &value);
      }
    }

    public static unsafe bool _InitializedClientSettings
    {
      get
      {
        bool initializedClientSettings;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__InitializedClientSettings, (void*) &initializedClientSettings);
        return initializedClientSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__InitializedClientSettings, (void*) &value);
      }
    }

    public static unsafe bool _InitializedServerSettings
    {
      get
      {
        bool initializedServerSettings;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__InitializedServerSettings, (void*) &initializedServerSettings);
        return initializedServerSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__InitializedServerSettings, (void*) &value);
      }
    }

    public static unsafe bool _InitializedEditorSettings
    {
      get
      {
        bool initializedEditorSettings;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__InitializedEditorSettings, (void*) &initializedEditorSettings);
        return initializedEditorSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__InitializedEditorSettings, (void*) &value);
      }
    }

    public static unsafe bool _InitializedGameDataSettings
    {
      get
      {
        bool gameDataSettings;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__InitializedGameDataSettings, (void*) &gameDataSettings);
        return gameDataSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__InitializedGameDataSettings, (void*) &value);
      }
    }

    public static unsafe bool _InitializedServerGameSettings
    {
      get
      {
        bool serverGameSettings;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__InitializedServerGameSettings, (void*) &serverGameSettings);
        return serverGameSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__InitializedServerGameSettings, (void*) &value);
      }
    }

    public static unsafe bool _InitializedVoipSettings
    {
      get
      {
        bool initializedVoipSettings;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__InitializedVoipSettings, (void*) &initializedVoipSettings);
        return initializedVoipSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__InitializedVoipSettings, (void*) &value);
      }
    }

    public static unsafe VersionDataSettings _VersionData
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__VersionData, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (VersionDataSettings) null : new VersionDataSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__VersionData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe EditorSettings _EditorSettings
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__EditorSettings, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EditorSettings) null : new EditorSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__EditorSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ClientSettings _ClientSettings
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__ClientSettings, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ClientSettings) null : new ClientSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__ClientSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ServerHostSettings _ServerHostSettings
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__ServerHostSettings, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerHostSettings) null : new ServerHostSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__ServerHostSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ServerVoipSettings _ServerVoipSettings
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__ServerVoipSettings, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerVoipSettings) null : new ServerVoipSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__ServerVoipSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe GameDataSettings _GameDataSettings
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__GameDataSettings, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GameDataSettings) null : new GameDataSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__GameDataSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ServerGameSettings _ServerGameSettings
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SettingsManager.NativeFieldInfoPtr__ServerGameSettings, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsManager.NativeFieldInfoPtr__ServerGameSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
