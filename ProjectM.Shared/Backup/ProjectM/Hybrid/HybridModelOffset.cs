// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelOffset
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
  public struct HybridModelOffset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualOffset;
    [FieldOffset(0)]
    public float3 VisualOffset;

    static HybridModelOffset()
    {
      Il2CppClassPointerStore<HybridModelOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (HybridModelOffset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelOffset>.NativeClassPtr);
      HybridModelOffset.NativeFieldInfoPtr_VisualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelOffset>.NativeClassPtr, nameof (VisualOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelOffset>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
