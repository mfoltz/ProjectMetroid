// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CommandRotationInput
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CommandRotationInput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForcedDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanRotate;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimDependsOnRotation;
    [FieldOffset(0)]
    public float3 TargetDirection;
    [FieldOffset(12)]
    public float3 ForcedDirection;
    [FieldOffset(24)]
    public float RotationSpeed;
    [FieldOffset(28)]
    public bool CanRotate;
    [FieldOffset(29)]
    public bool AimDependsOnRotation;

    static CommandRotationInput()
    {
      Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (CommandRotationInput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr);
      CommandRotationInput.NativeFieldInfoPtr_TargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr, nameof (TargetDirection));
      CommandRotationInput.NativeFieldInfoPtr_ForcedDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr, nameof (ForcedDirection));
      CommandRotationInput.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr, nameof (RotationSpeed));
      CommandRotationInput.NativeFieldInfoPtr_CanRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr, nameof (CanRotate));
      CommandRotationInput.NativeFieldInfoPtr_AimDependsOnRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr, nameof (AimDependsOnRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandRotationInput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
