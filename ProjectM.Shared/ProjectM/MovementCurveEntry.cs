// Decompiled with JetBrains decompiler
// Type: ProjectM.MovementCurveEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MovementCurveEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SourceEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveX;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveY;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinearChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDeterministic;
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    [FieldOffset(0)]
    public Entity SourceEntity;
    [FieldOffset(8)]
    public Entity Entity;
    [FieldOffset(16)]
    public double StartTime;
    [FieldOffset(24)]
    public float Duration;
    [FieldOffset(28)]
    public float3 Position;
    [FieldOffset(40)]
    public float3 Scale;
    [FieldOffset(52)]
    public quaternion Rotation;
    [FieldOffset(68)]
    public CurveReference CurveX;
    [FieldOffset(76)]
    public CurveReference CurveY;
    [FieldOffset(84)]
    public CurveReference CurveZ;
    [FieldOffset(92)]
    public float3 LinearChange;
    [FieldOffset(104)]
    public MovementCurveRotationMode RotationMode;
    [FieldOffset(108)]
    public bool IsDeterministic;
    [FieldOffset(112)]
    public int Id;

    static MovementCurveEntry()
    {
      Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MovementCurveEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr);
      MovementCurveEntry.NativeFieldInfoPtr_SourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (SourceEntity));
      MovementCurveEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (Entity));
      MovementCurveEntry.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (StartTime));
      MovementCurveEntry.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (Duration));
      MovementCurveEntry.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (Position));
      MovementCurveEntry.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (Scale));
      MovementCurveEntry.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (Rotation));
      MovementCurveEntry.NativeFieldInfoPtr_CurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (CurveX));
      MovementCurveEntry.NativeFieldInfoPtr_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (CurveY));
      MovementCurveEntry.NativeFieldInfoPtr_CurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (CurveZ));
      MovementCurveEntry.NativeFieldInfoPtr_LinearChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (LinearChange));
      MovementCurveEntry.NativeFieldInfoPtr_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (RotationMode));
      MovementCurveEntry.NativeFieldInfoPtr_IsDeterministic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (IsDeterministic));
      MovementCurveEntry.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, nameof (Id));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MovementCurveEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
