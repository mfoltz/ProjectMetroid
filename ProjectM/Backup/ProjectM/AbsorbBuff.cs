// Decompiled with JetBrains decompiler
// Type: ProjectM.AbsorbBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbsorbBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbCap;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float AbsorbModifier;
    [FieldOffset(4)]
    public float AbsorbCap;
    [FieldOffset(8)]
    public float AbsorbValue;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1000433, RefRangeEnd = 1000434, XrefRangeStart = 1000431, XrefRangeEnd = 1000433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbsorbBuff.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbsorbBuff()
    {
      Il2CppClassPointerStore<AbsorbBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbsorbBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbsorbBuff>.NativeClassPtr);
      AbsorbBuff.NativeFieldInfoPtr_AbsorbModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuff>.NativeClassPtr, nameof (AbsorbModifier));
      AbsorbBuff.NativeFieldInfoPtr_AbsorbCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuff>.NativeClassPtr, nameof (AbsorbCap));
      AbsorbBuff.NativeFieldInfoPtr_AbsorbValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuff>.NativeClassPtr, nameof (AbsorbValue));
      AbsorbBuff.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsorbBuff>.NativeClassPtr, 100677413);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbsorbBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
