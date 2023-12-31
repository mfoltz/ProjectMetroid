// Decompiled with JetBrains decompiler
// Type: ProjectM.Dash
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
  public struct Dash
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileCollisionHitCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveId;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopOnMapCollision;
    [FieldOffset(0)]
    public quaternion StartRotation;
    [FieldOffset(16)]
    public float3 StartPosition;
    [FieldOffset(28)]
    public float Range;
    [FieldOffset(32)]
    public float Speed;
    [FieldOffset(36)]
    public CurveReference Curve;
    [FieldOffset(44)]
    public MovementCurveRotationMode RotationMode;
    [FieldOffset(48)]
    public int TileCollisionHitCount;
    [FieldOffset(52)]
    public int CurveId;
    [FieldOffset(56)]
    public bool StopOnMapCollision;

    static Dash()
    {
      Il2CppClassPointerStore<Dash>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Dash));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dash>.NativeClassPtr);
      Dash.NativeFieldInfoPtr_StartRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (StartRotation));
      Dash.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (StartPosition));
      Dash.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (Range));
      Dash.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (Speed));
      Dash.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (Curve));
      Dash.NativeFieldInfoPtr_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (RotationMode));
      Dash.NativeFieldInfoPtr_TileCollisionHitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (TileCollisionHitCount));
      Dash.NativeFieldInfoPtr_CurveId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (CurveId));
      Dash.NativeFieldInfoPtr_StopOnMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dash>.NativeClassPtr, nameof (StopOnMapCollision));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dash>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
