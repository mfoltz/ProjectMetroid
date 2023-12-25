// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAbilityOnSlotWhenMountedBuffElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReplaceAbilityOnSlotWhenMountedBuffElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewGroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    [FieldOffset(0)]
    public int AbilitySlotIndex;
    [FieldOffset(4)]
    public PrefabGUID NewGroupId;
    [FieldOffset(8)]
    public int Priority;

    static ReplaceAbilityOnSlotWhenMountedBuffElement()
    {
      Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaceAbilityOnSlotWhenMountedBuffElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffElement>.NativeClassPtr);
      ReplaceAbilityOnSlotWhenMountedBuffElement.NativeFieldInfoPtr_AbilitySlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffElement>.NativeClassPtr, nameof (AbilitySlotIndex));
      ReplaceAbilityOnSlotWhenMountedBuffElement.NativeFieldInfoPtr_NewGroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffElement>.NativeClassPtr, nameof (NewGroupId));
      ReplaceAbilityOnSlotWhenMountedBuffElement.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffElement>.NativeClassPtr, nameof (Priority));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
