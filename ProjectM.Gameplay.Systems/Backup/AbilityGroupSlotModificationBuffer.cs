// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupSlotModificationBuffer
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityGroupSlotModificationBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyCooldownModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewAbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slot;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastBlockType;
    [FieldOffset(0)]
    public Entity Owner;
    [FieldOffset(8)]
    public Entity Target;
    [FieldOffset(16)]
    public ModificationId ModificationId;
    [FieldOffset(20)]
    public ModificationId CopyCooldownModificationId;
    [FieldOffset(24)]
    public ModificationId SpellModModificationId;
    [FieldOffset(28)]
    public PrefabGUID NewAbilityGroup;
    [FieldOffset(32)]
    public int Priority;
    [FieldOffset(36)]
    public int Slot;
    [FieldOffset(40)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(48)]
    public Entity ConditionTarget;
    [FieldOffset(56)]
    public bool CopyCooldown;
    [FieldOffset(60)]
    public GroupSlotModificationCastBlockType CastBlockType;

    static AbilityGroupSlotModificationBuffer()
    {
      Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityGroupSlotModificationBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr);
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (Owner));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (Target));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_ModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (ModificationId));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_CopyCooldownModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (CopyCooldownModificationId));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_SpellModModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (SpellModModificationId));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_NewAbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (NewAbilityGroup));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (Priority));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (Slot));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (Condition));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_ConditionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (ConditionTarget));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_CopyCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (CopyCooldown));
      AbilityGroupSlotModificationBuffer.NativeFieldInfoPtr_CastBlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, nameof (CastBlockType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupSlotModificationBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
