// Decompiled with JetBrains decompiler
// Type: ProjectM.CanFly
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
  public struct CanFly
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FlyingHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightAboveObstacle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProximitySpeedModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastValidPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTargetHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerticalSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerticalAcceleration;
    [FieldOffset(0)]
    public ModifiableFloat FlyingHeight;
    [FieldOffset(8)]
    public ModifiableFloat HeightAboveObstacle;
    [FieldOffset(16)]
    public CurveReference ProximitySpeedModifier;
    [FieldOffset(24)]
    public float3 LastValidPosition;
    [FieldOffset(36)]
    public float LastTargetHeight;
    [FieldOffset(40)]
    public float VerticalSpeed;
    [FieldOffset(44)]
    public float VerticalAcceleration;

    static CanFly()
    {
      Il2CppClassPointerStore<CanFly>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CanFly));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanFly>.NativeClassPtr);
      CanFly.NativeFieldInfoPtr_FlyingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFly>.NativeClassPtr, nameof (FlyingHeight));
      CanFly.NativeFieldInfoPtr_HeightAboveObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFly>.NativeClassPtr, nameof (HeightAboveObstacle));
      CanFly.NativeFieldInfoPtr_ProximitySpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFly>.NativeClassPtr, nameof (ProximitySpeedModifier));
      CanFly.NativeFieldInfoPtr_LastValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFly>.NativeClassPtr, nameof (LastValidPosition));
      CanFly.NativeFieldInfoPtr_LastTargetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFly>.NativeClassPtr, nameof (LastTargetHeight));
      CanFly.NativeFieldInfoPtr_VerticalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFly>.NativeClassPtr, nameof (VerticalSpeed));
      CanFly.NativeFieldInfoPtr_VerticalAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFly>.NativeClassPtr, nameof (VerticalAcceleration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CanFly>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
