// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffResistanceElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct BuffResistanceElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModifyDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationModifier;
    [FieldOffset(0)]
    public long BuffCategory;
    [FieldOffset(8)]
    public bool ModifyDuration;
    [FieldOffset(12)]
    public float DurationModifier;

    static BuffResistanceElement()
    {
      Il2CppClassPointerStore<BuffResistanceElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffResistanceElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffResistanceElement>.NativeClassPtr);
      BuffResistanceElement.NativeFieldInfoPtr_BuffCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffResistanceElement>.NativeClassPtr, nameof (BuffCategory));
      BuffResistanceElement.NativeFieldInfoPtr_ModifyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffResistanceElement>.NativeClassPtr, nameof (ModifyDuration));
      BuffResistanceElement.NativeFieldInfoPtr_DurationModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffResistanceElement>.NativeClassPtr, nameof (DurationModifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffResistanceElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
