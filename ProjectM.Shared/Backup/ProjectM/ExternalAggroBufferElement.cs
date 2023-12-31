// Decompiled with JetBrains decompiler
// Type: ProjectM.ExternalAggroBufferElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ExternalAggroBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModCount;
    [FieldOffset(0)]
    public ModifiableFloat Value;
    [FieldOffset(8)]
    public Entity Source;
    [FieldOffset(16)]
    public int ModCount;

    static ExternalAggroBufferElement()
    {
      Il2CppClassPointerStore<ExternalAggroBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ExternalAggroBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalAggroBufferElement>.NativeClassPtr);
      ExternalAggroBufferElement.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAggroBufferElement>.NativeClassPtr, nameof (Value));
      ExternalAggroBufferElement.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAggroBufferElement>.NativeClassPtr, nameof (Source));
      ExternalAggroBufferElement.NativeFieldInfoPtr_ModCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAggroBufferElement>.NativeClassPtr, nameof (ModCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExternalAggroBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
