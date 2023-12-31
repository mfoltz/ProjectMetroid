// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.IgnoreHitsPerTarget
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IgnoreHitsPerTarget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HitResetTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReductionModifier;
    [FieldOffset(0)]
    public float HitResetTimer;
    [FieldOffset(4)]
    public float ReductionModifier;

    static IgnoreHitsPerTarget()
    {
      Il2CppClassPointerStore<IgnoreHitsPerTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (IgnoreHitsPerTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreHitsPerTarget>.NativeClassPtr);
      IgnoreHitsPerTarget.NativeFieldInfoPtr_HitResetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoreHitsPerTarget>.NativeClassPtr, nameof (HitResetTimer));
      IgnoreHitsPerTarget.NativeFieldInfoPtr_ReductionModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoreHitsPerTarget>.NativeClassPtr, nameof (ReductionModifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IgnoreHitsPerTarget>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
