// Decompiled with JetBrains decompiler
// Type: ProjectM.TileShaderSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileShaderSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Default;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_GridThickness;
    private static readonly System.IntPtr NativeFieldInfoPtr_PopMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_GridSpacing;
    private static readonly System.IntPtr NativeFieldInfoPtr_GridColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_GridOpacityMultiplier;
    [FieldOffset(0)]
    public float Alpha;
    [FieldOffset(4)]
    public float GridThickness;
    [FieldOffset(8)]
    public float3 PopMultiplier;
    [FieldOffset(20)]
    public float GridSpacing;
    [FieldOffset(24)]
    public Color GridColor;
    [FieldOffset(40)]
    public float GridOpacityMultiplier;

    static TileShaderSettings()
    {
      Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileShaderSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr);
      TileShaderSettings.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, nameof (Default));
      TileShaderSettings.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, nameof (Alpha));
      TileShaderSettings.NativeFieldInfoPtr_GridThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, nameof (GridThickness));
      TileShaderSettings.NativeFieldInfoPtr_PopMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, nameof (PopMultiplier));
      TileShaderSettings.NativeFieldInfoPtr_GridSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, nameof (GridSpacing));
      TileShaderSettings.NativeFieldInfoPtr_GridColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, nameof (GridColor));
      TileShaderSettings.NativeFieldInfoPtr_GridOpacityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, nameof (GridOpacityMultiplier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileShaderSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe TileShaderSettings Default
    {
      get
      {
        TileShaderSettings tileShaderSettings;
        IL2CPP.il2cpp_field_static_get_value(TileShaderSettings.NativeFieldInfoPtr_Default, (void*) &tileShaderSettings);
        return tileShaderSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileShaderSettings.NativeFieldInfoPtr_Default, (void*) &value);
      }
    }
  }
}
