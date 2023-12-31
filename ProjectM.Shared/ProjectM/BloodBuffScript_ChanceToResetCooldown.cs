// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuffScript_ChanceToResetCooldown
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuffScript_ChanceToResetCooldown
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_Chance;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerSequence;
    [FieldOffset(0)]
    public AssetGuid SCT;
    [FieldOffset(16)]
    public float Chance;
    [FieldOffset(20)]
    public SequenceGUID TriggerSequence;

    static BloodBuffScript_ChanceToResetCooldown()
    {
      Il2CppClassPointerStore<BloodBuffScript_ChanceToResetCooldown>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuffScript_ChanceToResetCooldown));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffScript_ChanceToResetCooldown>.NativeClassPtr);
      BloodBuffScript_ChanceToResetCooldown.NativeFieldInfoPtr_SCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_ChanceToResetCooldown>.NativeClassPtr, nameof (SCT));
      BloodBuffScript_ChanceToResetCooldown.NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_ChanceToResetCooldown>.NativeClassPtr, nameof (Chance));
      BloodBuffScript_ChanceToResetCooldown.NativeFieldInfoPtr_TriggerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_ChanceToResetCooldown>.NativeClassPtr, nameof (TriggerSequence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffScript_ChanceToResetCooldown>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
