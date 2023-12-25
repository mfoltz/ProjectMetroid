// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.SnappingPoint
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SnappingPoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LimitToPrefabSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlySnapToMatchingRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlySnapToMatchingRotationOrMirrored;
    [FieldOffset(0)]
    public Translation LocalTranslation;
    [FieldOffset(12)]
    public float LocalRotation;
    [FieldOffset(16)]
    public bool SnapRotation;
    [FieldOffset(20)]
    public PrefabGUID LimitToPrefabSet;
    [FieldOffset(24)]
    public bool OnlySnapToMatchingRotation;
    [FieldOffset(25)]
    public bool OnlySnapToMatchingRotationOrMirrored;

    static SnappingPoint()
    {
      Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (SnappingPoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr);
      SnappingPoint.NativeFieldInfoPtr_LocalTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr, nameof (LocalTranslation));
      SnappingPoint.NativeFieldInfoPtr_LocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr, nameof (LocalRotation));
      SnappingPoint.NativeFieldInfoPtr_SnapRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr, nameof (SnapRotation));
      SnappingPoint.NativeFieldInfoPtr_LimitToPrefabSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr, nameof (LimitToPrefabSet));
      SnappingPoint.NativeFieldInfoPtr_OnlySnapToMatchingRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr, nameof (OnlySnapToMatchingRotation));
      SnappingPoint.NativeFieldInfoPtr_OnlySnapToMatchingRotationOrMirrored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr, nameof (OnlySnapToMatchingRotationOrMirrored));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SnappingPoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
