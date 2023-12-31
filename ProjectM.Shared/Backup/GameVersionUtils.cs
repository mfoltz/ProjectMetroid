// Decompiled with JetBrains decompiler
// Type: GameVersionUtils
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM;
using System.Runtime.InteropServices;

#nullable disable
public static class GameVersionUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__GameVersionData;
  private static readonly System.IntPtr NativeFieldInfoPtr__PersistenceVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr__ApplicationType;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Major;
  private static readonly System.IntPtr NativeFieldInfoPtr_Minor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Patch;
  private static readonly System.IntPtr NativeFieldInfoPtr_Revision;
  private static readonly System.IntPtr NativeFieldInfoPtr_Date;
  private static readonly System.IntPtr NativeFieldInfoPtr_Meta;
  private static readonly System.IntPtr NativeFieldInfoPtr_ModString;
  private static readonly System.IntPtr NativeFieldInfoPtr_VersionString;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOrLoadPersistenceVersion_Public_Static_PersistenceVersion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVersionData_Public_Static_GameVersionData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializePersistenceVersion_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGameVersion_Public_Static_GameVersion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkVersion_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDateStringUTC_Private_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDateStringUTCShort_Private_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildMode_Private_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEditor_Private_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateData_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDedicatedServer_Public_Static_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDedicatedClient_Public_Static_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetApplicationType_Public_Static_ApplicationType_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplicationConversionTargetToApplicationType_Public_Static_ApplicationType_ApplicationConversionTarget_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDate_Private_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMeta_Private_Static_String_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 713719, RefRangeEnd = 713723, XrefRangeStart = 713703, XrefRangeEnd = 713719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PersistenceVersion GetOrLoadPersistenceVersion()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetOrLoadPersistenceVersion_Public_Static_PersistenceVersion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(PersistenceVersion*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 713895, RefRangeEnd = 713903, XrefRangeStart = 713723, XrefRangeEnd = 713895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameVersionData GetVersionData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetVersionData_Public_Static_GameVersionData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (GameVersionData) null : new GameVersionData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 713973, RefRangeEnd = 713974, XrefRangeStart = 713903, XrefRangeEnd = 713973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TryInitializePersistenceVersion()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_TryInitializePersistenceVersion_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 713978, RefRangeEnd = 713982, XrefRangeStart = 713974, XrefRangeEnd = 713978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameVersion GetGameVersion()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetGameVersion_Public_Static_GameVersion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(GameVersion*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 713996, RefRangeEnd = 714016, XrefRangeStart = 713982, XrefRangeEnd = 713996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetNetworkVersion()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetNetworkVersion_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 714026, RefRangeEnd = 714028, XrefRangeStart = 714016, XrefRangeEnd = 714026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDateStringUTC()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetDateStringUTC_Private_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714028, XrefRangeEnd = 714035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDateStringUTCShort()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetDateStringUTCShort_Private_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 714043, RefRangeEnd = 714045, XrefRangeStart = 714035, XrefRangeEnd = 714043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetBuildMode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetBuildMode_Private_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  public static unsafe bool IsEditor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714045, XrefRangeEnd = 714046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_get_IsEditor_Private_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 714144, RefRangeEnd = 714145, XrefRangeStart = 714046, XrefRangeEnd = 714144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GenerateData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GenerateData_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 714153, RefRangeEnd = 714155, XrefRangeStart = 714145, XrefRangeEnd = 714153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDedicatedServer(bool forceReloadEditorSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &forceReloadEditorSettings;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_IsDedicatedServer_Public_Static_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714155, XrefRangeEnd = 714163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDedicatedClient(bool forceReloadEditorSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &forceReloadEditorSettings;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_IsDedicatedClient_Public_Static_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714163, XrefRangeEnd = 714167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ApplicationType GetApplicationType(bool forceReloadEditorSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &forceReloadEditorSettings;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetApplicationType_Public_Static_ApplicationType_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(ApplicationType*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714167, XrefRangeEnd = 714168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ApplicationType ApplicationConversionTargetToApplicationType(
    ApplicationConversionTarget applicationConversionTarget)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &applicationConversionTarget;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_ApplicationConversionTargetToApplicationType_Public_Static_ApplicationType_ApplicationConversionTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(ApplicationType*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 714177, RefRangeEnd = 714181, XrefRangeStart = 714168, XrefRangeEnd = 714177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetDate_Private_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714181, XrefRangeEnd = 714189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetMeta()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameVersionUtils.NativeMethodInfoPtr_GetMeta_Private_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static GameVersionUtils()
  {
    Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (GameVersionUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr);
    GameVersionUtils.NativeFieldInfoPtr__GameVersionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (_GameVersionData));
    GameVersionUtils.NativeFieldInfoPtr__PersistenceVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (_PersistenceVersion));
    GameVersionUtils.NativeFieldInfoPtr__ApplicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (_ApplicationType));
    GameVersionUtils.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (Name));
    GameVersionUtils.NativeFieldInfoPtr_Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (Major));
    GameVersionUtils.NativeFieldInfoPtr_Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (Minor));
    GameVersionUtils.NativeFieldInfoPtr_Patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (Patch));
    GameVersionUtils.NativeFieldInfoPtr_Revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (Revision));
    GameVersionUtils.NativeFieldInfoPtr_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (Date));
    GameVersionUtils.NativeFieldInfoPtr_Meta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (Meta));
    GameVersionUtils.NativeFieldInfoPtr_ModString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (ModString));
    GameVersionUtils.NativeFieldInfoPtr_VersionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, nameof (VersionString));
    GameVersionUtils.NativeMethodInfoPtr_GetOrLoadPersistenceVersion_Public_Static_PersistenceVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663306);
    GameVersionUtils.NativeMethodInfoPtr_GetVersionData_Public_Static_GameVersionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663307);
    GameVersionUtils.NativeMethodInfoPtr_TryInitializePersistenceVersion_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663308);
    GameVersionUtils.NativeMethodInfoPtr_GetGameVersion_Public_Static_GameVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663309);
    GameVersionUtils.NativeMethodInfoPtr_GetNetworkVersion_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663310);
    GameVersionUtils.NativeMethodInfoPtr_GetDateStringUTC_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663311);
    GameVersionUtils.NativeMethodInfoPtr_GetDateStringUTCShort_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663312);
    GameVersionUtils.NativeMethodInfoPtr_GetBuildMode_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663313);
    GameVersionUtils.NativeMethodInfoPtr_get_IsEditor_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663314);
    GameVersionUtils.NativeMethodInfoPtr_GenerateData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663315);
    GameVersionUtils.NativeMethodInfoPtr_IsDedicatedServer_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663316);
    GameVersionUtils.NativeMethodInfoPtr_IsDedicatedClient_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663317);
    GameVersionUtils.NativeMethodInfoPtr_GetApplicationType_Public_Static_ApplicationType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663318);
    GameVersionUtils.NativeMethodInfoPtr_ApplicationConversionTargetToApplicationType_Public_Static_ApplicationType_ApplicationConversionTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663319);
    GameVersionUtils.NativeMethodInfoPtr_GetDate_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663320);
    GameVersionUtils.NativeMethodInfoPtr_GetMeta_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionUtils>.NativeClassPtr, 100663321);
  }

  public GameVersionUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe GameVersionData _GameVersionData
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr__GameVersionData, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameVersionData) null : new GameVersionData(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr__GameVersionData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Nullable_Unboxed<int> _PersistenceVersion
  {
    get
    {
      Nullable_Unboxed<int> persistenceVersion;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr__PersistenceVersion, (void*) &persistenceVersion);
      return persistenceVersion;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr__PersistenceVersion, (void*) &value);
    }
  }

  public static unsafe ApplicationType _ApplicationType
  {
    get
    {
      ApplicationType applicationType;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr__ApplicationType, (void*) &applicationType);
      return applicationType;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr__ApplicationType, (void*) &value);
    }
  }

  public static unsafe string Name
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_Name, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_Name, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int Major
  {
    get
    {
      int major;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_Major, (void*) &major);
      return major;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_Major, (void*) &value);
    }
  }

  public static unsafe int Minor
  {
    get
    {
      int minor;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_Minor, (void*) &minor);
      return minor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_Minor, (void*) &value);
    }
  }

  public static unsafe int Patch
  {
    get
    {
      int patch;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_Patch, (void*) &patch);
      return patch;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_Patch, (void*) &value);
    }
  }

  public static unsafe int Revision
  {
    get
    {
      int revision;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_Revision, (void*) &revision);
      return revision;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_Revision, (void*) &value);
    }
  }

  public static unsafe string Date
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_Date, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_Date, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string Meta
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_Meta, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_Meta, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string ModString
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_ModString, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_ModString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string VersionString
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(GameVersionUtils.NativeFieldInfoPtr_VersionString, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameVersionUtils.NativeFieldInfoPtr_VersionString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
