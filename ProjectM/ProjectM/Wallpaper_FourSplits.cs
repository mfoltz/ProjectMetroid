// Decompiled with JetBrains decompiler
// Type: ProjectM.Wallpaper_FourSplits
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Wallpaper_FourSplits
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data_90;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data_180;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data_270;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveStyleOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveVariationOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideOrientation;
    [FieldOffset(0)]
    public WallpaperOrientationData Data_0;
    [FieldOffset(4)]
    public WallpaperOrientationData Data_90;
    [FieldOffset(8)]
    public WallpaperOrientationData Data_180;
    [FieldOffset(12)]
    public WallpaperOrientationData Data_270;
    [FieldOffset(16)]
    public byte ActiveStyleOverride;
    [FieldOffset(17)]
    public byte ActiveVariationOverride;
    [FieldOffset(18)]
    public WallpaperOrientation OverrideOrientation;

    static Wallpaper_FourSplits()
    {
      Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Wallpaper_FourSplits));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr);
      Wallpaper_FourSplits.NativeFieldInfoPtr_Data_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, nameof (Data_0));
      Wallpaper_FourSplits.NativeFieldInfoPtr_Data_90 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, nameof (Data_90));
      Wallpaper_FourSplits.NativeFieldInfoPtr_Data_180 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, nameof (Data_180));
      Wallpaper_FourSplits.NativeFieldInfoPtr_Data_270 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, nameof (Data_270));
      Wallpaper_FourSplits.NativeFieldInfoPtr_ActiveStyleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, nameof (ActiveStyleOverride));
      Wallpaper_FourSplits.NativeFieldInfoPtr_ActiveVariationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, nameof (ActiveVariationOverride));
      Wallpaper_FourSplits.NativeFieldInfoPtr_OverrideOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, nameof (OverrideOrientation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Wallpaper_FourSplits>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
