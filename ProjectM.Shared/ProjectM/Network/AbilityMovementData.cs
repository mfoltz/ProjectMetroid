// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.AbilityMovementData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityMovementData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ForcePositionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveStopAbilityData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeIntoCast;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsCasting;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasMoveStopData;
    [FieldOffset(0)]
    public ForcePositionData ForcePositionData;
    [FieldOffset(64)]
    public MoveStopAbilityData MoveStopAbilityData;
    [FieldOffset(76)]
    public float TimeIntoCast;
    [FieldOffset(80)]
    public bool IsCasting;
    [FieldOffset(81)]
    public bool HasMoveStopData;

    static AbilityMovementData()
    {
      Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (AbilityMovementData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr);
      AbilityMovementData.NativeFieldInfoPtr_ForcePositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr, nameof (ForcePositionData));
      AbilityMovementData.NativeFieldInfoPtr_MoveStopAbilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr, nameof (MoveStopAbilityData));
      AbilityMovementData.NativeFieldInfoPtr_TimeIntoCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr, nameof (TimeIntoCast));
      AbilityMovementData.NativeFieldInfoPtr_IsCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr, nameof (IsCasting));
      AbilityMovementData.NativeFieldInfoPtr_HasMoveStopData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr, nameof (HasMoveStopData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMovementData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
