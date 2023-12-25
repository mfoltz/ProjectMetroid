// Decompiled with JetBrains decompiler
// Type: ProjectM.WallpaperStyleBlob
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
  public struct WallpaperStyleBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Styles;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshVariationsByIndex;
    [FieldOffset(0)]
    public BlobArray<WallpaperStyleData> Styles;
    [FieldOffset(8)]
    public BlobArray<PrefabGUID> MeshVariationsByIndex;

    static WallpaperStyleBlob()
    {
      Il2CppClassPointerStore<WallpaperStyleBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WallpaperStyleBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperStyleBlob>.NativeClassPtr);
      WallpaperStyleBlob.NativeFieldInfoPtr_Styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyleBlob>.NativeClassPtr, nameof (Styles));
      WallpaperStyleBlob.NativeFieldInfoPtr_MeshVariationsByIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyleBlob>.NativeClassPtr, nameof (MeshVariationsByIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WallpaperStyleBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
