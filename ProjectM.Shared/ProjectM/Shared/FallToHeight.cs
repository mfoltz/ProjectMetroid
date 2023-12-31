// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.FallToHeight
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FallToHeight
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Gravity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FallSnapDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsGrounded;
    [FieldOffset(0)]
    public float Speed;
    [FieldOffset(4)]
    public ModifiableFloat Gravity;
    [FieldOffset(12)]
    public half FallSnapDistance;
    [FieldOffset(14)]
    public bool IsGrounded;

    static FallToHeight()
    {
      Il2CppClassPointerStore<FallToHeight>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (FallToHeight));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallToHeight>.NativeClassPtr);
      FallToHeight.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallToHeight>.NativeClassPtr, nameof (Speed));
      FallToHeight.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallToHeight>.NativeClassPtr, nameof (Gravity));
      FallToHeight.NativeFieldInfoPtr_FallSnapDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallToHeight>.NativeClassPtr, nameof (FallSnapDistance));
      FallToHeight.NativeFieldInfoPtr_IsGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallToHeight>.NativeClassPtr, nameof (IsGrounded));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FallToHeight>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
