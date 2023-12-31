// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupSlot
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityGroupSlot
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_StateEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousStateEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModsId;
    [FieldOffset(0)]
    public ModifiablePrefabGUID GroupGuid;
    [FieldOffset(8)]
    public NetworkedEntity AbilityBar;
    [FieldOffset(20)]
    public NetworkedEntity StateEntity;
    [FieldOffset(32)]
    public NetworkedEntity PreviousStateEntity;
    [FieldOffset(44)]
    public int SlotId;
    [FieldOffset(48)]
    public ModifiableBool CopyCooldown;
    [FieldOffset(52)]
    public ModifiableInt SpellModsId;

    static AbilityGroupSlot()
    {
      Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityGroupSlot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr);
      AbilityGroupSlot.NativeFieldInfoPtr_GroupGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (GroupGuid));
      AbilityGroupSlot.NativeFieldInfoPtr_AbilityBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (AbilityBar));
      AbilityGroupSlot.NativeFieldInfoPtr_StateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (StateEntity));
      AbilityGroupSlot.NativeFieldInfoPtr_PreviousStateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (PreviousStateEntity));
      AbilityGroupSlot.NativeFieldInfoPtr_SlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (SlotId));
      AbilityGroupSlot.NativeFieldInfoPtr_CopyCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (CopyCooldown));
      AbilityGroupSlot.NativeFieldInfoPtr_SpellModsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (SpellModsId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DirtyTag
    {
      static DirtyTag()
      {
        Il2CppClassPointerStore<AbilityGroupSlot.DirtyTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityGroupSlot>.NativeClassPtr, nameof (DirtyTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupSlot.DirtyTag>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupSlot.DirtyTag>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
