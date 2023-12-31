// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ImpactMaterialMappingBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ImpactMaterialMappingBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;
    [FieldOffset(0)]
    public ImpactMaterialType Type;
    [FieldOffset(4)]
    public SequenceGUID Sequence;

    static ImpactMaterialMappingBuffer()
    {
      Il2CppClassPointerStore<ImpactMaterialMappingBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Sequencer", nameof (ImpactMaterialMappingBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactMaterialMappingBuffer>.NativeClassPtr);
      ImpactMaterialMappingBuffer.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterialMappingBuffer>.NativeClassPtr, nameof (Type));
      ImpactMaterialMappingBuffer.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactMaterialMappingBuffer>.NativeClassPtr, nameof (Sequence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImpactMaterialMappingBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
