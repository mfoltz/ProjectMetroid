// Decompiled with JetBrains decompiler
// Type: ProjectM.PrisonCell
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PrisonCell
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_PsychicForm;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresPsychicForm;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_TargetIsImmune;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImprisonedBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImprisonedEntity;
    [FieldOffset(0)]
    public PrefabGUID Buff_PsychicForm;
    [FieldOffset(4)]
    public AssetGuid LKey_RequiresPsychicForm;
    [FieldOffset(20)]
    public AssetGuid LKey_TargetIsImmune;
    [FieldOffset(36)]
    public PrefabGUID ImprisonedBuff;
    [FieldOffset(40)]
    public NetworkedEntity ImprisonedEntity;

    static PrisonCell()
    {
      Il2CppClassPointerStore<PrisonCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrisonCell));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonCell>.NativeClassPtr);
      PrisonCell.NativeFieldInfoPtr_Buff_PsychicForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCell>.NativeClassPtr, nameof (Buff_PsychicForm));
      PrisonCell.NativeFieldInfoPtr_LKey_RequiresPsychicForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCell>.NativeClassPtr, nameof (LKey_RequiresPsychicForm));
      PrisonCell.NativeFieldInfoPtr_LKey_TargetIsImmune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCell>.NativeClassPtr, nameof (LKey_TargetIsImmune));
      PrisonCell.NativeFieldInfoPtr_ImprisonedBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCell>.NativeClassPtr, nameof (ImprisonedBuff));
      PrisonCell.NativeFieldInfoPtr_ImprisonedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCell>.NativeClassPtr, nameof (ImprisonedEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrisonCell>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
