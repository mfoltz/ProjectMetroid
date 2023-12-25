// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyAggroRangesBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyAggroRangesBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroCircleRadiusFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroConeRadiusFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertCircleRadiusFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertConeRadiusFactor;
    [FieldOffset(0)]
    public float AggroCircleRadiusFactor;
    [FieldOffset(4)]
    public float AggroConeRadiusFactor;
    [FieldOffset(8)]
    public float AlertCircleRadiusFactor;
    [FieldOffset(12)]
    public float AlertConeRadiusFactor;

    static ModifyAggroRangesBuff()
    {
      Il2CppClassPointerStore<ModifyAggroRangesBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyAggroRangesBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyAggroRangesBuff>.NativeClassPtr);
      ModifyAggroRangesBuff.NativeFieldInfoPtr_AggroCircleRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuff>.NativeClassPtr, nameof (AggroCircleRadiusFactor));
      ModifyAggroRangesBuff.NativeFieldInfoPtr_AggroConeRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuff>.NativeClassPtr, nameof (AggroConeRadiusFactor));
      ModifyAggroRangesBuff.NativeFieldInfoPtr_AlertCircleRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuff>.NativeClassPtr, nameof (AlertCircleRadiusFactor));
      ModifyAggroRangesBuff.NativeFieldInfoPtr_AlertConeRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuff>.NativeClassPtr, nameof (AlertConeRadiusFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyAggroRangesBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
