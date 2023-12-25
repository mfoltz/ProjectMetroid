// Decompiled with JetBrains decompiler
// Type: ProjectM.WalkBackAndForth
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WalkBackAndForth
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Left;
    [FieldOffset(0)]
    public float Distance;
    [FieldOffset(4)]
    public Nullable_Unboxed<float2> StartPosition;
    [FieldOffset(16)]
    public bool Left;

    static WalkBackAndForth()
    {
      Il2CppClassPointerStore<WalkBackAndForth>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WalkBackAndForth));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WalkBackAndForth>.NativeClassPtr);
      WalkBackAndForth.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkBackAndForth>.NativeClassPtr, nameof (Distance));
      WalkBackAndForth.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkBackAndForth>.NativeClassPtr, nameof (StartPosition));
      WalkBackAndForth.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkBackAndForth>.NativeClassPtr, nameof (Left));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WalkBackAndForth>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
