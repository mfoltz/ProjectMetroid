// Decompiled with JetBrains decompiler
// Type: ProjectM.GenericCombatMovementData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GenericCombatMovementData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistanceInner;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistanceOuter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovePattern;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceLookAtTarget;
    [FieldOffset(0)]
    public ModifiableFloat MinDistance;
    [FieldOffset(8)]
    public ModifiableFloat GoalDistanceInner;
    [FieldOffset(16)]
    public ModifiableFloat GoalDistanceOuter;
    [FieldOffset(24)]
    public ModifiableFloat MaxDistance;
    [FieldOffset(32)]
    public ModifiableInt MovePattern;
    [FieldOffset(40)]
    public ModifiableInt ForceLookAtTarget;

    static GenericCombatMovementData()
    {
      Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GenericCombatMovementData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr);
      GenericCombatMovementData.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr, nameof (MinDistance));
      GenericCombatMovementData.NativeFieldInfoPtr_GoalDistanceInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr, nameof (GoalDistanceInner));
      GenericCombatMovementData.NativeFieldInfoPtr_GoalDistanceOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr, nameof (GoalDistanceOuter));
      GenericCombatMovementData.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr, nameof (MaxDistance));
      GenericCombatMovementData.NativeFieldInfoPtr_MovePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr, nameof (MovePattern));
      GenericCombatMovementData.NativeFieldInfoPtr_ForceLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr, nameof (ForceLookAtTarget));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenericCombatMovementData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
