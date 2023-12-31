// Decompiled with JetBrains decompiler
// Type: ProjectM.Buff
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
  public struct Buff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetAge;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_CorrectlyCreated;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffEffectType;
    [FieldOffset(0)]
    public double StartTimeUnmodified;
    [FieldOffset(8)]
    public Entity Target;
    [FieldOffset(16)]
    public BuffType BuffType;
    [FieldOffset(17)]
    public byte Stacks;
    [FieldOffset(18)]
    public byte MaxStacks;
    [FieldOffset(19)]
    public bool ResetAge;
    [FieldOffset(20)]
    public bool IncreaseStacks;
    [FieldOffset(21)]
    public bool CorrectlyCreated;
    [FieldOffset(24)]
    public BuffEffectType BuffEffectType;

    static Buff()
    {
      Il2CppClassPointerStore<Buff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Buff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff>.NativeClassPtr);
      Buff.NativeFieldInfoPtr_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (StartTimeUnmodified));
      Buff.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (Target));
      Buff.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (BuffType));
      Buff.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (Stacks));
      Buff.NativeFieldInfoPtr_MaxStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (MaxStacks));
      Buff.NativeFieldInfoPtr_ResetAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (ResetAge));
      Buff.NativeFieldInfoPtr_IncreaseStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (IncreaseStacks));
      Buff.NativeFieldInfoPtr_CorrectlyCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (CorrectlyCreated));
      Buff.NativeFieldInfoPtr_BuffEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff>.NativeClassPtr, nameof (BuffEffectType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
