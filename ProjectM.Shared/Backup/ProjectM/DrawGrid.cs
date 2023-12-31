// Decompiled with JetBrains decompiler
// Type: ProjectM.DrawGrid
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DrawGrid
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BoundsTileSpace;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasCustomSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseFadeOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableGrid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapToHeightLevel;
    [FieldOffset(0)]
    public BoundsMinMax BoundsTileSpace;
    [FieldOffset(16)]
    public float3 Position;
    [FieldOffset(28)]
    public float3 FadeOutPosition;
    [FieldOffset(40)]
    public float FadeOutRadius;
    [FieldOffset(44)]
    public TileShaderSettings CustomSettings;
    [FieldOffset(88)]
    public bool HasCustomSettings;
    [FieldOffset(89)]
    public bool UseFadeOut;
    [FieldOffset(90)]
    public bool DisableGrid;
    [FieldOffset(91)]
    public bool SnapToHeightLevel;

    static DrawGrid()
    {
      Il2CppClassPointerStore<DrawGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DrawGrid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr);
      DrawGrid.NativeFieldInfoPtr_BoundsTileSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (BoundsTileSpace));
      DrawGrid.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (Position));
      DrawGrid.NativeFieldInfoPtr_FadeOutPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (FadeOutPosition));
      DrawGrid.NativeFieldInfoPtr_FadeOutRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (FadeOutRadius));
      DrawGrid.NativeFieldInfoPtr_CustomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (CustomSettings));
      DrawGrid.NativeFieldInfoPtr_HasCustomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (HasCustomSettings));
      DrawGrid.NativeFieldInfoPtr_UseFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (UseFadeOut));
      DrawGrid.NativeFieldInfoPtr_DisableGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (DisableGrid));
      DrawGrid.NativeFieldInfoPtr_SnapToHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, nameof (SnapToHeightLevel));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawGrid>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
