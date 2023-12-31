// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ImpactMaterial
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ImpactMaterial
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayOnSelf;
    [FieldOffset(0)]
    public ImpactMaterialType Type;
    [FieldOffset(4)]
    public float3 Offset;
    [FieldOffset(16)]
    public bool PlayOnSelf;

    static ImpactMaterial()
    {
      Il2CppClassPointerStore<ImpactMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Sequencer", nameof (ImpactMaterial));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactMaterial>.NativeClassPtr);
      ImpactMaterial.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterial>.NativeClassPtr, nameof (Type));
      ImpactMaterial.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterial>.NativeClassPtr, nameof (Offset));
      ImpactMaterial.NativeFieldInfoPtr_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterial>.NativeClassPtr, nameof (PlayOnSelf));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImpactMaterial>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
