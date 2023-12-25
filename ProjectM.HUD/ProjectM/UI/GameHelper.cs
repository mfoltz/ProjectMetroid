// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GameHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.UI
{
  public static class GameHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_LaunchGame_Public_Static_Void_GameConnect_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LaunchPasswordProtectedGame_Public_Static_Void_PasswordGameConnect_0;

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 1265105, RefRangeEnd = 1265125, XrefRangeStart = 1265081, XrefRangeEnd = 1265105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LaunchGame(GameConnect launchData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &launchData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameHelper.NativeMethodInfoPtr_LaunchGame_Public_Static_Void_GameConnect_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265147, RefRangeEnd = 1265148, XrefRangeStart = 1265125, XrefRangeEnd = 1265147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void LaunchPasswordProtectedGame(PasswordGameConnect launchData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &launchData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameHelper.NativeMethodInfoPtr_LaunchPasswordProtectedGame_Public_Static_Void_PasswordGameConnect_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameHelper()
    {
      Il2CppClassPointerStore<GameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (GameHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameHelper>.NativeClassPtr);
      GameHelper.NativeMethodInfoPtr_LaunchGame_Public_Static_Void_GameConnect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameHelper>.NativeClassPtr, 100667542);
      GameHelper.NativeMethodInfoPtr_LaunchPasswordProtectedGame_Public_Static_Void_PasswordGameConnect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameHelper>.NativeClassPtr, 100667543);
    }

    public GameHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
