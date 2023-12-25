// Decompiled with JetBrains decompiler
// Type: ProjectM.JumpFromCliffsTravelBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JumpFromCliffsTravelBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPositionServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPositionClient;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSearchAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_LengthPerHeightCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_LengthPerSpeedCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimePerHeightCurve;
    [FieldOffset(0)]
    public float3 StartPositionServer;
    [FieldOffset(12)]
    public float3 StartPositionClient;
    [FieldOffset(24)]
    public float3 EndPosition;
    [FieldOffset(36)]
    public float Height;
    [FieldOffset(40)]
    public float MaxSearchAngle;
    [FieldOffset(44)]
    public CurveData LengthPerHeightCurve;
    [FieldOffset(1064)]
    public CurveData LengthPerSpeedCurve;
    [FieldOffset(2084)]
    public CurveData TimePerHeightCurve;

    static JumpFromCliffsTravelBuff()
    {
      Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JumpFromCliffsTravelBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr);
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_StartPositionServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (StartPositionServer));
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_StartPositionClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (StartPositionClient));
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (EndPosition));
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (Height));
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_MaxSearchAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (MaxSearchAngle));
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_LengthPerHeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (LengthPerHeightCurve));
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_LengthPerSpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (LengthPerSpeedCurve));
      JumpFromCliffsTravelBuff.NativeFieldInfoPtr_TimePerHeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, nameof (TimePerHeightCurve));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JumpFromCliffsTravelBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
