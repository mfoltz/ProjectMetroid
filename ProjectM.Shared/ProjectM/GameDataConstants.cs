// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class GameDataConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataEditorFolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_Gameplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_Abilities;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_Castle;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_ChainPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_SpawnChains;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_Environment;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_EverythingElse;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_MiscPrefabInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_StreamedHybridModels;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFile_ConvertOnDemandPrefabCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataEditorFile_ChunkEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConversionSettingsAssetPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_LEVEL_DIFF_WHEN_UNKNOWN;
    private static readonly System.IntPtr NativeFieldInfoPtr_MIN_TRADER_RESTOCK_ADD_TIME;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFilesV1;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataFilesV2;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataEditorFiles;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFilePath_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEditorFilePath_Public_Static_String_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734951, XrefRangeEnd = 735062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetFilePath(string gameDataFile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(gameDataFile);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameDataConstants.NativeMethodInfoPtr_GetFilePath_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735062, XrefRangeEnd = 735068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetEditorFilePath(string gameDataFile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(gameDataFile);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameDataConstants.NativeMethodInfoPtr_GetEditorFilePath_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static GameDataConstants()
    {
      Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr);
      GameDataConstants.NativeFieldInfoPtr_GameDataFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFolder));
      GameDataConstants.NativeFieldInfoPtr_GameDataEditorFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataEditorFolder));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_Gameplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_Gameplay));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_Abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_Abilities));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_Castle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_Castle));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_ChainPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_ChainPrefabs));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_SpawnChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_SpawnChains));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_Environment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_Environment));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_EverythingElse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_EverythingElse));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_MiscPrefabInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_MiscPrefabInfo));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_StreamedHybridModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_StreamedHybridModels));
      GameDataConstants.NativeFieldInfoPtr_GameDataFile_ConvertOnDemandPrefabCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFile_ConvertOnDemandPrefabCollection));
      GameDataConstants.NativeFieldInfoPtr_GameDataEditorFile_ChunkEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataEditorFile_ChunkEditor));
      GameDataConstants.NativeFieldInfoPtr_ConversionSettingsAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (ConversionSettingsAssetPath));
      GameDataConstants.NativeFieldInfoPtr_LEVEL_DIFF_WHEN_UNKNOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (LEVEL_DIFF_WHEN_UNKNOWN));
      GameDataConstants.NativeFieldInfoPtr_MIN_TRADER_RESTOCK_ADD_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (MIN_TRADER_RESTOCK_ADD_TIME));
      GameDataConstants.NativeFieldInfoPtr_GameDataFilesV1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFilesV1));
      GameDataConstants.NativeFieldInfoPtr_GameDataFilesV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataFilesV2));
      GameDataConstants.NativeFieldInfoPtr_GameDataEditorFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, nameof (GameDataEditorFiles));
      GameDataConstants.NativeMethodInfoPtr_GetFilePath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, 100664907);
      GameDataConstants.NativeMethodInfoPtr_GetEditorFilePath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataConstants>.NativeClassPtr, 100664908);
    }

    public GameDataConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string GameDataFolder
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFolder, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataEditorFolder
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataEditorFolder, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataEditorFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_Gameplay
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Gameplay, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Gameplay, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_Abilities
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Abilities, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Abilities, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_Castle
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Castle, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Castle, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_ChainPrefabs
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_ChainPrefabs, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_ChainPrefabs, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_SpawnChains
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_SpawnChains, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_SpawnChains, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_Environment
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Environment, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_Environment, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_EverythingElse
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_EverythingElse, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_EverythingElse, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_MiscPrefabInfo
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_MiscPrefabInfo, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_MiscPrefabInfo, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_StreamedHybridModels
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_StreamedHybridModels, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_StreamedHybridModels, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataFile_ConvertOnDemandPrefabCollection
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_ConvertOnDemandPrefabCollection, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFile_ConvertOnDemandPrefabCollection, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameDataEditorFile_ChunkEditor
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataEditorFile_ChunkEditor, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataEditorFile_ChunkEditor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ConversionSettingsAssetPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_ConversionSettingsAssetPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_ConversionSettingsAssetPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe float LEVEL_DIFF_WHEN_UNKNOWN
    {
      get
      {
        float levelDiffWhenUnknown;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_LEVEL_DIFF_WHEN_UNKNOWN, (void*) &levelDiffWhenUnknown);
        return levelDiffWhenUnknown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_LEVEL_DIFF_WHEN_UNKNOWN, (void*) &value);
      }
    }

    public static unsafe float MIN_TRADER_RESTOCK_ADD_TIME
    {
      get
      {
        float traderRestockAddTime;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_MIN_TRADER_RESTOCK_ADD_TIME, (void*) &traderRestockAddTime);
        return traderRestockAddTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_MIN_TRADER_RESTOCK_ADD_TIME, (void*) &value);
      }
    }

    public static unsafe Il2CppStringArray GameDataFilesV1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFilesV1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFilesV1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppStringArray GameDataFilesV2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataFilesV2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataFilesV2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppStringArray GameDataEditorFiles
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GameDataConstants.NativeFieldInfoPtr_GameDataEditorFiles, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataConstants.NativeFieldInfoPtr_GameDataEditorFiles, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
