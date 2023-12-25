// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenuWallpaperOperation
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
  public struct BuildMenuWallpaperOperation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentWallpaperBlueprint;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPreviewedEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverriddenOrientation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Issues;
    private static readonly System.IntPtr NativeFieldInfoPtr_VariationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    [FieldOffset(0)]
    public PrefabGUID ParentWallpaperBlueprint;
    [FieldOffset(4)]
    public Entity CurrentPreviewedEntity;
    [FieldOffset(12)]
    public WallpaperOrientation OverriddenOrientation;
    [FieldOffset(16)]
    public BuildMenuWallpaperOperationIssues Issues;
    [FieldOffset(20)]
    public byte VariationIndex;
    [FieldOffset(21)]
    public bool Active;

    static BuildMenuWallpaperOperation()
    {
      Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenuWallpaperOperation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr);
      BuildMenuWallpaperOperation.NativeFieldInfoPtr_ParentWallpaperBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr, nameof (ParentWallpaperBlueprint));
      BuildMenuWallpaperOperation.NativeFieldInfoPtr_CurrentPreviewedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr, nameof (CurrentPreviewedEntity));
      BuildMenuWallpaperOperation.NativeFieldInfoPtr_OverriddenOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr, nameof (OverriddenOrientation));
      BuildMenuWallpaperOperation.NativeFieldInfoPtr_Issues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr, nameof (Issues));
      BuildMenuWallpaperOperation.NativeFieldInfoPtr_VariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr, nameof (VariationIndex));
      BuildMenuWallpaperOperation.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr, nameof (Active));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuWallpaperOperation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
