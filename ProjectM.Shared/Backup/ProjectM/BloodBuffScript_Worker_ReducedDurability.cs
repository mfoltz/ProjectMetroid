// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuffScript_Worker_ReducedDurability
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuffScript_Worker_ReducedDurability
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinReduceDurabilityLossOnResources;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxReduceDurabilityLossOnResources;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReduceDurabilityLossOnResourcesModificationId;
    [FieldOffset(0)]
    public float MinReduceDurabilityLossOnResources;
    [FieldOffset(4)]
    public float MaxReduceDurabilityLossOnResources;
    [FieldOffset(8)]
    public float RequiredBloodPercentage;
    [FieldOffset(12)]
    public ModificationId ReduceDurabilityLossOnResourcesModificationId;

    static BloodBuffScript_Worker_ReducedDurability()
    {
      Il2CppClassPointerStore<BloodBuffScript_Worker_ReducedDurability>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuffScript_Worker_ReducedDurability));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuffScript_Worker_ReducedDurability>.NativeClassPtr);
      BloodBuffScript_Worker_ReducedDurability.NativeFieldInfoPtr_MinReduceDurabilityLossOnResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Worker_ReducedDurability>.NativeClassPtr, nameof (MinReduceDurabilityLossOnResources));
      BloodBuffScript_Worker_ReducedDurability.NativeFieldInfoPtr_MaxReduceDurabilityLossOnResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Worker_ReducedDurability>.NativeClassPtr, nameof (MaxReduceDurabilityLossOnResources));
      BloodBuffScript_Worker_ReducedDurability.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Worker_ReducedDurability>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuffScript_Worker_ReducedDurability.NativeFieldInfoPtr_ReduceDurabilityLossOnResourcesModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuffScript_Worker_ReducedDurability>.NativeClassPtr, nameof (ReduceDurabilityLossOnResourcesModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuffScript_Worker_ReducedDurability>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
