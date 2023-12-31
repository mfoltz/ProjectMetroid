// Decompiled with JetBrains decompiler
// Type: ProjectM.StaticTransformCompatible
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StaticTransformCompatible
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_NonStaticTransform_Rotation;
    [FieldOffset(0)]
    public bool UseStaticTransform;
    [FieldOffset(4)]
    public StaticTransformIndex StaticTransform;
    [FieldOffset(16)]
    public float2 NonStaticTransform_Pos;
    [FieldOffset(24)]
    public float NonStaticTransform_Height;
    [FieldOffset(28)]
    public TileRotation NonStaticTransform_Rotation;

    static StaticTransformCompatible()
    {
      Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StaticTransformCompatible));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr);
      StaticTransformCompatible.NativeFieldInfoPtr_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr, nameof (UseStaticTransform));
      StaticTransformCompatible.NativeFieldInfoPtr_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr, nameof (StaticTransform));
      StaticTransformCompatible.NativeFieldInfoPtr_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr, nameof (NonStaticTransform_Pos));
      StaticTransformCompatible.NativeFieldInfoPtr_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr, nameof (NonStaticTransform_Height));
      StaticTransformCompatible.NativeFieldInfoPtr_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr, nameof (NonStaticTransform_Rotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticTransformCompatible>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
