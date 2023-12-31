// Decompiled with JetBrains decompiler
// Type: ProjectM.EmpowerStackModifier
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EmpowerStackModifier
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerStackValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Modifier;
    [FieldOffset(0)]
    public float BaseValue;
    [FieldOffset(4)]
    public float PerStackValue;
    [FieldOffset(8)]
    public float Modifier;

    static EmpowerStackModifier()
    {
      Il2CppClassPointerStore<EmpowerStackModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EmpowerStackModifier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmpowerStackModifier>.NativeClassPtr);
      EmpowerStackModifier.NativeFieldInfoPtr_BaseValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmpowerStackModifier>.NativeClassPtr, nameof (BaseValue));
      EmpowerStackModifier.NativeFieldInfoPtr_PerStackValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmpowerStackModifier>.NativeClassPtr, nameof (PerStackValue));
      EmpowerStackModifier.NativeFieldInfoPtr_Modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmpowerStackModifier>.NativeClassPtr, nameof (Modifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EmpowerStackModifier>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
