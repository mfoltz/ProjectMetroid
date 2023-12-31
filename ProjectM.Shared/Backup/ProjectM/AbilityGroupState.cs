// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityGroupState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotIndex;
    [FieldOffset(0)]
    public NetworkedEntity Character;
    [FieldOffset(12)]
    public PrefabGUID GroupId;
    [FieldOffset(16)]
    public int SlotIndex;

    static AbilityGroupState()
    {
      Il2CppClassPointerStore<AbilityGroupState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityGroupState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupState>.NativeClassPtr);
      AbilityGroupState.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupState>.NativeClassPtr, nameof (Character));
      AbilityGroupState.NativeFieldInfoPtr_GroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupState>.NativeClassPtr, nameof (GroupId));
      AbilityGroupState.NativeFieldInfoPtr_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupState>.NativeClassPtr, nameof (SlotIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
