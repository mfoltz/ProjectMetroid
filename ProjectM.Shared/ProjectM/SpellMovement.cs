// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellMovement
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
  public struct SpellMovement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveXLoops;
    private static readonly System.IntPtr NativeFieldInfoPtr_XScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_YScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveY;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveX;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetRotationEveryFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_Disabled;
    [FieldOffset(0)]
    public float3 StartPosition;
    [FieldOffset(12)]
    public float3 TargetPosition;
    [FieldOffset(24)]
    public float CurveXLoops;
    [FieldOffset(28)]
    public float XScale;
    [FieldOffset(32)]
    public float YScale;
    [FieldOffset(36)]
    public CurveReference CurveY;
    [FieldOffset(44)]
    public CurveReference CurveX;
    [FieldOffset(52)]
    public CurveReference CurveZ;
    [FieldOffset(60)]
    public bool SetRotationEveryFrame;
    [FieldOffset(61)]
    public bool Disabled;

    static SpellMovement()
    {
      Il2CppClassPointerStore<SpellMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellMovement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr);
      SpellMovement.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (StartPosition));
      SpellMovement.NativeFieldInfoPtr_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (TargetPosition));
      SpellMovement.NativeFieldInfoPtr_CurveXLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (CurveXLoops));
      SpellMovement.NativeFieldInfoPtr_XScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (XScale));
      SpellMovement.NativeFieldInfoPtr_YScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (YScale));
      SpellMovement.NativeFieldInfoPtr_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (CurveY));
      SpellMovement.NativeFieldInfoPtr_CurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (CurveX));
      SpellMovement.NativeFieldInfoPtr_CurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (CurveZ));
      SpellMovement.NativeFieldInfoPtr_SetRotationEveryFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (SetRotationEveryFrame));
      SpellMovement.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, nameof (Disabled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellMovement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
