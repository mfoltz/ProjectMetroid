// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_DamageZone_SingleTarget_HitConditions_Editor
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [Serializable]
  public sealed class Script_DamageZone_SingleTarget_HitConditions_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTargetHitEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Timer;

    static Script_DamageZone_SingleTarget_HitConditions_Editor()
    {
      Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_DamageZone_SingleTarget_HitConditions_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions_Editor>.NativeClassPtr);
      Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions_Editor>.NativeClassPtr, nameof (Condition));
      Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_OnTargetHitEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions_Editor>.NativeClassPtr, nameof (OnTargetHitEventId));
      Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions_Editor>.NativeClassPtr, nameof (Timer));
    }

    public Script_DamageZone_SingleTarget_HitConditions_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Script_DamageZone_SingleTarget_HitConditions_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_DamageZone_SingleTarget_HitConditions_Editor>.NativeClassPtr, data));
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Condition
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_Condition));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_Condition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public GameplayEventIdSource OnTargetHitEventId
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_OnTargetHitEventId);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_OnTargetHitEventId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float Timer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_Timer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_DamageZone_SingleTarget_HitConditions_Editor.NativeFieldInfoPtr_Timer)) = value;
      }
    }
  }
}
