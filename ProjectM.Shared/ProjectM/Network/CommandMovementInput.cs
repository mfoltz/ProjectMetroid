// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CommandMovementInput
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
  public struct CommandMovementInput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCastSpeedMultiplier;
    [FieldOffset(0)]
    public float2 MoveDirection;
    [FieldOffset(8)]
    public float AbilityCastSpeedMultiplier;

    static CommandMovementInput()
    {
      Il2CppClassPointerStore<CommandMovementInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (CommandMovementInput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandMovementInput>.NativeClassPtr);
      CommandMovementInput.NativeFieldInfoPtr_MoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandMovementInput>.NativeClassPtr, nameof (MoveDirection));
      CommandMovementInput.NativeFieldInfoPtr_AbilityCastSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandMovementInput>.NativeClassPtr, nameof (AbilityCastSpeedMultiplier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandMovementInput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
