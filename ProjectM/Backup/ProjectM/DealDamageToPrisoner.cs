// Decompiled with JetBrains decompiler
// Type: ProjectM.DealDamageToPrisoner
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DealDamageToPrisoner
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DealPercentualDamage_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealPercentualDamage_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealPercentualTorture_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealPercentualTorture_Max;
    [FieldOffset(0)]
    public float DealPercentualDamage_Min;
    [FieldOffset(4)]
    public float DealPercentualDamage_Max;
    [FieldOffset(8)]
    public float DealPercentualTorture_Min;
    [FieldOffset(12)]
    public float DealPercentualTorture_Max;

    static DealDamageToPrisoner()
    {
      Il2CppClassPointerStore<DealDamageToPrisoner>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DealDamageToPrisoner));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageToPrisoner>.NativeClassPtr);
      DealDamageToPrisoner.NativeFieldInfoPtr_DealPercentualDamage_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageToPrisoner>.NativeClassPtr, nameof (DealPercentualDamage_Min));
      DealDamageToPrisoner.NativeFieldInfoPtr_DealPercentualDamage_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageToPrisoner>.NativeClassPtr, nameof (DealPercentualDamage_Max));
      DealDamageToPrisoner.NativeFieldInfoPtr_DealPercentualTorture_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageToPrisoner>.NativeClassPtr, nameof (DealPercentualTorture_Min));
      DealDamageToPrisoner.NativeFieldInfoPtr_DealPercentualTorture_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageToPrisoner>.NativeClassPtr, nameof (DealPercentualTorture_Max));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageToPrisoner>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
