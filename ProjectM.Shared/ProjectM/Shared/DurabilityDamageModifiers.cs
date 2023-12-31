// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.DurabilityDamageModifiers
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct DurabilityDamageModifiers
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MainDamageModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceDamageModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegeDamageModifier;
    [FieldOffset(0)]
    public float MainDamageModifier;
    [FieldOffset(4)]
    public float ResourceDamageModifier;
    [FieldOffset(8)]
    public float SiegeDamageModifier;

    static DurabilityDamageModifiers()
    {
      Il2CppClassPointerStore<DurabilityDamageModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (DurabilityDamageModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurabilityDamageModifiers>.NativeClassPtr);
      DurabilityDamageModifiers.NativeFieldInfoPtr_MainDamageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityDamageModifiers>.NativeClassPtr, nameof (MainDamageModifier));
      DurabilityDamageModifiers.NativeFieldInfoPtr_ResourceDamageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityDamageModifiers>.NativeClassPtr, nameof (ResourceDamageModifier));
      DurabilityDamageModifiers.NativeFieldInfoPtr_SiegeDamageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityDamageModifiers>.NativeClassPtr, nameof (SiegeDamageModifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DurabilityDamageModifiers>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
