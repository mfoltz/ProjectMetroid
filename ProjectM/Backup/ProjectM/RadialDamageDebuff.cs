// Decompiled with JetBrains decompiler
// Type: ProjectM.RadialDamageDebuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RadialDamageDebuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OuterDamagePerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_OuterRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_InnerDamagePerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_InnerRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageSum;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageIncrements;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageType;
    [FieldOffset(0)]
    public float OuterDamagePerSecond;
    [FieldOffset(4)]
    public float OuterRadius;
    [FieldOffset(8)]
    public float InnerDamagePerSecond;
    [FieldOffset(12)]
    public float InnerRadius;
    [FieldOffset(16)]
    public float DamageSum;
    [FieldOffset(20)]
    public float DamageIncrements;
    [FieldOffset(24)]
    public MainDamageType DamageType;

    static RadialDamageDebuff()
    {
      Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RadialDamageDebuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr);
      RadialDamageDebuff.NativeFieldInfoPtr_OuterDamagePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, nameof (OuterDamagePerSecond));
      RadialDamageDebuff.NativeFieldInfoPtr_OuterRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, nameof (OuterRadius));
      RadialDamageDebuff.NativeFieldInfoPtr_InnerDamagePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, nameof (InnerDamagePerSecond));
      RadialDamageDebuff.NativeFieldInfoPtr_InnerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, nameof (InnerRadius));
      RadialDamageDebuff.NativeFieldInfoPtr_DamageSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, nameof (DamageSum));
      RadialDamageDebuff.NativeFieldInfoPtr_DamageIncrements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, nameof (DamageIncrements));
      RadialDamageDebuff.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, nameof (DamageType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RadialDamageDebuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
