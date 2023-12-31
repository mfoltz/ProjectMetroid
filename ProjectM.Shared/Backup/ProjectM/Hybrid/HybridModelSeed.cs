// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelSeed
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridModelSeed
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasSetSeed;
    [FieldOffset(0)]
    public ushort Seed;
    [FieldOffset(2)]
    public bool HasSetSeed;

    static HybridModelSeed()
    {
      Il2CppClassPointerStore<HybridModelSeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (HybridModelSeed));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSeed>.NativeClassPtr);
      HybridModelSeed.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSeed>.NativeClassPtr, nameof (Seed));
      HybridModelSeed.NativeFieldInfoPtr_HasSetSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSeed>.NativeClassPtr, nameof (HasSetSeed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSeed>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
