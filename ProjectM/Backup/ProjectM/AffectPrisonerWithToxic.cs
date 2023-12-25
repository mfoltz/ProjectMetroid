// Decompiled with JetBrains decompiler
// Type: ProjectM.AffectPrisonerWithToxic
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AffectPrisonerWithToxic
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChanceToBecomeMutant;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseBloodQuality_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseBloodQuality_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_MutantType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnBuff;
    [FieldOffset(0)]
    public float ChanceToBecomeMutant;
    [FieldOffset(4)]
    public float IncreaseBloodQuality_Min;
    [FieldOffset(8)]
    public float IncreaseBloodQuality_Max;
    [FieldOffset(12)]
    public PrefabGUID MutantType;
    [FieldOffset(16)]
    public PrefabGUID SpawnBuff;

    static AffectPrisonerWithToxic()
    {
      Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AffectPrisonerWithToxic));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr);
      AffectPrisonerWithToxic.NativeFieldInfoPtr_ChanceToBecomeMutant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr, nameof (ChanceToBecomeMutant));
      AffectPrisonerWithToxic.NativeFieldInfoPtr_IncreaseBloodQuality_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr, nameof (IncreaseBloodQuality_Min));
      AffectPrisonerWithToxic.NativeFieldInfoPtr_IncreaseBloodQuality_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr, nameof (IncreaseBloodQuality_Max));
      AffectPrisonerWithToxic.NativeFieldInfoPtr_MutantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr, nameof (MutantType));
      AffectPrisonerWithToxic.NativeFieldInfoPtr_SpawnBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr, nameof (SpawnBuff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AffectPrisonerWithToxic>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
