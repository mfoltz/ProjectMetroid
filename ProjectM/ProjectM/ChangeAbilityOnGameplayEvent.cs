// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangeAbilityOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ChangeAbilityOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotIndex;
    [FieldOffset(0)]
    public ChangeAbilityTarget Target;
    [FieldOffset(4)]
    public PrefabGUID AbilityGroupId;
    [FieldOffset(8)]
    public int SlotIndex;

    static ChangeAbilityOnGameplayEvent()
    {
      Il2CppClassPointerStore<ChangeAbilityOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChangeAbilityOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeAbilityOnGameplayEvent>.NativeClassPtr);
      ChangeAbilityOnGameplayEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeAbilityOnGameplayEvent>.NativeClassPtr, nameof (Target));
      ChangeAbilityOnGameplayEvent.NativeFieldInfoPtr_AbilityGroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeAbilityOnGameplayEvent>.NativeClassPtr, nameof (AbilityGroupId));
      ChangeAbilityOnGameplayEvent.NativeFieldInfoPtr_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeAbilityOnGameplayEvent>.NativeClassPtr, nameof (SlotIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeAbilityOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
