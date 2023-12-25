// Decompiled with JetBrains decompiler
// Type: ProjectM.WallpaperStyleData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WallpaperStyleData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentBlueprintGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_StyleBlueprintGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshVariationGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshVariationIndex;
    [FieldOffset(0)]
    public PrefabGUID ParentBlueprintGUID;
    [FieldOffset(4)]
    public PrefabGUID StyleBlueprintGUID;
    [FieldOffset(8)]
    public PrefabGUID MeshVariationGUID;
    [FieldOffset(12)]
    public byte MeshVariationIndex;

    static WallpaperStyleData()
    {
      Il2CppClassPointerStore<WallpaperStyleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WallpaperStyleData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperStyleData>.NativeClassPtr);
      WallpaperStyleData.NativeFieldInfoPtr_ParentBlueprintGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyleData>.NativeClassPtr, nameof (ParentBlueprintGUID));
      WallpaperStyleData.NativeFieldInfoPtr_StyleBlueprintGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyleData>.NativeClassPtr, nameof (StyleBlueprintGUID));
      WallpaperStyleData.NativeFieldInfoPtr_MeshVariationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyleData>.NativeClassPtr, nameof (MeshVariationGUID));
      WallpaperStyleData.NativeFieldInfoPtr_MeshVariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperStyleData>.NativeClassPtr, nameof (MeshVariationIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WallpaperStyleData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
