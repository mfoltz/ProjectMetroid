// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.DamageReductionPerTarget
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DamageReductionPerTarget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResetTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReductionModifier;
    [FieldOffset(0)]
    public float HitResetTimer;
    [FieldOffset(4)]
    public float ReductionModifier;

    static DamageReductionPerTarget()
    {
      Il2CppClassPointerStore<DamageReductionPerTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (DamageReductionPerTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageReductionPerTarget>.NativeClassPtr);
      DamageReductionPerTarget.NativeFieldInfoPtr_HitResetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageReductionPerTarget>.NativeClassPtr, nameof (HitResetTimer));
      DamageReductionPerTarget.NativeFieldInfoPtr_ReductionModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageReductionPerTarget>.NativeClassPtr, nameof (ReductionModifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DamageReductionPerTarget>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
