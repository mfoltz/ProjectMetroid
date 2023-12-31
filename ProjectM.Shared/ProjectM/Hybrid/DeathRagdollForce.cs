// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.DeathRagdollForce
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DeathRagdollForce
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Force;
    [FieldOffset(0)]
    public float3 Force;

    static DeathRagdollForce()
    {
      Il2CppClassPointerStore<DeathRagdollForce>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (DeathRagdollForce));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathRagdollForce>.NativeClassPtr);
      DeathRagdollForce.NativeFieldInfoPtr_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathRagdollForce>.NativeClassPtr, nameof (Force));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeathRagdollForce>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
