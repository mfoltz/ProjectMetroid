// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelAnimData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridModelAnimData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SoftChestAimAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoftHeadAimAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmoothTurnAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalSnapshot;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendTime;
    [FieldOffset(0)]
    public float SoftChestAimAngle;
    [FieldOffset(4)]
    public float SoftHeadAimAngle;
    [FieldOffset(8)]
    public float SmoothTurnAngle;
    [FieldOffset(12)]
    public float StopAngle;
    [FieldOffset(16)]
    public float3 LastDirection;
    [FieldOffset(28)]
    public float3 DirectionalSnapshot;
    [FieldOffset(40)]
    public float BlendTime;

    static HybridModelAnimData()
    {
      Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelAnimData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr);
      HybridModelAnimData.NativeFieldInfoPtr_SoftChestAimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, nameof (SoftChestAimAngle));
      HybridModelAnimData.NativeFieldInfoPtr_SoftHeadAimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, nameof (SoftHeadAimAngle));
      HybridModelAnimData.NativeFieldInfoPtr_SmoothTurnAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, nameof (SmoothTurnAngle));
      HybridModelAnimData.NativeFieldInfoPtr_StopAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, nameof (StopAngle));
      HybridModelAnimData.NativeFieldInfoPtr_LastDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, nameof (LastDirection));
      HybridModelAnimData.NativeFieldInfoPtr_DirectionalSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, nameof (DirectionalSnapshot));
      HybridModelAnimData.NativeFieldInfoPtr_BlendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, nameof (BlendTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelAnimData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
