// Decompiled with JetBrains decompiler
// Type: ProjectM.EditableTileModel_Client
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EditableTileModel_Client
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentEditOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr_EffectTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveEffectTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredCanBeEditedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredOnlyDismantleSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredBlockedSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantlingSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairingSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditedSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantlingSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairingSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHovered;
    [FieldOffset(0)]
    public EditableTileModel_Client.EditOptions CurrentEditOptions;
    [FieldOffset(4)]
    public Entity EffectTarget;
    [FieldOffset(12)]
    public Entity ActiveEffectTarget;
    [FieldOffset(20)]
    public SequenceGUID EditedSequence;
    [FieldOffset(24)]
    public SequenceGUID HoveredCanBeEditedSequence;
    [FieldOffset(28)]
    public SequenceGUID HoveredOnlyDismantleSequence;
    [FieldOffset(32)]
    public SequenceGUID HoveredBlockedSequence;
    [FieldOffset(36)]
    public SequenceGUID DismantlingSequence;
    [FieldOffset(40)]
    public SequenceGUID RepairingSequence;
    [FieldOffset(44)]
    public SequenceState EditedSequenceState;
    [FieldOffset(52)]
    public SequenceState HoveredSequenceState;
    [FieldOffset(60)]
    public SequenceState DismantlingSequenceState;
    [FieldOffset(68)]
    public SequenceState RepairingSequenceState;
    [FieldOffset(76)]
    public bool IsHovered;

    static EditableTileModel_Client()
    {
      Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EditableTileModel_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr);
      EditableTileModel_Client.NativeFieldInfoPtr_CurrentEditOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (CurrentEditOptions));
      EditableTileModel_Client.NativeFieldInfoPtr_EffectTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (EffectTarget));
      EditableTileModel_Client.NativeFieldInfoPtr_ActiveEffectTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (ActiveEffectTarget));
      EditableTileModel_Client.NativeFieldInfoPtr_EditedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (EditedSequence));
      EditableTileModel_Client.NativeFieldInfoPtr_HoveredCanBeEditedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (HoveredCanBeEditedSequence));
      EditableTileModel_Client.NativeFieldInfoPtr_HoveredOnlyDismantleSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (HoveredOnlyDismantleSequence));
      EditableTileModel_Client.NativeFieldInfoPtr_HoveredBlockedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (HoveredBlockedSequence));
      EditableTileModel_Client.NativeFieldInfoPtr_DismantlingSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (DismantlingSequence));
      EditableTileModel_Client.NativeFieldInfoPtr_RepairingSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (RepairingSequence));
      EditableTileModel_Client.NativeFieldInfoPtr_EditedSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (EditedSequenceState));
      EditableTileModel_Client.NativeFieldInfoPtr_HoveredSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (HoveredSequenceState));
      EditableTileModel_Client.NativeFieldInfoPtr_DismantlingSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (DismantlingSequenceState));
      EditableTileModel_Client.NativeFieldInfoPtr_RepairingSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (RepairingSequenceState));
      EditableTileModel_Client.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, nameof (IsHovered));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EditableTileModel_Client>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum EditOptions
    {
      CanBeEdited,
      OnlyDismantle,
      Blocked,
      OnlyRepair,
    }
  }
}
