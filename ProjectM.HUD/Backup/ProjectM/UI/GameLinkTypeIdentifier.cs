// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GameLinkTypeIdentifier
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public static class GameLinkTypeIdentifier : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_POPUP;

    static GameLinkTypeIdentifier()
    {
      Il2CppClassPointerStore<GameLinkTypeIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (GameLinkTypeIdentifier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLinkTypeIdentifier>.NativeClassPtr);
      GameLinkTypeIdentifier.NativeFieldInfoPtr_OPEN_POPUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLinkTypeIdentifier>.NativeClassPtr, nameof (OPEN_POPUP));
    }

    public GameLinkTypeIdentifier(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string OPEN_POPUP
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameLinkTypeIdentifier.NativeFieldInfoPtr_OPEN_POPUP, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameLinkTypeIdentifier.NativeFieldInfoPtr_OPEN_POPUP, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
