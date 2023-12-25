// Decompiled with JetBrains decompiler
// Type: ProjectM.WallpaperInstanceBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WallpaperInstanceBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BelongsToWallpaperIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Orientation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public int BelongsToWallpaperIndex;
    [FieldOffset(4)]
    public WallpaperOrientation Orientation;
    [FieldOffset(8)]
    public Entity Entity;

    static WallpaperInstanceBuffer()
    {
      Il2CppClassPointerStore<WallpaperInstanceBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WallpaperInstanceBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperInstanceBuffer>.NativeClassPtr);
      WallpaperInstanceBuffer.NativeFieldInfoPtr_BelongsToWallpaperIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperInstanceBuffer>.NativeClassPtr, nameof (BelongsToWallpaperIndex));
      WallpaperInstanceBuffer.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperInstanceBuffer>.NativeClassPtr, nameof (Orientation));
      WallpaperInstanceBuffer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperInstanceBuffer>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WallpaperInstanceBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
