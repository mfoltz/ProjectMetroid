// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.DamageReductionPerTargetElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DamageReductionPerTargetElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeHit;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReductionModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReductionGroup;
    [FieldOffset(0)]
    public double TimeHit;
    [FieldOffset(8)]
    public float ReductionModifier;
    [FieldOffset(12)]
    public Entity Target;
    [FieldOffset(20)]
    public int ReductionGroup;

    static DamageReductionPerTargetElement()
    {
      Il2CppClassPointerStore<DamageReductionPerTargetElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (DamageReductionPerTargetElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageReductionPerTargetElement>.NativeClassPtr);
      DamageReductionPerTargetElement.NativeFieldInfoPtr_TimeHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageReductionPerTargetElement>.NativeClassPtr, nameof (TimeHit));
      DamageReductionPerTargetElement.NativeFieldInfoPtr_ReductionModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageReductionPerTargetElement>.NativeClassPtr, nameof (ReductionModifier));
      DamageReductionPerTargetElement.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageReductionPerTargetElement>.NativeClassPtr, nameof (Target));
      DamageReductionPerTargetElement.NativeFieldInfoPtr_ReductionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageReductionPerTargetElement>.NativeClassPtr, nameof (ReductionGroup));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DamageReductionPerTargetElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
