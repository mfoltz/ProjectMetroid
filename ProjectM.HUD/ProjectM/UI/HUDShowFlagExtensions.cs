// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDShowFlagExtensions
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public static class HUDShowFlagExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowHUD_Public_Static_Boolean_HUDShowFlag_byref_Data_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1217479, RefRangeEnd = 1217482, XrefRangeStart = 1217478, XrefRangeEnd = 1217479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldShowHUD(
      this HUDShowFlag showFlag,
      [In] ref CharacterHUDEntry.Data data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &showFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDShowFlagExtensions.NativeMethodInfoPtr_ShouldShowHUD_Public_Static_Boolean_HUDShowFlag_byref_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HUDShowFlagExtensions()
    {
      Il2CppClassPointerStore<HUDShowFlagExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDShowFlagExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDShowFlagExtensions>.NativeClassPtr);
      HUDShowFlagExtensions.NativeMethodInfoPtr_ShouldShowHUD_Public_Static_Boolean_HUDShowFlag_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDShowFlagExtensions>.NativeClassPtr, 100664306);
    }

    public HUDShowFlagExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
