// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUDConstants
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public static class CharacterHUDConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelTierLess;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelTierAbove1;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelTierAbove2;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelTierMax;

    static CharacterHUDConstants()
    {
      Il2CppClassPointerStore<CharacterHUDConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUDConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUDConstants>.NativeClassPtr);
      CharacterHUDConstants.NativeFieldInfoPtr_LevelTierLess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDConstants>.NativeClassPtr, nameof (LevelTierLess));
      CharacterHUDConstants.NativeFieldInfoPtr_LevelTierAbove1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDConstants>.NativeClassPtr, nameof (LevelTierAbove1));
      CharacterHUDConstants.NativeFieldInfoPtr_LevelTierAbove2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDConstants>.NativeClassPtr, nameof (LevelTierAbove2));
      CharacterHUDConstants.NativeFieldInfoPtr_LevelTierMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUDConstants>.NativeClassPtr, nameof (LevelTierMax));
    }

    public CharacterHUDConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int LevelTierLess
    {
      get
      {
        int levelTierLess;
        IL2CPP.il2cpp_field_static_get_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierLess, (void*) &levelTierLess);
        return levelTierLess;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierLess, (void*) &value);
      }
    }

    public static unsafe int LevelTierAbove1
    {
      get
      {
        int levelTierAbove1;
        IL2CPP.il2cpp_field_static_get_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierAbove1, (void*) &levelTierAbove1);
        return levelTierAbove1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierAbove1, (void*) &value);
      }
    }

    public static unsafe int LevelTierAbove2
    {
      get
      {
        int levelTierAbove2;
        IL2CPP.il2cpp_field_static_get_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierAbove2, (void*) &levelTierAbove2);
        return levelTierAbove2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierAbove2, (void*) &value);
      }
    }

    public static unsafe int LevelTierMax
    {
      get
      {
        int levelTierMax;
        IL2CPP.il2cpp_field_static_get_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierMax, (void*) &levelTierMax);
        return levelTierMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterHUDConstants.NativeFieldInfoPtr_LevelTierMax, (void*) &value);
      }
    }
  }
}
