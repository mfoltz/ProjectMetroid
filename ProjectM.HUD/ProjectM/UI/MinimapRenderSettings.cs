// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MinimapRenderSettings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MinimapRenderSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Zoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_RectangleSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideTextureSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverriddenTextureSizeX;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverriddenTextureSizeY;
    [FieldOffset(0)]
    public float Zoom;
    [FieldOffset(4)]
    public float RectangleSize;
    [FieldOffset(8)]
    public float MapSize;
    [FieldOffset(12)]
    public bool OverrideTextureSize;
    [FieldOffset(16)]
    public int OverriddenTextureSizeX;
    [FieldOffset(20)]
    public int OverriddenTextureSizeY;

    static MinimapRenderSettings()
    {
      Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MinimapRenderSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr);
      MinimapRenderSettings.NativeFieldInfoPtr_Zoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr, nameof (Zoom));
      MinimapRenderSettings.NativeFieldInfoPtr_RectangleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr, nameof (RectangleSize));
      MinimapRenderSettings.NativeFieldInfoPtr_MapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr, nameof (MapSize));
      MinimapRenderSettings.NativeFieldInfoPtr_OverrideTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr, nameof (OverrideTextureSize));
      MinimapRenderSettings.NativeFieldInfoPtr_OverriddenTextureSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr, nameof (OverriddenTextureSizeX));
      MinimapRenderSettings.NativeFieldInfoPtr_OverriddenTextureSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr, nameof (OverriddenTextureSizeY));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinimapRenderSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
