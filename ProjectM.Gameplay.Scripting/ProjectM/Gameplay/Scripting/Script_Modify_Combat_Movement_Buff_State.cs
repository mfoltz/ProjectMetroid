// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Modify_Combat_Movement_Buff_State
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Modify_Combat_Movement_Buff_State
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistanceModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistanceModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalDistanceOuterModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovePatternModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceLookAtTargetModId;
    [FieldOffset(0)]
    public ModificationId MinDistanceModId;
    [FieldOffset(4)]
    public ModificationId GoalDistanceModId;
    [FieldOffset(8)]
    public ModificationId GoalDistanceOuterModId;
    [FieldOffset(12)]
    public ModificationId MaxDistanceModId;
    [FieldOffset(16)]
    public ModificationId MovePatternModId;
    [FieldOffset(20)]
    public ModificationId ForceLookAtTargetModId;

    static Script_Modify_Combat_Movement_Buff_State()
    {
      Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Modify_Combat_Movement_Buff_State));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr);
      Script_Modify_Combat_Movement_Buff_State.NativeFieldInfoPtr_MinDistanceModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr, nameof (MinDistanceModId));
      Script_Modify_Combat_Movement_Buff_State.NativeFieldInfoPtr_GoalDistanceModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr, nameof (GoalDistanceModId));
      Script_Modify_Combat_Movement_Buff_State.NativeFieldInfoPtr_GoalDistanceOuterModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr, nameof (GoalDistanceOuterModId));
      Script_Modify_Combat_Movement_Buff_State.NativeFieldInfoPtr_MaxDistanceModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr, nameof (MaxDistanceModId));
      Script_Modify_Combat_Movement_Buff_State.NativeFieldInfoPtr_MovePatternModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr, nameof (MovePatternModId));
      Script_Modify_Combat_Movement_Buff_State.NativeFieldInfoPtr_ForceLookAtTargetModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr, nameof (ForceLookAtTargetModId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Modify_Combat_Movement_Buff_State>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
