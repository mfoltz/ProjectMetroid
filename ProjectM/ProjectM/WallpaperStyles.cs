// Decompiled with JetBrains decompiler
// Type: ProjectM.WallpaperStyles
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
  public struct WallpaperStyles
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SplitsPerStyle;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blob;
    [FieldOffset(0)]
    public ObjectSplits SplitsPerStyle;
    [FieldOffset(8)]
    public BlobAssetReference<WallpaperStyleBlob> Blob;

    static WallpaperStyles()
    {
      Il2CppClassPointerStore<WallpaperStyles>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WallpaperStyles));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperStyles>.NativeClassPtr);
      WallpaperStyles.NativeFieldInfoPtr_InvalidStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyles>.NativeClassPtr, nameof (InvalidStyleIndex));
      WallpaperStyles.NativeFieldInfoPtr_SplitsPerStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyles>.NativeClassPtr, nameof (SplitsPerStyle));
      WallpaperStyles.NativeFieldInfoPtr_Blob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyles>.NativeClassPtr, nameof (Blob));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WallpaperStyles>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int InvalidStyleIndex
    {
      get
      {
        int invalidStyleIndex;
        IL2CPP.il2cpp_field_static_get_value(WallpaperStyles.NativeFieldInfoPtr_InvalidStyleIndex, (void*) &invalidStyleIndex);
        return invalidStyleIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WallpaperStyles.NativeFieldInfoPtr_InvalidStyleIndex, (void*) &value);
      }
    }
  }
}
