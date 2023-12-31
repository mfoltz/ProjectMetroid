// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SettingsConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public static class SettingsConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameSettingsDefaultFolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameSettingsLocalFolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnversionedGameSettingsLocalFolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorSettingsDefaultFolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorSettingsLocalFolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsVersion;

    static SettingsConstants()
    {
      Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SettingsConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr);
      SettingsConstants.NativeFieldInfoPtr_GameSettingsDefaultFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr, nameof (GameSettingsDefaultFolder));
      SettingsConstants.NativeFieldInfoPtr_GameSettingsLocalFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr, nameof (GameSettingsLocalFolder));
      SettingsConstants.NativeFieldInfoPtr_UnversionedGameSettingsLocalFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr, nameof (UnversionedGameSettingsLocalFolder));
      SettingsConstants.NativeFieldInfoPtr_EditorSettingsDefaultFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr, nameof (EditorSettingsDefaultFolder));
      SettingsConstants.NativeFieldInfoPtr_EditorSettingsLocalFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr, nameof (EditorSettingsLocalFolder));
      SettingsConstants.NativeFieldInfoPtr_SettingsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsConstants>.NativeClassPtr, nameof (SettingsVersion));
    }

    public SettingsConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string GameSettingsDefaultFolder
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SettingsConstants.NativeFieldInfoPtr_GameSettingsDefaultFolder, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsConstants.NativeFieldInfoPtr_GameSettingsDefaultFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameSettingsLocalFolder
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SettingsConstants.NativeFieldInfoPtr_GameSettingsLocalFolder, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsConstants.NativeFieldInfoPtr_GameSettingsLocalFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UnversionedGameSettingsLocalFolder
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SettingsConstants.NativeFieldInfoPtr_UnversionedGameSettingsLocalFolder, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsConstants.NativeFieldInfoPtr_UnversionedGameSettingsLocalFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string EditorSettingsDefaultFolder
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SettingsConstants.NativeFieldInfoPtr_EditorSettingsDefaultFolder, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsConstants.NativeFieldInfoPtr_EditorSettingsDefaultFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string EditorSettingsLocalFolder
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SettingsConstants.NativeFieldInfoPtr_EditorSettingsLocalFolder, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsConstants.NativeFieldInfoPtr_EditorSettingsLocalFolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int SettingsVersion
    {
      get
      {
        int settingsVersion;
        IL2CPP.il2cpp_field_static_get_value(SettingsConstants.NativeFieldInfoPtr_SettingsVersion, (void*) &settingsVersion);
        return settingsVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SettingsConstants.NativeFieldInfoPtr_SettingsVersion, (void*) &value);
      }
    }
  }
}
