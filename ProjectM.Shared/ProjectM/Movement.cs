// Decompiled with JetBrains decompiler
// Type: ProjectM.Movement
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
  public struct Movement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ForcePositionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveStopAbilityData;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastNonZeroMoveInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCastSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasMoveStopData;
    [FieldOffset(0)]
    public ForcePositionData ForcePositionData;
    [FieldOffset(64)]
    public MoveStopAbilityData MoveStopAbilityData;
    [FieldOffset(76)]
    public float2 MoveInput;
    [FieldOffset(84)]
    public float2 LastNonZeroMoveInput;
    [FieldOffset(92)]
    public ModifiableFloat Speed;
    [FieldOffset(100)]
    public float AbilityCastSpeedMultiplier;
    [FieldOffset(104)]
    public bool HasMoveStopData;

    static Movement()
    {
      Il2CppClassPointerStore<Movement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Movement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Movement>.NativeClassPtr);
      Movement.NativeFieldInfoPtr_ForcePositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, nameof (ForcePositionData));
      Movement.NativeFieldInfoPtr_MoveStopAbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, nameof (MoveStopAbilityData));
      Movement.NativeFieldInfoPtr_MoveInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, nameof (MoveInput));
      Movement.NativeFieldInfoPtr_LastNonZeroMoveInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, nameof (LastNonZeroMoveInput));
      Movement.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, nameof (Speed));
      Movement.NativeFieldInfoPtr_AbilityCastSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, nameof (AbilityCastSpeedMultiplier));
      Movement.NativeFieldInfoPtr_HasMoveStopData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Movement>.NativeClassPtr, nameof (HasMoveStopData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Movement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
