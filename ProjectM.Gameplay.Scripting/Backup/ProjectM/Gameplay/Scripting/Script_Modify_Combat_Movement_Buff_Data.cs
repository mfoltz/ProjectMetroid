// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_Data
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Modify_Combat_Movement_Buff_Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistanceOuter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovePattern;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceLookAtTarget;
    [FieldOffset(0)]
    public float MinDistance;
    [FieldOffset(4)]
    public float GoalDistance;
    [FieldOffset(8)]
    public float GoalDistanceOuter;
    [FieldOffset(12)]
    public float MaxDistance;
    [FieldOffset(16)]
    public AiMovePattern MovePattern;
    [FieldOffset(17)]
    public AiForceLookAtTarget ForceLookAtTarget;

    static Script_Modify_Combat_Movement_Buff_Data()
    {
      Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Modify_Combat_Movement_Buff_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr);
      Script_Modify_Combat_Movement_Buff_Data.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr, nameof (MinDistance));
      Script_Modify_Combat_Movement_Buff_Data.NativeFieldInfoPtr_GoalDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr, nameof (GoalDistance));
      Script_Modify_Combat_Movement_Buff_Data.NativeFieldInfoPtr_GoalDistanceOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr, nameof (GoalDistanceOuter));
      Script_Modify_Combat_Movement_Buff_Data.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr, nameof (MaxDistance));
      Script_Modify_Combat_Movement_Buff_Data.NativeFieldInfoPtr_MovePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr, nameof (MovePattern));
      Script_Modify_Combat_Movement_Buff_Data.NativeFieldInfoPtr_ForceLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr, nameof (ForceLookAtTarget));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
