// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleDecayAndRegen
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleDecayAndRegen
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastUpdatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DecayFactorOnTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegenFactorOnTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_DecayThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanDieFromDecay;
    [FieldOffset(0)]
    public double LastUpdatedTime;
    [FieldOffset(8)]
    public half DecayFactorOnTick;
    [FieldOffset(10)]
    public half RegenFactorOnTick;
    [FieldOffset(12)]
    public half DecayThreshold;
    [FieldOffset(14)]
    public bool CanDieFromDecay;

    static CastleDecayAndRegen()
    {
      Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CastleDecayAndRegen));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr);
      CastleDecayAndRegen.NativeFieldInfoPtr_LastUpdatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr, nameof (LastUpdatedTime));
      CastleDecayAndRegen.NativeFieldInfoPtr_DecayFactorOnTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr, nameof (DecayFactorOnTick));
      CastleDecayAndRegen.NativeFieldInfoPtr_RegenFactorOnTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr, nameof (RegenFactorOnTick));
      CastleDecayAndRegen.NativeFieldInfoPtr_DecayThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr, nameof (DecayThreshold));
      CastleDecayAndRegen.NativeFieldInfoPtr_CanDieFromDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr, nameof (CanDieFromDecay));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleDecayAndRegen>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
