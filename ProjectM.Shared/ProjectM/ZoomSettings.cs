// Decompiled with JetBrains decompiler
// Type: ProjectM.ZoomSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ZoomSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinZoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPitch;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPitch;
    [FieldOffset(0)]
    public float MinZoom;
    [FieldOffset(4)]
    public float MaxZoom;
    [FieldOffset(8)]
    public float MaxPitch;
    [FieldOffset(12)]
    public float MinPitch;

    static ZoomSettings()
    {
      Il2CppClassPointerStore<ZoomSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ZoomSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZoomSettings>.NativeClassPtr);
      ZoomSettings.NativeFieldInfoPtr_MinZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomSettings>.NativeClassPtr, nameof (MinZoom));
      ZoomSettings.NativeFieldInfoPtr_MaxZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomSettings>.NativeClassPtr, nameof (MaxZoom));
      ZoomSettings.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomSettings>.NativeClassPtr, nameof (MaxPitch));
      ZoomSettings.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomSettings>.NativeClassPtr, nameof (MinPitch));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ZoomSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
