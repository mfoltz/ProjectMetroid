// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.SnappingPointClosestTo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SnappingPointClosestTo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SnappingPointIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    [FieldOffset(0)]
    public int SnappingPointIndex;
    [FieldOffset(4)]
    public float Radius;

    static SnappingPointClosestTo()
    {
      Il2CppClassPointerStore<SnappingPointClosestTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (SnappingPointClosestTo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnappingPointClosestTo>.NativeClassPtr);
      SnappingPointClosestTo.NativeFieldInfoPtr_SnappingPointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointClosestTo>.NativeClassPtr, nameof (SnappingPointIndex));
      SnappingPointClosestTo.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointClosestTo>.NativeClassPtr, nameof (Radius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SnappingPointClosestTo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
