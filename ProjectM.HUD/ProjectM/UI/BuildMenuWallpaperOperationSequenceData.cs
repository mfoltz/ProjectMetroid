// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenuWallpaperOperationSequenceData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BuildMenuWallpaperOperationSequenceData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Orientation;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsValid;
    [FieldOffset(0)]
    public Entity TargetEntity;
    [FieldOffset(8)]
    public WallpaperOrientation Orientation;
    [FieldOffset(9)]
    public bool IsValid;

    static BuildMenuWallpaperOperationSequenceData()
    {
      Il2CppClassPointerStore<BuildMenuWallpaperOperationSequenceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenuWallpaperOperationSequenceData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuWallpaperOperationSequenceData>.NativeClassPtr);
      BuildMenuWallpaperOperationSequenceData.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperationSequenceData>.NativeClassPtr, nameof (TargetEntity));
      BuildMenuWallpaperOperationSequenceData.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperationSequenceData>.NativeClassPtr, nameof (Orientation));
      BuildMenuWallpaperOperationSequenceData.NativeFieldInfoPtr_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperationSequenceData>.NativeClassPtr, nameof (IsValid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuWallpaperOperationSequenceData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
