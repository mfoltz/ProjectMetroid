// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Triangle
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Triangle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_A;
    private static readonly System.IntPtr NativeFieldInfoPtr_B;
    private static readonly System.IntPtr NativeFieldInfoPtr_C;
    [FieldOffset(0)]
    public float3 A;
    [FieldOffset(12)]
    public float3 B;
    [FieldOffset(24)]
    public float3 C;

    static Triangle()
    {
      Il2CppClassPointerStore<Triangle>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (Triangle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Triangle>.NativeClassPtr);
      Triangle.NativeFieldInfoPtr_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Triangle>.NativeClassPtr, nameof (A));
      Triangle.NativeFieldInfoPtr_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Triangle>.NativeClassPtr, nameof (B));
      Triangle.NativeFieldInfoPtr_C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Triangle>.NativeClassPtr, nameof (C));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Triangle>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
